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
    public partial class CONSULTATIONFORM : Form
    {
        public List<string> ConsultationInfo { get; private set; }
        public CONSULTATIONFORM()
        {
            InitializeComponent();

            ConsultationInfo = new List<string>();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            WELCOMEFORMMENU WelcomeFrm = new WELCOMEFORMMENU();
            WelcomeFrm.Show();
            Hide();
        }

        private void btnCONFIRM_Click(object sender, EventArgs e)
        {
            ConsultationInfo.Add(txtboxFullName.Text);
            ConsultationInfo.Add(txtboxHouseNo.Text);
            ConsultationInfo.Add(txtboxVillageSubd.Text);
            ConsultationInfo.Add(txtboxStreet.Text);
            ConsultationInfo.Add(txtboxBrgy.Text);
            ConsultationInfo.Add(DatePickerBirthdate.Text);
            ConsultationInfo.Add(cmbGender.Text);
            ConsultationInfo.Add(txtboxEmailAdd.Text);
            ConsultationInfo.Add(txtboxMobileNum.Text);
            ConsultationInfo.Add(cmbMedHistory.Text);
            ConsultationInfo.Add(txtboxOthersMedHistory.Text);

            MessageBox.Show("Client succesfully registered.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ADMINCLIENTMENU AdminClient = new ADMINCLIENTMENU();
            AdminClient.Show();
            Hide();
        }

        private void CONSULTATIONFORM_Load(object sender, EventArgs e)
        {
            
        }
    }
}
