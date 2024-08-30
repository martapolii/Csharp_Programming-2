namespace AccountsApp
{
    partial class FrmAccounts
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
            this.grpAccountDetails = new System.Windows.Forms.GroupBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtDailyWithdrawLimit = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.grpTypeOfAccount = new System.Windows.Forms.GroupBox();
            this.rbtnSavings = new System.Windows.Forms.RadioButton();
            this.rbtnChecking = new System.Windows.Forms.RadioButton();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblDailyWithdrawLimit = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpAccountDetails.SuspendLayout();
            this.grpTypeOfAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccountDetails
            // 
            this.grpAccountDetails.Controls.Add(this.txtInterestRate);
            this.grpAccountDetails.Controls.Add(this.txtDailyWithdrawLimit);
            this.grpAccountDetails.Controls.Add(this.txtBalance);
            this.grpAccountDetails.Controls.Add(this.txtClientName);
            this.grpAccountDetails.Controls.Add(this.txtAccountNumber);
            this.grpAccountDetails.Controls.Add(this.grpTypeOfAccount);
            this.grpAccountDetails.Controls.Add(this.lblAccountNumber);
            this.grpAccountDetails.Controls.Add(this.lblInterestRate);
            this.grpAccountDetails.Controls.Add(this.lblClientName);
            this.grpAccountDetails.Controls.Add(this.lblDailyWithdrawLimit);
            this.grpAccountDetails.Controls.Add(this.lblBalance);
            this.grpAccountDetails.Location = new System.Drawing.Point(31, 57);
            this.grpAccountDetails.Name = "grpAccountDetails";
            this.grpAccountDetails.Size = new System.Drawing.Size(714, 337);
            this.grpAccountDetails.TabIndex = 0;
            this.grpAccountDetails.TabStop = false;
            this.grpAccountDetails.Text = "Account Details";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Enabled = false;
            this.txtInterestRate.Location = new System.Drawing.Point(155, 281);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(140, 20);
            this.txtInterestRate.TabIndex = 9;
            // 
            // txtDailyWithdrawLimit
            // 
            this.txtDailyWithdrawLimit.Location = new System.Drawing.Point(155, 223);
            this.txtDailyWithdrawLimit.Name = "txtDailyWithdrawLimit";
            this.txtDailyWithdrawLimit.Size = new System.Drawing.Size(140, 20);
            this.txtDailyWithdrawLimit.TabIndex = 8;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(155, 165);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(140, 20);
            this.txtBalance.TabIndex = 7;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(155, 107);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(257, 20);
            this.txtClientName.TabIndex = 6;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(155, 49);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(140, 20);
            this.txtAccountNumber.TabIndex = 5;
            // 
            // grpTypeOfAccount
            // 
            this.grpTypeOfAccount.Controls.Add(this.rbtnSavings);
            this.grpTypeOfAccount.Controls.Add(this.rbtnChecking);
            this.grpTypeOfAccount.Location = new System.Drawing.Point(515, 50);
            this.grpTypeOfAccount.Name = "grpTypeOfAccount";
            this.grpTypeOfAccount.Size = new System.Drawing.Size(159, 126);
            this.grpTypeOfAccount.TabIndex = 0;
            this.grpTypeOfAccount.TabStop = false;
            this.grpTypeOfAccount.Text = "Type of Account";
            // 
            // rbtnSavings
            // 
            this.rbtnSavings.AutoSize = true;
            this.rbtnSavings.Location = new System.Drawing.Point(28, 71);
            this.rbtnSavings.Name = "rbtnSavings";
            this.rbtnSavings.Size = new System.Drawing.Size(63, 17);
            this.rbtnSavings.TabIndex = 1;
            this.rbtnSavings.Text = "Savings";
            this.rbtnSavings.UseVisualStyleBackColor = true;
            // 
            // rbtnChecking
            // 
            this.rbtnChecking.AutoSize = true;
            this.rbtnChecking.Checked = true;
            this.rbtnChecking.Location = new System.Drawing.Point(28, 31);
            this.rbtnChecking.Name = "rbtnChecking";
            this.rbtnChecking.Size = new System.Drawing.Size(70, 17);
            this.rbtnChecking.TabIndex = 0;
            this.rbtnChecking.TabStop = true;
            this.rbtnChecking.Text = "Checking";
            this.rbtnChecking.UseVisualStyleBackColor = true;
            this.rbtnChecking.CheckedChanged += new System.EventHandler(this.rbtnChecking_CheckedChanged);
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(38, 56);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(87, 13);
            this.lblAccountNumber.TabIndex = 0;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(38, 284);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(68, 13);
            this.lblInterestRate.TabIndex = 4;
            this.lblInterestRate.Text = "Interest Rate";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(38, 113);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(64, 13);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Client Name";
            // 
            // lblDailyWithdrawLimit
            // 
            this.lblDailyWithdrawLimit.AutoSize = true;
            this.lblDailyWithdrawLimit.Location = new System.Drawing.Point(38, 227);
            this.lblDailyWithdrawLimit.Name = "lblDailyWithdrawLimit";
            this.lblDailyWithdrawLimit.Size = new System.Drawing.Size(102, 13);
            this.lblDailyWithdrawLimit.TabIndex = 3;
            this.lblDailyWithdrawLimit.Text = "Daily Withdraw Limit";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(38, 170);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(46, 13);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(574, 413);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(171, 61);
            this.btnCreateAccount.TabIndex = 1;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(480, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(527, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(130, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(670, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 486);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.grpAccountDetails);
            this.Name = "FrmAccounts";
            this.Text = "Accounts";
            this.grpAccountDetails.ResumeLayout(false);
            this.grpAccountDetails.PerformLayout();
            this.grpTypeOfAccount.ResumeLayout(false);
            this.grpTypeOfAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccountDetails;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtDailyWithdrawLimit;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.GroupBox grpTypeOfAccount;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblDailyWithdrawLimit;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.RadioButton rbtnSavings;
        private System.Windows.Forms.RadioButton rbtnChecking;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}

