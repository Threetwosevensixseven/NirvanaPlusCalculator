namespace NirvanaPlusCalculator
{
  partial class frmMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
      this.lblColumn = new System.Windows.Forms.Label();
      this.numColumn = new System.Windows.Forms.NumericUpDown();
      this.numChar = new System.Windows.Forms.NumericUpDown();
      this.lblChar = new System.Windows.Forms.Label();
      this.numSpectrumLine = new System.Windows.Forms.NumericUpDown();
      this.lblSpectrumLine = new System.Windows.Forms.Label();
      this.numNirvanaLine = new System.Windows.Forms.NumericUpDown();
      this.lblNirvanaLine = new System.Windows.Forms.Label();
      this.numBaseAddressHex = new System.Windows.Forms.NumericUpDown();
      this.lblBaseAddress = new System.Windows.Forms.Label();
      this.lblAttributeAddress = new System.Windows.Forms.Label();
      this.numAttributeAddressHex = new System.Windows.Forms.NumericUpDown();
      this.numAttributeAddressDec = new System.Windows.Forms.NumericUpDown();
      this.numBaseAddressDec = new System.Windows.Forms.NumericUpDown();
      this.numTotalRows = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.btnTL = new System.Windows.Forms.Button();
      this.btnT = new System.Windows.Forms.Button();
      this.btnTR = new System.Windows.Forms.Button();
      this.btnR = new System.Windows.Forms.Button();
      this.btnL = new System.Windows.Forms.Button();
      this.btnBR = new System.Windows.Forms.Button();
      this.btnB = new System.Windows.Forms.Button();
      this.btnBL = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.numColumn)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numChar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSpectrumLine)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numNirvanaLine)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numBaseAddressHex)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numAttributeAddressHex)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numAttributeAddressDec)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numBaseAddressDec)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numTotalRows)).BeginInit();
      this.SuspendLayout();
      // 
      // lblColumn
      // 
      this.lblColumn.AutoSize = true;
      this.lblColumn.Location = new System.Drawing.Point(12, 9);
      this.lblColumn.Name = "lblColumn";
      this.lblColumn.Size = new System.Drawing.Size(81, 13);
      this.lblColumn.TabIndex = 0;
      this.lblColumn.Text = "Column (0-255):";
      // 
      // numColumn
      // 
      this.numColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.numColumn.Location = new System.Drawing.Point(190, 7);
      this.numColumn.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.numColumn.Name = "numColumn";
      this.numColumn.Size = new System.Drawing.Size(224, 20);
      this.numColumn.TabIndex = 1;
      this.numColumn.ValueChanged += new System.EventHandler(this.Recalculate);
      this.numColumn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Recalculate);
      // 
      // numChar
      // 
      this.numChar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.numChar.Location = new System.Drawing.Point(190, 33);
      this.numChar.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
      this.numChar.Name = "numChar";
      this.numChar.Size = new System.Drawing.Size(224, 20);
      this.numChar.TabIndex = 3;
      this.numChar.ValueChanged += new System.EventHandler(this.Recalculate);
      this.numChar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Recalculate);
      // 
      // lblChar
      // 
      this.lblChar.AutoSize = true;
      this.lblChar.Location = new System.Drawing.Point(12, 35);
      this.lblChar.Name = "lblChar";
      this.lblChar.Size = new System.Drawing.Size(62, 13);
      this.lblChar.TabIndex = 2;
      this.lblChar.Text = "Char (0-31):";
      // 
      // numSpectrumLine
      // 
      this.numSpectrumLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.numSpectrumLine.Location = new System.Drawing.Point(190, 59);
      this.numSpectrumLine.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.numSpectrumLine.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            -2147483648});
      this.numSpectrumLine.Name = "numSpectrumLine";
      this.numSpectrumLine.Size = new System.Drawing.Size(224, 20);
      this.numSpectrumLine.TabIndex = 5;
      this.numSpectrumLine.ValueChanged += new System.EventHandler(this.Recalculate);
      this.numSpectrumLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Recalculate);
      // 
      // lblSpectrumLine
      // 
      this.lblSpectrumLine.AutoSize = true;
      this.lblSpectrumLine.Location = new System.Drawing.Point(12, 61);
      this.lblSpectrumLine.Name = "lblSpectrumLine";
      this.lblSpectrumLine.Size = new System.Drawing.Size(114, 13);
      this.lblSpectrumLine.TabIndex = 4;
      this.lblSpectrumLine.Text = "Spectrum Line (0-191):";
      // 
      // numNirvanaLine
      // 
      this.numNirvanaLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.numNirvanaLine.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.numNirvanaLine.Location = new System.Drawing.Point(190, 85);
      this.numNirvanaLine.Maximum = new decimal(new int[] {
            199,
            0,
            0,
            0});
      this.numNirvanaLine.Name = "numNirvanaLine";
      this.numNirvanaLine.Size = new System.Drawing.Size(224, 20);
      this.numNirvanaLine.TabIndex = 7;
      this.numNirvanaLine.ValueChanged += new System.EventHandler(this.Recalculate);
      this.numNirvanaLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Recalculate);
      // 
      // lblNirvanaLine
      // 
      this.lblNirvanaLine.AutoSize = true;
      this.lblNirvanaLine.Location = new System.Drawing.Point(12, 87);
      this.lblNirvanaLine.Name = "lblNirvanaLine";
      this.lblNirvanaLine.Size = new System.Drawing.Size(129, 13);
      this.lblNirvanaLine.TabIndex = 6;
      this.lblNirvanaLine.Text = "NIRVANA+ Line (16-199):";
      // 
      // numBaseAddressHex
      // 
      this.numBaseAddressHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.numBaseAddressHex.Hexadecimal = true;
      this.numBaseAddressHex.Location = new System.Drawing.Point(190, 155);
      this.numBaseAddressHex.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
      this.numBaseAddressHex.Name = "numBaseAddressHex";
      this.numBaseAddressHex.Size = new System.Drawing.Size(71, 20);
      this.numBaseAddressHex.TabIndex = 10;
      this.numBaseAddressHex.ValueChanged += new System.EventHandler(this.Recalculate);
      this.numBaseAddressHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Recalculate);
      // 
      // lblBaseAddress
      // 
      this.lblBaseAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblBaseAddress.AutoSize = true;
      this.lblBaseAddress.Location = new System.Drawing.Point(12, 157);
      this.lblBaseAddress.Name = "lblBaseAddress";
      this.lblBaseAddress.Size = new System.Drawing.Size(132, 13);
      this.lblBaseAddress.TabIndex = 9;
      this.lblBaseAddress.Text = "NIRVANA+ Base Address:";
      // 
      // lblAttributeAddress
      // 
      this.lblAttributeAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblAttributeAddress.AutoSize = true;
      this.lblAttributeAddress.Location = new System.Drawing.Point(12, 186);
      this.lblAttributeAddress.Name = "lblAttributeAddress";
      this.lblAttributeAddress.Size = new System.Drawing.Size(147, 13);
      this.lblAttributeAddress.TabIndex = 12;
      this.lblAttributeAddress.Text = "NIRVANA+ Attribute Address:";
      // 
      // numAttributeAddressHex
      // 
      this.numAttributeAddressHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.numAttributeAddressHex.Hexadecimal = true;
      this.numAttributeAddressHex.Location = new System.Drawing.Point(190, 183);
      this.numAttributeAddressHex.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
      this.numAttributeAddressHex.Name = "numAttributeAddressHex";
      this.numAttributeAddressHex.ReadOnly = true;
      this.numAttributeAddressHex.Size = new System.Drawing.Size(71, 20);
      this.numAttributeAddressHex.TabIndex = 13;
      this.numAttributeAddressHex.ValueChanged += new System.EventHandler(this.Recalculate);
      this.numAttributeAddressHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Recalculate);
      // 
      // numAttributeAddressDec
      // 
      this.numAttributeAddressDec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.numAttributeAddressDec.Location = new System.Drawing.Point(267, 183);
      this.numAttributeAddressDec.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
      this.numAttributeAddressDec.Name = "numAttributeAddressDec";
      this.numAttributeAddressDec.ReadOnly = true;
      this.numAttributeAddressDec.Size = new System.Drawing.Size(71, 20);
      this.numAttributeAddressDec.TabIndex = 14;
      this.numAttributeAddressDec.ValueChanged += new System.EventHandler(this.Recalculate);
      this.numAttributeAddressDec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Recalculate);
      // 
      // numBaseAddressDec
      // 
      this.numBaseAddressDec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.numBaseAddressDec.Location = new System.Drawing.Point(267, 155);
      this.numBaseAddressDec.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
      this.numBaseAddressDec.Name = "numBaseAddressDec";
      this.numBaseAddressDec.Size = new System.Drawing.Size(71, 20);
      this.numBaseAddressDec.TabIndex = 11;
      this.numBaseAddressDec.ValueChanged += new System.EventHandler(this.Recalculate);
      this.numBaseAddressDec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Recalculate);
      // 
      // numTotalRows
      // 
      this.numTotalRows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.numTotalRows.Location = new System.Drawing.Point(190, 111);
      this.numTotalRows.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
      this.numTotalRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numTotalRows.Name = "numTotalRows";
      this.numTotalRows.Size = new System.Drawing.Size(224, 20);
      this.numTotalRows.TabIndex = 16;
      this.numTotalRows.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 113);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(172, 13);
      this.label1.TabIndex = 15;
      this.label1.Text = "NIRVANA+ TOTAL_ROWS (1-23):";
      // 
      // btnTL
      // 
      this.btnTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTL.Image = ((System.Drawing.Image)(resources.GetObject("btnTL.Image")));
      this.btnTL.Location = new System.Drawing.Point(350, 139);
      this.btnTL.Margin = new System.Windows.Forms.Padding(1);
      this.btnTL.Name = "btnTL";
      this.btnTL.Size = new System.Drawing.Size(20, 20);
      this.btnTL.TabIndex = 17;
      this.btnTL.Text = "╔";
      this.btnTL.UseVisualStyleBackColor = true;
      this.btnTL.Click += new System.EventHandler(this.btnTL_Click);
      // 
      // btnT
      // 
      this.btnT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnT.Image = ((System.Drawing.Image)(resources.GetObject("btnT.Image")));
      this.btnT.Location = new System.Drawing.Point(372, 139);
      this.btnT.Margin = new System.Windows.Forms.Padding(1);
      this.btnT.Name = "btnT";
      this.btnT.Size = new System.Drawing.Size(20, 20);
      this.btnT.TabIndex = 18;
      this.btnT.Text = "╔";
      this.btnT.UseVisualStyleBackColor = true;
      this.btnT.Click += new System.EventHandler(this.btnT_Click);
      // 
      // btnTR
      // 
      this.btnTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTR.Image = ((System.Drawing.Image)(resources.GetObject("btnTR.Image")));
      this.btnTR.Location = new System.Drawing.Point(394, 139);
      this.btnTR.Margin = new System.Windows.Forms.Padding(1);
      this.btnTR.Name = "btnTR";
      this.btnTR.Size = new System.Drawing.Size(20, 20);
      this.btnTR.TabIndex = 19;
      this.btnTR.Text = "╔";
      this.btnTR.UseVisualStyleBackColor = true;
      this.btnTR.Click += new System.EventHandler(this.btnTR_Click);
      // 
      // btnR
      // 
      this.btnR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnR.Image = ((System.Drawing.Image)(resources.GetObject("btnR.Image")));
      this.btnR.Location = new System.Drawing.Point(394, 161);
      this.btnR.Margin = new System.Windows.Forms.Padding(1);
      this.btnR.Name = "btnR";
      this.btnR.Size = new System.Drawing.Size(20, 20);
      this.btnR.TabIndex = 22;
      this.btnR.Text = "╔";
      this.btnR.UseVisualStyleBackColor = true;
      this.btnR.Click += new System.EventHandler(this.btnR_Click);
      // 
      // btnL
      // 
      this.btnL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnL.Image = ((System.Drawing.Image)(resources.GetObject("btnL.Image")));
      this.btnL.Location = new System.Drawing.Point(350, 161);
      this.btnL.Margin = new System.Windows.Forms.Padding(1);
      this.btnL.Name = "btnL";
      this.btnL.Size = new System.Drawing.Size(20, 20);
      this.btnL.TabIndex = 20;
      this.btnL.Text = "╔";
      this.btnL.UseVisualStyleBackColor = true;
      this.btnL.Click += new System.EventHandler(this.btnL_Click);
      // 
      // btnBR
      // 
      this.btnBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnBR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBR.Image = ((System.Drawing.Image)(resources.GetObject("btnBR.Image")));
      this.btnBR.Location = new System.Drawing.Point(394, 183);
      this.btnBR.Margin = new System.Windows.Forms.Padding(1);
      this.btnBR.Name = "btnBR";
      this.btnBR.Size = new System.Drawing.Size(20, 20);
      this.btnBR.TabIndex = 25;
      this.btnBR.Text = "╔";
      this.btnBR.UseVisualStyleBackColor = true;
      this.btnBR.Click += new System.EventHandler(this.btnBR_Click);
      // 
      // btnB
      // 
      this.btnB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnB.Image = ((System.Drawing.Image)(resources.GetObject("btnB.Image")));
      this.btnB.Location = new System.Drawing.Point(372, 183);
      this.btnB.Margin = new System.Windows.Forms.Padding(1);
      this.btnB.Name = "btnB";
      this.btnB.Size = new System.Drawing.Size(20, 20);
      this.btnB.TabIndex = 24;
      this.btnB.Text = "╔";
      this.btnB.UseVisualStyleBackColor = true;
      this.btnB.Click += new System.EventHandler(this.btnB_Click);
      // 
      // btnBL
      // 
      this.btnBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBL.Image = ((System.Drawing.Image)(resources.GetObject("btnBL.Image")));
      this.btnBL.Location = new System.Drawing.Point(350, 183);
      this.btnBL.Margin = new System.Windows.Forms.Padding(1);
      this.btnBL.Name = "btnBL";
      this.btnBL.Size = new System.Drawing.Size(20, 20);
      this.btnBL.TabIndex = 23;
      this.btnBL.Text = "╔";
      this.btnBL.UseVisualStyleBackColor = true;
      this.btnBL.Click += new System.EventHandler(this.btnBL_Click);
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(426, 214);
      this.Controls.Add(this.btnBR);
      this.Controls.Add(this.btnB);
      this.Controls.Add(this.btnBL);
      this.Controls.Add(this.btnR);
      this.Controls.Add(this.btnL);
      this.Controls.Add(this.btnTR);
      this.Controls.Add(this.btnT);
      this.Controls.Add(this.btnTL);
      this.Controls.Add(this.numTotalRows);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.numBaseAddressDec);
      this.Controls.Add(this.numAttributeAddressDec);
      this.Controls.Add(this.numAttributeAddressHex);
      this.Controls.Add(this.lblAttributeAddress);
      this.Controls.Add(this.numBaseAddressHex);
      this.Controls.Add(this.lblBaseAddress);
      this.Controls.Add(this.numNirvanaLine);
      this.Controls.Add(this.lblNirvanaLine);
      this.Controls.Add(this.numSpectrumLine);
      this.Controls.Add(this.lblSpectrumLine);
      this.Controls.Add(this.numChar);
      this.Controls.Add(this.lblChar);
      this.Controls.Add(this.numColumn);
      this.Controls.Add(this.lblColumn);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "frmMain";
      this.Text = "NIRVANA+ Attribute Calculator";
      this.TopMost = true;
      ((System.ComponentModel.ISupportInitialize)(this.numColumn)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numChar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSpectrumLine)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numNirvanaLine)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numBaseAddressHex)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numAttributeAddressHex)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numAttributeAddressDec)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numBaseAddressDec)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numTotalRows)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblColumn;
    private System.Windows.Forms.NumericUpDown numColumn;
    private System.Windows.Forms.NumericUpDown numChar;
    private System.Windows.Forms.Label lblChar;
    private System.Windows.Forms.NumericUpDown numSpectrumLine;
    private System.Windows.Forms.Label lblSpectrumLine;
    private System.Windows.Forms.NumericUpDown numNirvanaLine;
    private System.Windows.Forms.NumericUpDown numBaseAddressHex;
    private System.Windows.Forms.Label lblBaseAddress;
    private System.Windows.Forms.Label lblAttributeAddress;
    protected System.Windows.Forms.Label lblNirvanaLine;
    private System.Windows.Forms.NumericUpDown numAttributeAddressHex;
    private System.Windows.Forms.NumericUpDown numAttributeAddressDec;
    private System.Windows.Forms.NumericUpDown numBaseAddressDec;
    private System.Windows.Forms.NumericUpDown numTotalRows;
    protected System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnTL;
    private System.Windows.Forms.Button btnT;
    private System.Windows.Forms.Button btnTR;
    private System.Windows.Forms.Button btnR;
    private System.Windows.Forms.Button btnL;
    private System.Windows.Forms.Button btnBR;
    private System.Windows.Forms.Button btnB;
    private System.Windows.Forms.Button btnBL;
  }
}

