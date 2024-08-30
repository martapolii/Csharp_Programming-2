using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionCalculator
{
    public partial class frmFractionCalculator : Form
    {
        public frmFractionCalculator()
        {
            InitializeComponent();
        }

        private void btnPerformOperation_Click(object sender, EventArgs e)
        {
            //IPO method

            //inputs:
            int firstA = 0;
            int firstB = 0;
            int secondA = 0;
            int secondB = 0;
            int resultA;
            int resultB;

            //processing
            try
            {
                firstA = Convert.ToInt32(txtFirst.Text);
                firstB = Convert.ToInt32(txtFirstb.Text);

                secondA = Convert.ToInt32(txtSecond.Text);
                secondB = Convert.ToInt32(txtSecondb.Text);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please provide numerical inputs in all text fields.");
            }

            if (rbtnAdd.Checked == true)
            {
                // creating fraction objects using user input
                Fraction firstFraction = new Fraction(firstA, firstB);
                Fraction secondFraction = new Fraction(secondA, secondB);

                Fraction result = Fraction.Add(firstFraction, secondFraction);
                resultA = result.Numerator;
                resultB = result.Denominator;
            }
            else if (rbtnSubtract.Checked == true)
            {
                // creating fraction objects using user input
                Fraction firstFraction = new Fraction(firstA, firstB);
                Fraction secondFraction = new Fraction(secondA, secondB);

                Fraction result = Fraction.Subtract(firstFraction, secondFraction);
                resultA = result.Numerator;
                resultB = result.Denominator;
            }
            else if (rbtnMultiply.Checked == true)
            {
                // creating fraction objects using user input
                Fraction firstFraction = new Fraction(firstA, firstB);
                Fraction secondFraction = new Fraction(secondA, secondB);

                Fraction result = Fraction.Multiply(firstFraction, secondFraction);
                resultA = result.Numerator;
                resultB = result.Denominator;
            }
            else // division
            {
                // creating fraction objects using user input
                Fraction firstFraction = new Fraction(firstA, firstB);
                Fraction secondFraction = new Fraction(secondA, secondB);

                Fraction result = Fraction.Divide(firstFraction, secondFraction);
                resultA = result.Numerator;
                resultB = result.Denominator;
            }

            txtResult.Text = resultA.ToString(); //numerator
            txtResultb.Text = resultB.ToString(); //denominator
        }

        // Discarding non-digit entries for all input text boxes:
        private void txtFirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else e.Handled = true;
        }

        private void txtFirstb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else e.Handled = true;
        }

        private void txtSecond_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else e.Handled = true;
        }

        private void txtSecondb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else e.Handled = true;
        }

        // added a clear button so it was easier to test my calculator repeatedly, without having to exit and re-run the program
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirst.Text = " ";
            txtFirstb.Text = " ";
            txtSecond.Text = " ";
            txtSecondb.Text = " ";
            txtResult.Text = " ";
            txtResultb.Text = " ";
        }
    }
}
