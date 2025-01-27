using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Window_Form
{
    public partial class ADMINLOGIN : Form
    {
        public ADMINLOGIN()
        {
            InitializeComponent();
        }

        private void qstnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnCONFIRMADMIN_Click(object sender, EventArgs e)
        {
            string username = txtboxUsername.Text;
            string password = txtboxPin.Text;

            if (username == AdminRegister.Username && password == AdminRegister.Password)
            {
                MessageBox.Show("Admin confirmed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                VIEWFORM viewForm = new VIEWFORM(
                ConsultationRegister.Text,
                "Full Name",
                "Street",
                "Village/Subd",
                "Barangay",
                "City/Province",
                "Gender",
                "Email Address",
                "MM/DD/YYYY",
                "Mobile No.",
                "Medical History",
                "Others Medical History"
    );
                viewForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ADMINCLIENTMENU AdminClientMenu = new ADMINCLIENTMENU();
                AdminClientMenu.Show();
                Hide();
            }

        }

        private void txtboxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxPin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ADMINCLIENTMENU AdminClientMenu = new ADMINCLIENTMENU();
            AdminClientMenu.Show();
            Hide();
        }

        private void ADMINLOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
