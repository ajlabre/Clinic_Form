using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicConsultationLogic;

namespace Clinic_Window_Form
{
    public partial class CONSULTATIONFORM : Form
    {
        public CONSULTATIONFORM()
        {
            InitializeComponent();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            WELCOMEFORMMENU WelcomeFrm = new WELCOMEFORMMENU();
            WelcomeFrm.Show();
            Hide();
        }

        private void btnCONFIRM_Click(object sender, EventArgs e)
        {

            ClinicManage.AddUser(txtboxFullName.Text, txtboxAddress.Text,
                txtboxBirthdate.Text, txtboxGender.Text, txtboxEmailAdd.Text,
                txtboxMobileNum.Text, txtboxMedHistory.Text);

            txtboxFullName.Text = "";
            txtboxAddress.Text = "";
            txtboxBirthdate.Text = "";
            txtboxGender.Text = "";
            txtboxEmailAdd.Text = "";
            txtboxMobileNum.Text = "";
            txtboxMedHistory.Text = "";

            MessageBox.Show("Client Registered Successfully",
            "Client Registration", MessageBoxButtons.OK);

        }
        private void CONSULTATIONFORM_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lblAddress.Visible = false;
            lblBirthdate.Visible = false;
            lblEmailAdd.Visible = false;
            lblGender.Visible = false;
            lblMobileNum.Visible = false;
            lblMedicalHistory.Visible = false;

            txtboxAddress.Visible = false;
            txtboxBirthdate.Visible = false;
            txtboxEmailAdd.Visible = false;
            txtboxGender.Visible = false;
            txtboxMobileNum.Visible = false;
            txtboxMedHistory.Visible = false;

            lblFullName.Visible = true;
            txtboxFullName.Visible = true;
            btnCONFIRM.Visible = true;
            btnCancel.Visible = true;
            btnCheckClient.Visible = true;

        }

        private void btnCheckClient_Click(object sender, EventArgs e)
        {
            var result = ClinicManage.ViewClient(txtboxFullName.Text);

            if (result)
            {
                MessageBox.Show("Client scheduled.",
                "Client Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Client is not scheduled yet. Fill out the form to proceed.",
                "Client Check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
