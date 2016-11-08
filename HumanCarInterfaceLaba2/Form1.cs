using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HumanCarInterfaceLaba2        //Код на Visual C# 6.0 
{  
    public partial class frmReversed : Form 
    {
        private double A;           //Число A
        private double B;           //Число B
        private double divider;     //Знаменатель дроби
        string outA;                //Строка вывода числа A в текстовое поле.
        string outB;                //Строка вывода числа B в текстовое поле.

        //Using common constructor
        public frmReversed()
        {
            InitializeComponent();      
            A =  this.numA.Val; outA = A.ToString();
            B =  this.numB.Val; outB = B.ToString();
            divider =  A*A + B*B;

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
            int underlCnt = lblInput.Text.Count() - "Исходное число: ".Count(); //Approximate count of underlines of the fractional line 

            divider = A * A + B * B; 
            lblOutput.Text = $"{outA}+{outB}*i\n{generateUndrlns(underlCnt)}\n{divider}";

            toolStripFirstLabel.Text = "Выполнена попытка обратить число.";
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {
            
        }

        //Generate underlines for the fractional line
        private string generateUndrlns(int count)
        {
            string s = "";
            for (int i = 0; i < count; i++)
            {
                s += " -";
            }
            return s;
        }

        private void Simplify()
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
            Simplify();
            btnReverse_Click(this.btnReverse, new EventArgs());
            toolStripFirstLabel.Text = "Выполнена попытка упростить дробь.";
        }

        private void SetInputLabelText(string text)
        {
            lblInput.Text = "Исходное число: " + text;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThreadStart tS = new ThreadStart(delegate { Application.Run(new frmAbout()); });
            Thread t = new Thread(tS);
            t.Start();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThreadStart tS = new ThreadStart(delegate { Application.Run(new frmHelp()); });
            Thread t = new Thread(tS);
            t.Start();
        }
    }
}
