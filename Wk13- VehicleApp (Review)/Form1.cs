using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wk13__VehicleApp__Review_
{
    public partial class frmVehicles : Form
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
        public frmVehicles()
        {
            InitializeComponent();
        }

        private void btnCreateVehicle_Click(object sender, EventArgs e)
        {
            //decalre a generic vehicle, then check if it's a bike or car 
            Vehicle newVehicle;
            try
            {

                if (rbtnCar.Checked == true)
                {
                    //create a car
                    newVehicle = new Bicycle(txtName.Text,
                        txtBrand.Text,
                        Convert.ToDouble(txtPrice.Text),
                        Convert.ToInt32(txtWarranty.Text),
                        txtStore.Text,
                        Convert.ToInt32(nrudTireSize.Value),
                        cboTerrain.Text
                        );

                }
                else
                {
                    // create a bicycle
                    newVehicle = new Car(txtName.Text,
                       txtBrand.Text,
                       Convert.ToDouble(txtPrice.Text),
                       Convert.ToInt32(txtWarranty.Text),
                       txtStore.Text,
                       Convert.ToInt32(nrudPassengers.Value),
                       cboFuel.Text
                       );
                }

                // add the vehicle to the list of vehicles
                vehicles.Add(newVehicle);

                //once new vehicle added, clear all inputs
                txtName.Text = "";
                txtBrand.Text = "";
                txtPrice.Text = "";
                txtWarranty.Text = "";
                txtStore.Text = "";

                cboFuel.Text = "";
                nrudPassengers.Value = 0;

                nrudTireSize.Value = 0;
                cboTerrain.Text = "";

                rbtnCar.Checked = true;

                // message to show the total number of vehicles
                MessageBox.Show($"Total Number of Vehicles: {vehicles.Count}.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check your input");
            }
            
        }

        private void rbtnCar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCar.Checked)
            {
                grpCars.Enabled = true;
                grpBikes.Enabled = false;
            }
            else
            {
                grpCars.Enabled = false;
                grpBikes.Enabled = true;
            }
        }
    }
}
