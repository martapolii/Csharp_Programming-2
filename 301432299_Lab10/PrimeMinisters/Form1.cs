using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Step 5.1: add required namespaces for serialization:
using System.Web.Script.Serialization;
using System.IO;
// also added System.Web.Extensions as a reference to the project


namespace PrimeMinisters
{
    public partial class frmPrimeMinisters : Form
    {
        public frmPrimeMinisters()
        {
            InitializeComponent();
        }

        // Step 4: create a private field of type dictionary
        private Dictionary<string, PrimeMinister> primeMinisters = new Dictionary<string, PrimeMinister>();

        // Step 5: the list of Prime Ministers last names will be populated when the form loads: 
        private void frmPrimeMinisters_Load(object sender, EventArgs e)
        {
            //Step 5.1: Use JSON deserialization to deserialize the PrimeMinisters.json file
            string fileName = "PrimeMinisters.json"; //declare file name

            //Initialize the serializer object
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            //create an object to connect to the reader
            using (StreamReader streamReader = new StreamReader(fileName))
            
            //read each line + deserialize in one step:
            primeMinisters = serializer.Deserialize<Dictionary<string, PrimeMinister>>(streamReader.ReadToEnd());
            
            // Step 5.2: connect the list box to the list of Prime Minitser's last names:
            lstPrimeMinisters.DataSource = primeMinisters.Keys.ToList<string>();
        }

        // Step 6: Programming the event for which all the info on the GUI will change to the selected Prime Minister:
        private void lstPrimeMinisters_SelectedValueChanged(object sender, EventArgs e)
        {
            //a. find the correct Prime Minister selected inside the Dictionary based on the Key (last name)
            lstPrimeMinisters.SelectedValue.ToString();
            //b. find the Prime Minister inside the primeMinisters dictionary
           var selectedPM = primeMinisters[lstPrimeMinisters.SelectedValue.ToString()];
            //c. first and last name
            lblName.Text = $"{selectedPM.FirstName} {selectedPM.LastName}";
            //d. Term
            lblTerm.Text = $"Term:      {selectedPM.Term}";
            //e. Party
            lblParty.Text = $"Party:      {selectedPM.Party}";
            //f. Photo - set the file name of each photo 
            picPhoto.ImageLocation = $"{selectedPM.LastName}" + ".jpg"; 
           
        }
    }


}
