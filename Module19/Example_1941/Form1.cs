using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_1941
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;

                if (!Double.TryParse(txtBoxA.Text, out a)) throw new FormatException("ошибка в a");
                if (!Double.TryParse(txtBoxB.Text, out b)) throw new FormatException("ошибка в b");

                lblResValue.Text = $"{a + b}";
            }
            catch (Exception)
            {

            }
    
        }
    }
}
