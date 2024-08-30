namespace Wk10__Calculator
{
    partial class frmIntroCalculator
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
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpOperations = new System.Windows.Forms.GroupBox();
            this.rbtnDivide = new System.Windows.Forms.RadioButton();
            this.rbtnMultiply = new System.Windows.Forms.RadioButton();
            this.rbtnSubtract = new System.Windows.Forms.RadioButton();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.lblEqual = new System.Windows.Forms.Label();
            this.btnPerformOperation = new System.Windows.Forms.Button();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.grpOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(60, 95);
            this.lblFirst.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(63, 31);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.Location = new System.Drawing.Point(392, 95);
            this.lblSecond.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(101, 31);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Text = "Second";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(714, 95);
            this.lblResult.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(86, 31);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result";
            // 
            // grpOperations
            // 
            this.grpOperations.Controls.Add(this.rbtnDivide);
            this.grpOperations.Controls.Add(this.rbtnMultiply);
            this.grpOperations.Controls.Add(this.rbtnSubtract);
            this.grpOperations.Controls.Add(this.rbtnAdd);
            this.grpOperations.Location = new System.Drawing.Point(239, 15);
            this.grpOperations.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpOperations.Name = "grpOperations";
            this.grpOperations.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpOperations.Size = new System.Drawing.Size(141, 345);
            this.grpOperations.TabIndex = 8;
            this.grpOperations.TabStop = false;
            // 
            // rbtnDivide
            // 
            this.rbtnDivide.AutoSize = true;
            this.rbtnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDivide.Location = new System.Drawing.Point(42, 275);
            this.rbtnDivide.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtnDivide.Name = "rbtnDivide";
            this.rbtnDivide.Size = new System.Drawing.Size(40, 35);
            this.rbtnDivide.TabIndex = 11;
            this.rbtnDivide.TabStop = true;
            this.rbtnDivide.Text = "/";
            this.rbtnDivide.UseVisualStyleBackColor = true;
            // 
            // rbtnMultiply
            // 
            this.rbtnMultiply.AutoSize = true;
            this.rbtnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMultiply.Location = new System.Drawing.Point(44, 192);
            this.rbtnMultiply.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtnMultiply.Name = "rbtnMultiply";
            this.rbtnMultiply.Size = new System.Drawing.Size(43, 35);
            this.rbtnMultiply.TabIndex = 10;
            this.rbtnMultiply.TabStop = true;
            this.rbtnMultiply.Text = "*";
            this.rbtnMultiply.UseVisualStyleBackColor = true;
            this.rbtnMultiply.CheckedChanged += new System.EventHandler(this.rbtnMultiply_CheckedChanged);
            // 
            // rbtnSubtract
            // 
            this.rbtnSubtract.AutoSize = true;
            this.rbtnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSubtract.Location = new System.Drawing.Point(44, 107);
            this.rbtnSubtract.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtnSubtract.Name = "rbtnSubtract";
            this.rbtnSubtract.Size = new System.Drawing.Size(41, 35);
            this.rbtnSubtract.TabIndex = 9;
            this.rbtnSubtract.TabStop = true;
            this.rbtnSubtract.Text = "-";
            this.rbtnSubtract.UseVisualStyleBackColor = true;
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAdd.Location = new System.Drawing.Point(42, 33);
            this.rbtnAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(48, 35);
            this.rbtnAdd.TabIndex = 8;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "+";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqual.Location = new System.Drawing.Point(620, 146);
            this.lblEqual.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(30, 31);
            this.lblEqual.TabIndex = 12;
            this.lblEqual.Text = "=";
            // 
            // btnPerformOperation
            // 
            this.btnPerformOperation.BackColor = System.Drawing.Color.LightGray;
            this.btnPerformOperation.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerformOperation.Location = new System.Drawing.Point(372, 407);
            this.btnPerformOperation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPerformOperation.Name = "btnPerformOperation";
            this.btnPerformOperation.Size = new System.Drawing.Size(278, 82);
            this.btnPerformOperation.TabIndex = 13;
            this.btnPerformOperation.Text = "Perform Operation";
            this.btnPerformOperation.UseVisualStyleBackColor = false;
            this.btnPerformOperation.Click += new System.EventHandler(this.btnPerformOperation_Click);
            // 
            // txtFirst
            // 
            this.txtFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirst.Location = new System.Drawing.Point(38, 151);
            this.txtFirst.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(180, 29);
            this.txtFirst.TabIndex = 14;
            // 
            // txtSecond
            // 
            this.txtSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecond.Location = new System.Drawing.Point(380, 151);
            this.txtSecond.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(180, 29);
            this.txtSecond.TabIndex = 15;
            // 
            // txtResult
            // 
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResult.Location = new System.Drawing.Point(738, 151);
            this.txtResult.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(180, 29);
            this.txtResult.TabIndex = 16;
            // 
            // frmIntroCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(929, 529);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.btnPerformOperation);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.grpOperations);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmIntroCalculator";
            this.Text = "Martas Calculator";
            this.grpOperations.ResumeLayout(false);
            this.grpOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox grpOperations;
        private System.Windows.Forms.RadioButton rbtnDivide;
        private System.Windows.Forms.RadioButton rbtnMultiply;
        private System.Windows.Forms.RadioButton rbtnSubtract;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.Button btnPerformOperation;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtResult;
    }
}

