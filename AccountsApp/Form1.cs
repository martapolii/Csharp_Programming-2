using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsApp
{
    public partial class FrmAccounts : Form
    {
        public FrmAccounts()
        {
            InitializeComponent();
        }

        // 3.2  private field called accounts of type List<Account>
        List<Account> accounts = new List<Account>();

        private void rbtnChecking_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnChecking.Checked)
            {
                txtInterestRate.Text = "";
                // 3.3 if checking selected
                lblDailyWithdrawLimit.Enabled = true; // daily withdrawl limit enabled
                txtDailyWithdrawLimit.Enabled = true;

                lblInterestRate.Enabled = false; // interest rate disabled
                txtInterestRate.Enabled = false;
            }
            else // 3.4 if savings selecetd
            {
                txtDailyWithdrawLimit.Text = "";

                lblDailyWithdrawLimit.Enabled = false; // daily withdrawl limit disabled
                txtDailyWithdrawLimit.Enabled = false;

                lblInterestRate.Enabled = true; // interest rate enabled
                txtInterestRate.Enabled = true;
            }
        }

        // when user clicks on create account:
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            //3.5 A new account will be created, and the information filled in the GUI will be used to set the account properties

            //decalre a generic account, then check if it is a checking or savings account
            Account newAccount;

            try {
                //3.6 Use a try..catch block to handle any invalid input
                double account, balance, withdraw, interest;

                //account = Convert.ToInt32(txtAccountNumber.Text);
                if (!double.TryParse(txtAccountNumber.Text, out account))
                {
                    MessageBox.Show("Please enter a valid Account Number.");
                    return;
                }
                //balance = Convert.ToDouble(txtBalance.Text);
                if (!double.TryParse(txtBalance.Text, out balance))
                {
                    MessageBox.Show("Please enter a valid Balance.");
                    return;
                }

                if (txtClientName.Text == " ")
                {
                    MessageBox.Show("Please enter an Account Name.");
                }
                

                if (rbtnChecking.Checked == true)
                {
                    //withdraw = Convert.ToDouble(txtDailyWithdrawLimit.Text);
                    if (!double.TryParse(txtDailyWithdrawLimit.Text, out withdraw))
                    {
                        MessageBox.Show("Please enter a valid Withdraw limit.");
                        return;
                    }

                    // create a new checking account
                    newAccount = new CheckingAccount(
                            Convert.ToInt32(txtAccountNumber.Text),
                            txtClientName.Text,
                            Convert.ToDouble(txtBalance.Text),
                            Convert.ToDouble(txtDailyWithdrawLimit.Text)
                            );
                }
                else
                {
                    //interest = Convert.ToDouble(txtInterestRate.Text);
                    if (!double.TryParse(txtInterestRate.Text, out interest))
                    {
                        MessageBox.Show("Please enter a valid Interest Rate.");
                        return;
                    }

                    // creating a new savings account
                    newAccount = new SavingsAccount(
                            Convert.ToInt32(txtAccountNumber.Text),
                            txtClientName.Text,
                            Convert.ToDouble(txtBalance.Text),
                            Convert.ToDouble(txtInterestRate.Text)
                            );
                }
               

                // 3.7 Add the new account to the account list
                accounts.Add(newAccount);

                //3.8 Clear all textboxes and set the selected type of account to “Checking”
                ClearFields();
                rbtnChecking.Checked = true;


                //3.9 Use MessageBox.Show() to show the total number of accounts stored so far in the accounts List
                MessageBox.Show($"The number of accounts stored is: {accounts.Count}.");

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid inputs in the numerical text fields.");
            }
            catch (Exception ex) // generic exception
            {
                MessageBox.Show("Please check your input");
            }
        }

        // reusable code for clearing all fields
        public void ClearFields()
        {
            txtAccountNumber.Text = "";
            txtClientName.Text = "";
            txtBalance.Text = "";
            txtDailyWithdrawLimit.Text = "";
            txtInterestRate.Text = "";
        }

        // BONUS
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ClearFields();
                Account myAccount = null;

                foreach (Account account in accounts)
                {
                    if (account.Number == Convert.ToInt32(txtSearch.Text))
                        myAccount = account;

                }
                txtAccountNumber.Text = Convert.ToString(myAccount.Number);
                txtClientName.Text = myAccount.Name;
                txtBalance.Text = Convert.ToString(myAccount.Balance);


                if (myAccount is CheckingAccount)
                {
                    txtDailyWithdrawLimit.Text = ((myAccount as CheckingAccount).Limit).ToString();

                    rbtnChecking.Checked = true;
                    rbtnSavings.Checked = false;
                }
                else
                if (myAccount is SavingsAccount)
                {
                    txtInterestRate.Text = ((myAccount as SavingsAccount).Interest).ToString();

                    rbtnChecking.Checked = false;
                    rbtnSavings.Checked = true;
                }
            }
            catch (Exception ex)
            {
                ClearFields();
                MessageBox.Show("Account not Found!");
            }
            

        }
    }
}
