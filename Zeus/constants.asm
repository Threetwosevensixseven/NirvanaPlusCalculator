; Constants.asm

zoLogicOperatorsHighPri = false
zoSupportStringEscapes  = false
Zeus_PC                 = NStart
Zeus_SP                 = NStart - 2
Zeus_StimDataErase      = true

TOTAL_ROWS              equ 23                          ; 1..23
Red                     equ $52
White                   equ $7F
Cyan                    equ $6D
DarkMagentaBlueP        equ $0B
DarkMagentaCyanP        equ $2B
ATTRS_8x8               equ $5800
ATTRS_8x8_END           equ $5AFF
FRAMES                  equ 23672
NIRVANA_org             equ 56323                       ; Note the IM2 table will need manually moving if you relocate NIRVANA+
NIRVANA_relocate_offset equ 56323-NIRVANA_org
NIRVANA_end             equ NIRVANA_org+9054
NOFS                    equ NIRVANA_relocate_offset
SPRITE_A_LINE           equ 56470+0*8                   ; Line address    (sprite 0)
SPRITE_A_COL            equ SPRITE_A_LINE-1             ; Column address
SPRITE_A_IX             equ SPRITE_A_LINE+2             ; Index address
SPRITE_B_LINE           equ 56470+1*8                   ; Line address    (sprite 1)
SPRITE_B_COL            equ SPRITE_B_LINE-1             ; Column address
SPRITE_B_IX             equ SPRITE_B_LINE+2             ; Index address
SPRITE_C_LINE           equ 56470+2*8                   ; Line address    (sprite 2)
SPRITE_C_COL            equ SPRITE_C_LINE-1             ; Column address
SPRITE_C_IX             equ SPRITE_C_LINE+2             ; Index address
SPRITE_D_LINE           equ 56470+3*8                   ; Line address    (sprite 3)
SPRITE_D_COL            equ SPRITE_D_LINE-1             ; Column address
SPRITE_D_IX             equ SPRITE_D_LINE+2             ; Index address
SPRITE_E_LINE           equ 56470+4*8                   ; Line address    (sprite 4)
SPRITE_E_COL            equ SPRITE_E_LINE-1             ; Column address
SPRITE_E_IX             equ SPRITE_E_LINE+2             ; Index address
SPRITE_F_LINE           equ 56470+5*8                   ; Line address    (sprite 5)
SPRITE_F_COL            equ SPRITE_F_LINE-1             ; Column address
SPRITE_F_IX             equ SPRITE_F_LINE+2             ; Index address
SPRITE_G_LINE           equ 56470+6*8                   ; Line address    (sprite 6)
SPRITE_G_COL            equ SPRITE_G_LINE-1             ; Column address
SPRITE_G_IX             equ SPRITE_G_LINE+2             ; Index address
SPRITE_H_LINE           equ 56470+7*8                   ; Line address    (sprite 7)
SPRITE_H_COL            equ SPRITE_H_LINE-1             ; Column address
SPRITE_H_IX             equ SPRITE_H_LINE+2             ; Index address

