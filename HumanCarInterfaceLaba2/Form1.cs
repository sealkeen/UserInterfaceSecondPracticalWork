using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanCarInterfaceLaba2
{
    public partial class frmReversed : Form
    {
        private double A;
        private double B;
        private double divider; //Код на Visual C# 6.0 
        string outA;
        string outB;
        public frmReversed()
        {
            InitializeComponent(); //Авто-генерированнный код
            A =  this.numA.Val; outA = A.ToString();
            B =  this.numB.Val; outB = B.ToString();
            divider =  A*A + B*B;
            numA_ValueChanged(this.numA, new EventArgs());
            SetInputLabelText($"{outA}+{outB}*i");
        }

        private void numA_ValueChanged(object sender, EventArgs e)
        {
            this.A =  numA.Val;
            outA = A.ToString();
            SetInputLabelText($"{outA}+{outB}*i");

            try
            {
                (sender as IntNumeric).DecimalPlaces = IntNumeric.GetPrecision(A);
            }
            catch (ArgumentOutOfRangeException) { (sender as IntNumeric).DecimalPlaces = 99; }
        }

        private void numB_ValueChanged(object sender, EventArgs e)
        {
            this.B =  numB.Val;
            outB = (B < 0) ? $"({B})": B.ToString();
            SetInputLabelText($"{outA}+{outB}*i");
            try
            {
                (sender as IntNumeric).DecimalPlaces = IntNumeric.GetPrecision(B);
            }
            catch (ArgumentOutOfRangeException) { (sender as IntNumeric).DecimalPlaces = 99; }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            int underlCnt = lblInput.Text.Count();
            divider = A * A + B * B; 
            lblOutput.Text = $"{outA}+{outB}*i\n{generateUndrlns(underlCnt)}\n{divider}";
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {
            
        }
        private string generateUndrlns(int count)
        {
            string s = "";
            for (int i = 0; i < count; i++)
            {
                s += " -";
            }
            return s;
        }
        private void simplify()
        {
            double A = this.A; double B = this.B; double divider = this.divider;
            double[] digits = { 2, 3, 5, 7 };
            foreach (double digit in digits)
            {
                if (A % digit == 0 && B % digit == 0 && divider % digit == 0)
                {
                    while (A % digit == 0 && B % digit == 0 && divider % digit == 0)
                    {
                        A /= digit;B /= digit; divider /= digit;
                    }
                }
                else
                    continue;
            }
            this.A = A; this.B = B; this.divider = divider;
            numA.Val = A; numB.Val = B;
            outA = A.ToString();
            outB = (B < 0) ? $"({B})" : B.ToString();
        }

        private void btnSmplf_Click(object sender, EventArgs e)
        {
            simplify();
            btnReverse_Click(this.btnReverse, new EventArgs());
        }
        private void SetInputLabelText(string text)
        {
            lblInput.Text = "Исходное число: " + text;
        }
    }
}
