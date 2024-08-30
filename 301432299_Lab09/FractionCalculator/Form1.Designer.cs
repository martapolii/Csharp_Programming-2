namespace FractionCalculator
{
    partial class frmFractionCalculator
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
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.rbtnSubtract = new System.Windows.Forms.RadioButton();
            this.rbtnMultiply = new System.Windows.Forms.RadioButton();
            this.rbtnDivide = new System.Windows.Forms.RadioButton();
            this.btnPerformOperation = new System.Windows.Forms.Button();
            this.lblLine1 = new System.Windows.Forms.Label();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.lblLine3 = new System.Windows.Forms.Label();
            this.txtFirstb = new System.Windows.Forms.TextBox();
            this.txtSecondb = new System.Windows.Forms.TextBox();
            this.txtResultb = new System.Windows.Forms.TextBox();
            this.lblEquals = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(40, 74);
            this.lblFirst.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(54, 25);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.Location = new System.Drawing.Point(623, 74);
            this.lblSecond.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(85, 25);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Text = "Second";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(1012, 74);
            this.lblResult.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(73, 25);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(49, 142);
            this.txtFirst.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(86, 29);
            this.txtFirst.TabIndex = 1;
            this.txtFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirst_KeyPress);
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(648, 142);
            this.txtSecond.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(86, 29);
            this.txtSecond.TabIndex = 7;
            this.txtSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecond_KeyPress);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(1021, 142);
            this.txtResult.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(103, 29);
            this.txtResult.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnAdd);
            this.groupBox1.Controls.Add(this.rbtnSubtract);
            this.groupBox1.Controls.Add(this.rbtnMultiply);
            this.groupBox1.Controls.Add(this.rbtnDivide);
            this.groupBox1.Location = new System.Drawing.Point(311, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(255, 360);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAdd.Location = new System.Drawing.Point(50, 59);
            this.rbtnAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(42, 29);
            this.rbtnAdd.TabIndex = 3;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "+";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            // 
            // rbtnSubtract
            // 
            this.rbtnSubtract.AutoSize = true;
            this.rbtnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSubtract.Location = new System.Drawing.Point(50, 127);
            this.rbtnSubtract.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtnSubtract.Name = "rbtnSubtract";
            this.rbtnSubtract.Size = new System.Drawing.Size(37, 29);
            this.rbtnSubtract.TabIndex = 4;
            this.rbtnSubtract.TabStop = true;
            this.rbtnSubtract.Text = "-";
            this.rbtnSubtract.UseVisualStyleBackColor = true;
            // 
            // rbtnMultiply
            // 
            this.rbtnMultiply.AutoSize = true;
            this.rbtnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMultiply.Location = new System.Drawing.Point(50, 196);
            this.rbtnMultiply.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtnMultiply.Name = "rbtnMultiply";
            this.rbtnMultiply.Size = new System.Drawing.Size(38, 29);
            this.rbtnMultiply.TabIndex = 5;
            this.rbtnMultiply.TabStop = true;
            this.rbtnMultiply.Text = "*";
            this.rbtnMultiply.UseVisualStyleBackColor = true;
            // 
            // rbtnDivide
            // 
            this.rbtnDivide.AutoSize = true;
            this.rbtnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDivide.Location = new System.Drawing.Point(51, 257);
            this.rbtnDivide.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtnDivide.Name = "rbtnDivide";
            this.rbtnDivide.Size = new System.Drawing.Size(36, 29);
            this.rbtnDivide.TabIndex = 6;
            this.rbtnDivide.TabStop = true;
            this.rbtnDivide.Text = "/";
            this.rbtnDivide.UseVisualStyleBackColor = true;
            // 
            // btnPerformOperation
            // 
            this.btnPerformOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerformOperation.Location = new System.Drawing.Point(384, 487);
            this.btnPerformOperation.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnPerformOperation.Name = "btnPerformOperation";
            this.btnPerformOperation.Size = new System.Drawing.Size(466, 116);
            this.btnPerformOperation.TabIndex = 9;
            this.btnPerformOperation.Text = "Perform Operation";
            this.btnPerformOperation.UseVisualStyleBackColor = true;
            this.btnPerformOperation.Click += new System.EventHandler(this.btnPerformOperation_Click);
            // 
            // lblLine1
            // 
            this.lblLine1.AutoSize = true;
            this.lblLine1.Location = new System.Drawing.Point(38, 185);
            this.lblLine1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLine1.Name = "lblLine1";
            this.lblLine1.Size = new System.Drawing.Size(100, 24);
            this.lblLine1.TabIndex = 12;
            this.lblLine1.Text = "_________";
            // 
            // lblLine2
            // 
            this.lblLine2.AutoSize = true;
            this.lblLine2.Location = new System.Drawing.Point(643, 185);
            this.lblLine2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(100, 24);
            this.lblLine2.TabIndex = 13;
            this.lblLine2.Text = "_________";
            // 
            // lblLine3
            // 
            this.lblLine3.AutoSize = true;
            this.lblLine3.Location = new System.Drawing.Point(1015, 185);
            this.lblLine3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLine3.Name = "lblLine3";
            this.lblLine3.Size = new System.Drawing.Size(110, 24);
            this.lblLine3.TabIndex = 14;
            this.lblLine3.Text = "__________";
            // 
            // txtFirstb
            // 
            this.txtFirstb.Location = new System.Drawing.Point(49, 227);
            this.txtFirstb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFirstb.Name = "txtFirstb";
            this.txtFirstb.Size = new System.Drawing.Size(86, 29);
            this.txtFirstb.TabIndex = 2;
            this.txtFirstb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstb_KeyPress);
            // 
            // txtSecondb
            // 
            this.txtSecondb.Location = new System.Drawing.Point(648, 227);
            this.txtSecondb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSecondb.Name = "txtSecondb";
            this.txtSecondb.Size = new System.Drawing.Size(86, 29);
            this.txtSecondb.TabIndex = 8;
            this.txtSecondb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecondb_KeyPress);
            // 
            // txtResultb
            // 
            this.txtResultb.Location = new System.Drawing.Point(1021, 227);
            this.txtResultb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtResultb.Name = "txtResultb";
            this.txtResultb.ReadOnly = true;
            this.txtResultb.Size = new System.Drawing.Size(103, 29);
            this.txtResultb.TabIndex = 11;
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquals.Location = new System.Drawing.Point(878, 185);
            this.lblEquals.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(24, 25);
            this.lblEquals.TabIndex = 18;
            this.lblEquals.Text = "=";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(942, 487);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(204, 116);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmFractionCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 656);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.txtResultb);
            this.Controls.Add(this.txtSecondb);
            this.Controls.Add(this.txtFirstb);
            this.Controls.Add(this.lblLine3);
            this.Controls.Add(this.lblLine2);
            this.Controls.Add(this.lblLine1);
            this.Controls.Add(this.btnPerformOperation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmFractionCalculator";
            this.Text = "Martas Calulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.RadioButton rbtnSubtract;
        private System.Windows.Forms.RadioButton rbtnMultiply;
        private System.Windows.Forms.RadioButton rbtnDivide;
        private System.Windows.Forms.Button btnPerformOperation;
        private System.Windows.Forms.Label lblLine1;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.Label lblLine3;
        private System.Windows.Forms.TextBox txtFirstb;
        private System.Windows.Forms.TextBox txtSecondb;
        private System.Windows.Forms.TextBox txtResultb;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.Button btnClear;
    }
}

