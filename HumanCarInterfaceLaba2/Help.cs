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
    public partial class frmHelp : Form
    {
        string fMessage =
        "Значения в числовых полях задаются в интервале: \n" +
        "{ -49999999999.0; 49999999999.0} \n" +
        "Кнопка \"Перевернуть\" позволяет получить обратное комплексное число.\n" +
        "Кнопка \"Упростить\" пытается упростить полученную дробь.\n";

        public frmHelp()
        {
            InitializeComponent();
        }

        public frmHelp(string message)
        {
            if (message != null) fMessage = message;
            label1.Text = fMessage;
        }
    }
}
