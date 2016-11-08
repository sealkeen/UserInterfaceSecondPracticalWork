using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace HumanCarInterfaceLaba2
{
    class IntNumeric : System.Windows.Forms.NumericUpDown
    {
        //new public double Value { get; set; }
        public double Val { get { return (double)base.Value; } set { base.Value = (decimal)value ; } }

        //Optional method
        public static int CompareDoubles(ref double sourceNumber, ref double valueNumber)
        {
            if (sourceNumber > valueNumber)
                return 1;
            else if (sourceNumber < valueNumber)
                return -1;
                        return 0;
        }

        //Returning precision of the passed variable
        public static int GetPrecision(double sourceVar)
        {
            int cnt = 0;
            double workingVar = sourceVar;
            while ((int)workingVar < workingVar && cnt < 99)
            {
                workingVar *= 10;
                ++cnt;
            }
            return cnt;
        }

    }

}
