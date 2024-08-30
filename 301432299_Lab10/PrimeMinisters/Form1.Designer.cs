namespace PrimeMinisters
{
    partial class frmPrimeMinisters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimeMinisters));
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.lblParty = new System.Windows.Forms.Label();
            this.lstPrimeMinisters = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // picPhoto
            // 
            this.picPhoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picPhoto.Location = new System.Drawing.Point(97, 56);
            this.picPhoto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(432, 460);
            this.picPhoto.TabIndex = 0;
            this.picPhoto.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(91, 601);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(243, 31);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "President\'s Name";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerm.Location = new System.Drawing.Point(93, 690);
            this.lblTerm.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(60, 24);
            this.lblTerm.TabIndex = 3;
            this.lblTerm.Text = "Term:";
            // 
            // lblParty
            // 
            this.lblParty.AutoSize = true;
            this.lblParty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParty.Location = new System.Drawing.Point(93, 766);
            this.lblParty.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblParty.Name = "lblParty";
            this.lblParty.Size = new System.Drawing.Size(56, 24);
            this.lblParty.TabIndex = 4;
            this.lblParty.Text = "Party:";
            // 
            // lstPrimeMinisters
            // 
            this.lstPrimeMinisters.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lstPrimeMinisters.FormattingEnabled = true;
            this.lstPrimeMinisters.ItemHeight = 24;
            this.lstPrimeMinisters.Location = new System.Drawing.Point(618, 56);
            this.lstPrimeMinisters.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstPrimeMinisters.Name = "lstPrimeMinisters";
            this.lstPrimeMinisters.Size = new System.Drawing.Size(432, 460);
            this.lstPrimeMinisters.TabIndex = 1;
            this.lstPrimeMinisters.SelectedValueChanged += new System.EventHandler(this.lstPrimeMinisters_SelectedValueChanged);
            // 
            // frmPrimeMinisters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 938);
            this.Controls.Add(this.lstPrimeMinisters);
            this.Controls.Add(this.lblParty);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picPhoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmPrimeMinisters";
            this.Text = "Prime Ministers";
            this.Load += new System.EventHandler(this.frmPrimeMinisters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Label lblParty;
        private System.Windows.Forms.ListBox lstPrimeMinisters;
    }
}

