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
    public partial class REGISTERADMIN : Form
    {
        public REGISTERADMIN()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ADMINCLIENTMENU AdminClientMenu = new ADMINCLIENTMENU();
            AdminClientMenu.Show();
            Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            AdminRegister.Username = txtboxRegisterUser.Text;
            AdminRegister.Password = txtboxRegisterPin.Text;

            MessageBox.Show("Admin registered successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void REGISTERADMIN_Load(object sender, EventArgs e)
        {

        }
    }
}
