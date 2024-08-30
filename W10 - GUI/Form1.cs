using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W10___GUI
{
    public partial class frmMyWindow : Form
    {
        public frmMyWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this is the code we want to run when we click the button
            // this is an event (looks like a method)
                // void 

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(txtMessage.Text);
            txtMessage.Text = ""; // cleans the textbox
            lblMessage.Text = "I can change!";
           // btnShowMessage.Visible = false;
        }
    }
}
