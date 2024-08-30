namespace Wk13__VehicleApp__Review_
{
    partial class frmVehicles
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
            this.grpVehicle = new System.Windows.Forms.GroupBox();
            this.grpTypeOfVehicle = new System.Windows.Forms.GroupBox();
            this.rbtnBicycle = new System.Windows.Forms.RadioButton();
            this.rbtnCar = new System.Windows.Forms.RadioButton();
            this.grpBikes = new System.Windows.Forms.GroupBox();
            this.cboTerrain = new System.Windows.Forms.ComboBox();
            this.lblTerrain = new System.Windows.Forms.Label();
            this.lblTireSize = new System.Windows.Forms.Label();
            this.nrudTireSize = new System.Windows.Forms.NumericUpDown();
            this.grpCars = new System.Windows.Forms.GroupBox();
            this.cboFuel = new System.Windows.Forms.ComboBox();
            this.lblFuel = new System.Windows.Forms.Label();
            this.lblPassengers = new System.Windows.Forms.Label();
            this.nrudPassengers = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtWarranty = new System.Windows.Forms.TextBox();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblWarranty = new System.Windows.Forms.Label();
            this.lblStore = new System.Windows.Forms.Label();
            this.btnCreateVehicle = new System.Windows.Forms.Button();
            this.grpVehicle.SuspendLayout();
            this.grpTypeOfVehicle.SuspendLayout();
            this.grpBikes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudTireSize)).BeginInit();
            this.grpCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudPassengers)).BeginInit();
            this.SuspendLayout();
            // 
            // grpVehicle
            // 
            this.grpVehicle.Controls.Add(this.grpTypeOfVehicle);
            this.grpVehicle.Controls.Add(this.grpBikes);
            this.grpVehicle.Controls.Add(this.grpCars);
            this.grpVehicle.Controls.Add(this.txtName);
            this.grpVehicle.Controls.Add(this.txtBrand);
            this.grpVehicle.Controls.Add(this.txtPrice);
            this.grpVehicle.Controls.Add(this.txtWarranty);
            this.grpVehicle.Controls.Add(this.txtStore);
            this.grpVehicle.Controls.Add(this.lblName);
            this.grpVehicle.Controls.Add(this.lblBrand);
            this.grpVehicle.Controls.Add(this.lblPrice);
            this.grpVehicle.Controls.Add(this.lblWarranty);
            this.grpVehicle.Controls.Add(this.lblStore);
            this.grpVehicle.Location = new System.Drawing.Point(12, 23);
            this.grpVehicle.Name = "grpVehicle";
            this.grpVehicle.Size = new System.Drawing.Size(1038, 530);
            this.grpVehicle.TabIndex = 0;
            this.grpVehicle.TabStop = false;
            this.grpVehicle.Text = "Vehicle Information";
            // 
            // grpTypeOfVehicle
            // 
            this.grpTypeOfVehicle.Controls.Add(this.rbtnBicycle);
            this.grpTypeOfVehicle.Controls.Add(this.rbtnCar);
            this.grpTypeOfVehicle.Location = new System.Drawing.Point(690, 96);
            this.grpTypeOfVehicle.Name = "grpTypeOfVehicle";
            this.grpTypeOfVehicle.Size = new System.Drawing.Size(294, 149);
            this.grpTypeOfVehicle.TabIndex = 0;
            this.grpTypeOfVehicle.TabStop = false;
            this.grpTypeOfVehicle.Text = "Type of Vehicle";
            // 
            // rbtnBicycle
            // 
            this.rbtnBicycle.AutoSize = true;
            this.rbtnBicycle.Location = new System.Drawing.Point(61, 93);
            this.rbtnBicycle.Name = "rbtnBicycle";
            this.rbtnBicycle.Size = new System.Drawing.Size(93, 28);
            this.rbtnBicycle.TabIndex = 14;
            this.rbtnBicycle.Text = "Bicycle ";
            this.rbtnBicycle.UseVisualStyleBackColor = true;
            // 
            // rbtnCar
            // 
            this.rbtnCar.AutoSize = true;
            this.rbtnCar.Checked = true;
            this.rbtnCar.Location = new System.Drawing.Point(61, 43);
            this.rbtnCar.Name = "rbtnCar";
            this.rbtnCar.Size = new System.Drawing.Size(57, 28);
            this.rbtnCar.TabIndex = 15;
            this.rbtnCar.TabStop = true;
            this.rbtnCar.Text = "Car";
            this.rbtnCar.UseVisualStyleBackColor = true;
            this.rbtnCar.CheckedChanged += new System.EventHandler(this.rbtnCar_CheckedChanged);
            // 
            // grpBikes
            // 
            this.grpBikes.Controls.Add(this.cboTerrain);
            this.grpBikes.Controls.Add(this.lblTerrain);
            this.grpBikes.Controls.Add(this.lblTireSize);
            this.grpBikes.Controls.Add(this.nrudTireSize);
            this.grpBikes.Enabled = false;
            this.grpBikes.Location = new System.Drawing.Point(301, 285);
            this.grpBikes.Name = "grpBikes";
            this.grpBikes.Size = new System.Drawing.Size(316, 166);
            this.grpBikes.TabIndex = 0;
            this.grpBikes.TabStop = false;
            this.grpBikes.Text = "For Bikes";
            // 
            // cboTerrain
            // 
            this.cboTerrain.FormattingEnabled = true;
            this.cboTerrain.Items.AddRange(new object[] {
            "Paved",
            "Unpaved"});
            this.cboTerrain.Location = new System.Drawing.Point(169, 101);
            this.cboTerrain.Name = "cboTerrain";
            this.cboTerrain.Size = new System.Drawing.Size(121, 32);
            this.cboTerrain.TabIndex = 16;
            // 
            // lblTerrain
            // 
            this.lblTerrain.AutoSize = true;
            this.lblTerrain.Location = new System.Drawing.Point(30, 104);
            this.lblTerrain.Name = "lblTerrain";
            this.lblTerrain.Size = new System.Drawing.Size(75, 24);
            this.lblTerrain.TabIndex = 15;
            this.lblTerrain.Text = "Terrain:";
            // 
            // lblTireSize
            // 
            this.lblTireSize.AutoSize = true;
            this.lblTireSize.Location = new System.Drawing.Point(30, 42);
            this.lblTireSize.Name = "lblTireSize";
            this.lblTireSize.Size = new System.Drawing.Size(89, 24);
            this.lblTireSize.TabIndex = 13;
            this.lblTireSize.Text = "Tire Size:";
            // 
            // nrudTireSize
            // 
            this.nrudTireSize.Location = new System.Drawing.Point(169, 40);
            this.nrudTireSize.Name = "nrudTireSize";
            this.nrudTireSize.Size = new System.Drawing.Size(120, 29);
            this.nrudTireSize.TabIndex = 12;
            // 
            // grpCars
            // 
            this.grpCars.Controls.Add(this.cboFuel);
            this.grpCars.Controls.Add(this.lblFuel);
            this.grpCars.Controls.Add(this.lblPassengers);
            this.grpCars.Controls.Add(this.nrudPassengers);
            this.grpCars.Location = new System.Drawing.Point(301, 91);
            this.grpCars.Name = "grpCars";
            this.grpCars.Size = new System.Drawing.Size(316, 154);
            this.grpCars.TabIndex = 11;
            this.grpCars.TabStop = false;
            this.grpCars.Text = "For Cars";
            // 
            // cboFuel
            // 
            this.cboFuel.FormattingEnabled = true;
            this.cboFuel.Items.AddRange(new object[] {
            "Gas",
            "Diesel",
            "Electric",
            " Hybrid"});
            this.cboFuel.Location = new System.Drawing.Point(169, 88);
            this.cboFuel.Name = "cboFuel";
            this.cboFuel.Size = new System.Drawing.Size(121, 32);
            this.cboFuel.TabIndex = 17;
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(30, 96);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(53, 24);
            this.lblFuel.TabIndex = 14;
            this.lblFuel.Text = "Fuel:";
            // 
            // lblPassengers
            // 
            this.lblPassengers.AutoSize = true;
            this.lblPassengers.Location = new System.Drawing.Point(30, 48);
            this.lblPassengers.Name = "lblPassengers";
            this.lblPassengers.Size = new System.Drawing.Size(114, 24);
            this.lblPassengers.TabIndex = 14;
            this.lblPassengers.Text = "Passengers:";
            // 
            // nrudPassengers
            // 
            this.nrudPassengers.Location = new System.Drawing.Point(169, 46);
            this.nrudPassengers.Name = "nrudPassengers";
            this.nrudPassengers.Size = new System.Drawing.Size(120, 29);
            this.nrudPassengers.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 29);
            this.txtName.TabIndex = 10;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(129, 171);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(118, 29);
            this.txtBrand.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(129, 254);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(118, 29);
            this.txtPrice.TabIndex = 8;
            // 
            // txtWarranty
            // 
            this.txtWarranty.Location = new System.Drawing.Point(129, 337);
            this.txtWarranty.Name = "txtWarranty";
            this.txtWarranty.Size = new System.Drawing.Size(118, 29);
            this.txtWarranty.TabIndex = 7;
            // 
            // txtStore
            // 
            this.txtStore.Location = new System.Drawing.Point(129, 420);
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(118, 29);
            this.txtStore.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 24);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(37, 175);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(65, 24);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "Brand:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(37, 259);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 24);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price:";
            // 
            // lblWarranty
            // 
            this.lblWarranty.AutoSize = true;
            this.lblWarranty.Location = new System.Drawing.Point(37, 343);
            this.lblWarranty.Name = "lblWarranty";
            this.lblWarranty.Size = new System.Drawing.Size(89, 24);
            this.lblWarranty.TabIndex = 4;
            this.lblWarranty.Text = "Warranty:";
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Location = new System.Drawing.Point(37, 427);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(59, 24);
            this.lblStore.TabIndex = 5;
            this.lblStore.Text = "Store:";
            // 
            // btnCreateVehicle
            // 
            this.btnCreateVehicle.Location = new System.Drawing.Point(862, 582);
            this.btnCreateVehicle.Name = "btnCreateVehicle";
            this.btnCreateVehicle.Size = new System.Drawing.Size(188, 70);
            this.btnCreateVehicle.TabIndex = 16;
            this.btnCreateVehicle.Text = "Create Vehicle";
            this.btnCreateVehicle.UseVisualStyleBackColor = true;
            this.btnCreateVehicle.Click += new System.EventHandler(this.btnCreateVehicle_Click);
            // 
            // frmVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 683);
            this.Controls.Add(this.btnCreateVehicle);
            this.Controls.Add(this.grpVehicle);
            this.Name = "frmVehicles";
            this.Text = "Vehicles";
            this.grpVehicle.ResumeLayout(false);
            this.grpVehicle.PerformLayout();
            this.grpTypeOfVehicle.ResumeLayout(false);
            this.grpTypeOfVehicle.PerformLayout();
            this.grpBikes.ResumeLayout(false);
            this.grpBikes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudTireSize)).EndInit();
            this.grpCars.ResumeLayout(false);
            this.grpCars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrudPassengers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVehicle;
        private System.Windows.Forms.GroupBox grpTypeOfVehicle;
        private System.Windows.Forms.RadioButton rbtnBicycle;
        private System.Windows.Forms.RadioButton rbtnCar;
        private System.Windows.Forms.GroupBox grpBikes;
        private System.Windows.Forms.Label lblTireSize;
        private System.Windows.Forms.NumericUpDown nrudTireSize;
        private System.Windows.Forms.GroupBox grpCars;
        private System.Windows.Forms.Label lblPassengers;
        private System.Windows.Forms.NumericUpDown nrudPassengers;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtWarranty;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblWarranty;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Button btnCreateVehicle;
        private System.Windows.Forms.Label lblTerrain;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.ComboBox cboTerrain;
        private System.Windows.Forms.ComboBox cboFuel;
    }
}

