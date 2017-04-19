using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NirvanaPlusCalculator
{
  public partial class frmMain : Form
  {
    private bool Recalculating;
    public const int NirvanaBaseAddress = 56695;
    public readonly int[] Deltas = new int[] {
      25, 26, 32, 33, 38, 39, 58, 59, 9, 10, 12, 13, 15, 16, 2, 3,
      19, 20, 22, 23, 44, 45, 6, 7, 65, 66, 68, 69, 71, 72, 77, 78 };

    public frmMain()
    {
      InitializeComponent();
      numTotalRows.Value = 23;
      numBaseAddressHex.Value = NirvanaBaseAddress;
      numBaseAddressDec.Value = NirvanaBaseAddress;
      numColumn.Value = 0;
      numSpectrumLine.Value = 0;
    }

    public void Recalculate(object sender, EventArgs e)
    {
      // Prevent event recursion
      if (Recalculating) return;
      Recalculating = true;

      // Read controls
      int x = 0;
      if (sender == numColumn) x = Convert.ToInt32(numColumn.Value);
      else x = Convert.ToInt32(numChar.Value * 8);
      if (x < 0) x = 0;
      if (x > 255) x = 191;
      int col = x / 8;
      int y = 0;
      if (sender == numSpectrumLine) y = Convert.ToInt32(numSpectrumLine.Value);
      else y = Convert.ToInt32(numNirvanaLine.Value - 16);
      if (y < -8) y = -8;
      if (y > 191) y = 191;
      double tempLine = ((y + 16) / 2);
      int nLine = Convert.ToInt32(Math.Round(tempLine, 0) * 2) - 8;
      int baseAddress = 0;
      if (sender == numBaseAddressHex) baseAddress = Convert.ToInt32(numBaseAddressHex.Value);
      else baseAddress = Convert.ToInt32(numBaseAddressDec.Value);
      int totalRows = Convert.ToInt32(numTotalRows.Value);
      if (totalRows < 1) totalRows = 1;
      if (totalRows > 23) totalRows = 23;

      // Calculate
      int columnOffset = Deltas[col];
      int rowOffset = ((nLine - 16) / 2) * 82;
      int nirvanaRow = nLine / 8;
      int nirvanaAttributeAddress = baseAddress + rowOffset + columnOffset;

      // Overflows
      bool sLineOverflow = (y < 0) || (y > 255);
      bool nLineOverflow = (nLine < 0) || (nLine > 199);
      bool rowOverflow = (nirvanaRow < 0) || (nirvanaRow > totalRows + 1); 
      bool addressOverflow = (rowOverflow) || (nirvanaAttributeAddress > 65535) || (nirvanaAttributeAddress < 0);

      // Write controls and calculations
      numColumn.Value = x;

      numChar.Value = col;

      numSpectrumLine.Value = y;
      numSpectrumLine.BackColor = sLineOverflow ? Color.Red : numColumn.BackColor;
      numSpectrumLine.ForeColor = sLineOverflow ? Color.White : numColumn.ForeColor;

      numNirvanaLine.Value = nLineOverflow ? 0 : nLine;
      numNirvanaLine.BackColor = nLineOverflow ? Color.Red : numColumn.BackColor;
      numNirvanaLine.ForeColor = nLineOverflow ? Color.White : numColumn.ForeColor;

      numTotalRows.Value = totalRows;
      numTotalRows.BackColor = rowOverflow ? Color.Red : numColumn.BackColor;
      numTotalRows.ForeColor = rowOverflow ? Color.White : numColumn.ForeColor;

      numAttributeAddressDec.Value = totalRows;

      numBaseAddressHex.Value = baseAddress;

      numBaseAddressDec.Value = baseAddress;

      numAttributeAddressHex.Value = addressOverflow ? 0 : nirvanaAttributeAddress;
      numAttributeAddressHex.BackColor = addressOverflow ? Color.Red : numColumn.BackColor;
      numAttributeAddressHex.ForeColor = addressOverflow ? Color.White : numColumn.ForeColor;

      numAttributeAddressDec.Value = addressOverflow ? 0 : nirvanaAttributeAddress;
      numAttributeAddressDec.BackColor = addressOverflow ? Color.Red : numColumn.BackColor;
      numAttributeAddressDec.ForeColor = addressOverflow ? Color.White : numColumn.ForeColor;

      Recalculating = false;
    }

    #region Private

    private void Recalculate(object sender, KeyPressEventArgs e)
    {
      Recalculate(sender, e as EventArgs);
    }

    private bool IsEven(decimal Value)
    {
      decimal val = Math.Round(Value, 0);
      decimal half = Math.Round(val / 2, 0);
      return val == half * 2;
    }

    private void btnTL_Click(object sender, EventArgs e)
    {
      numColumn.Value = 0;
      numSpectrumLine.Value = 8;
    }

    private void btnT_Click(object sender, EventArgs e)
    {
      numSpectrumLine.Value = 8;
    }

    private void btnTR_Click(object sender, EventArgs e)
    {
      numColumn.Value = 255;
      numSpectrumLine.Value = 8;
    }

    private void btnL_Click(object sender, EventArgs e)
    {
      numColumn.Value = 0;
    }

    private void btnR_Click(object sender, EventArgs e)
    {
      numColumn.Value = 255;
    }

    private void btnBL_Click(object sender, EventArgs e)
    {
      numColumn.Value = 0;
      numSpectrumLine.Value = 191;
    }

    private void btnB_Click(object sender, EventArgs e)
    {
      numSpectrumLine.Value = 191;
    }

    private void btnBR_Click(object sender, EventArgs e)
    {
      numColumn.Value = 255;
      numSpectrumLine.Value = 191;
    }

    #endregion
  }
}
