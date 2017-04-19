; NirvanaAttributes.asm

zeusemulate             "48K"

                        include "constants.asm"
                        include "nirvana+.asm"          ; NIRVANA+ code (modified for relocation by RVG)
org TILE_IMAGES
                        import_bin "test.btile"         ; Test 16x16 NIRVANA+ tile
                        import_bin "tony.btile"         ; Two animation btiles
org $9000

NStart:                 call NIRVANA_start
                                                        ; NIRVANA+ never draws to the top row. Use 8x8 attributes here as normal.
                                                        ; NIRVANA+ will draw down to row 23 if TOTAL_ROWS = 23.
                                                        ; When it is TOTAL_ROWS < 23, NIRVANA+ will use progressively
                                                        ; less Ts per frame.
                                                        ; For the lower rows it doesn't manage, use 8x8 attributes.
                                                        ; For screen positions NIRVANA+ is managing, it will ignore 8x8 attributes.
                                                        ; These remain in place, and be shown when again if you call NIRVANA_stop().
                                                        ; 8x2 attributes are stored sparsely between $DAE9 and $FAEB.
                                                        ; Each 8x2 row is exactly 82 bytes above the previous row.
                                                        ; Within each row, attributes are stored as the data byte of LD opcodes,
                                                        ; and are set either using the NIRVANA+ API, or directly by writing to memory locations.
                                                        ; They are not adjacent. For example, the lowest address within a row block
                                                        ; of 82 bytes is column 14, not column 0. Odd columns always appear exactly one byte
                                                        ; the previous even column. For example column 0 has a delta of 25,
                                                        ; and column 1 has a delta of 26.
                                                        ; Refer to the deltas table at $FF01 for the exact arrangement.
                                                        ; Pixels are always standard Spectrum pixels, whether NIRVANA+ is on or off.
                                                        ; Note that 0 <= rows < 16 are allowed in sprite coordinates, to facilitate
                                                        ; hiding them offscreen or clipping them. However these are not valid attribute locations,
                                                        ; and you will crash or corrupt code if you write to them.
                                                        ; The same is true of 184 > rows >= 200.

                        ld a, Red                       ; Mark bounds of 8x8 attributes in RED
                        ld (ATTRS_8x8), a               ;  0,   0 (all origins top left, X first)
                        ld (ATTRS_8x8+31), a            ; 31,   0
                        ld (ATTRS_8x8_END-31), a        ; 0,   23 (Will be covered up by NIRVANA+
                        ld (ATTRS_8x8_END), a           ; 31,  23  unless you reduce TOTAL_ROWS)

                        ld a, White                     ; Mark bounds of 8x2 attributes in WHITE (assuming TOTAL_ROWS = 23)
                        ld ($DD90+NOFS), a              ;  0,  16 (all origins top left, X first)
                        ld ($DDC5+NOFS), a              ; 31,  16
                        ld ($FAB6+NOFS), a              ;  0, 198
                        ld ($FAEB+NOFS), a              ; 31, 198

                        ld a, Cyan
                        ld ($DDE2+NOFS), a


                        // ld ($DD73+NOFS), a           ;  0,  14 (You will crash NIRVANA+ if you try to write here, because it is out of range)
                        // ld ($FB3D+NOFS), a           ; 31, 200 (Also here)

                        ld a, 3                         ; Position sprite A at 3, 16 (top line 16 is first on-screen line)
                        ld (SPRITE_A_COL), a            ; Sprite is drawn every frame
                        ld a, 16                        ; until you change the position or index.
                        ld (SPRITE_A_LINE), a           ; Sprites are not erased, do this yourself. Calling NIRVANA_fillT
                        ld a, 0                         ; or NIRVANA_paintC is an easy way,
                        ld (SPRITE_A_IX), a             ; or change the sprite index to a blank tile for one frame.

                        ld a, 28                        ; Position sprite B at 28, 2 (2 is just on-screen. 0 is also allowed)
                        ld (SPRITE_B_COL), a
                        ld a, 2                         ; Deactivate sprites by setting both column and line to zero.
                        ld (SPRITE_B_LINE), a
                        ld a, 0
                        ld (SPRITE_B_IX), a

                        ld a, 3                         ; Position sprite C at 3, 184 (bottom line 198 is last on-screen line)
                        ld (SPRITE_C_COL), a
                        ld a, 184
                        ld (SPRITE_C_LINE), a
                        ld a, 0
                        ld (SPRITE_C_IX), a

                        ld a, 28                        ; Position sprite D at 28, 198 (198 is just on-screen. 200 is also allowed)
                        ld (SPRITE_D_COL), a
                        ld a, 198
                        ld (SPRITE_D_LINE), a
                        ld a, 0
                        ld (SPRITE_D_IX), a
                                                        ; Paint a simple 8x2 character
                        xor a                           ; using CharID of 0,
                        ld bc, ATTR_TABLE+(0*4)         ; AttrID of 0,
                        ld d, 108
                        ld e, 16
                        call NIRVANA_printC

                        ld a, 14                        ; Do a simple 2-frame 16x16 sprite animation
                        ld (SPRITE_E_COL), a
                        ld a, 100
                        ld (SPRITE_E_LINE), a

Animate:                ld a, (FRAMES)
                        and %00001000                   ; Change animation frame every 8/50ths sec
                        rra
                        rra
                        rra
                        inc a                           ; Choose tile index 1 or 2
                        ld (SPRITE_E_IX), a

                        dec a                           ; Do simple animation on eyes
                        ld a, DarkMagentaCyanP
                        jp nz, Eyes
                        xor %00100000                   ; Flip green bit of paper colour
Eyes:                   ld ($ECEA+NOFS), a              ; Set 8x2 attribute for 16, 108

                        halt
                        jp Animate

CHAR_TABLE:
                                                ; CharID
    db $18, $3C, $7E, $93, $DB, $FF, $24, $66   ;     00

ATTR_TABLE:
                            ; AttrID
    db $03, $43, $2B, $42   ;     00

