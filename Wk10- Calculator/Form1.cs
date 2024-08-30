using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wk10__Calculator
{
    public partial class frmIntroCalculator : Form
    {
        public frmIntroCalculator()
        {
            InitializeComponent();
        }

        private void btnPerformOperation_Click(object sender, EventArgs e)
        {
            //IPO method

            //inputs:
            double first = 0;
            double second = 0;
            double result;

            //processing
            try
            {
                first = Convert.ToDouble(txtFirst.Text);
                second = Convert.ToDouble(txtSecond.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("put in some numbers dummy");
            }

            if (rbtnAdd.Checked == true)
            {
                result = first + second;
            }
            else if (rbtnSubtract.Checked == true)
            {
                result = first - second;
            }
            else if (rbtnMultiply.Checked == true)
            {
                result = first * second;
            }
            else
            {
                result = first / second;
            }

            txtResult.Text = result.ToString();
            
        }

        private void rbtnMultiply_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
