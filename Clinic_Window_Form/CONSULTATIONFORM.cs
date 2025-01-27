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
            string fullname = txtboxFullName.Text;
            string houseno = txtboxHouseNo.Text;
            string street = txtboxStreet.Text;
            string villagesubd = txtboxVillageSubd.Text;
            string brgy = txtboxBrgy.Text;
            string cityprovince = txtboxCityProvince.Text;
            string gender = txtboxGender.Text;
            string emailadd = txtboxEmailAdd.Text;
            string birthdate = txtboxBirthdate.Text;
            string mobilenum = txtboxMobileNum.Text;
            string medicalhistory = txtboxMedHistory.Text;

            if (fullname == ConsultationRegister.fullname && houseno == ConsultationRegister.houseno && street == ConsultationRegister.street
                && villagesubd == ConsultationRegister.villagesubd && brgy == ConsultationRegister.brgy && cityprovince == ConsultationRegister.cityprovince
                && gender == ConsultationRegister.Gender && emailadd == ConsultationRegister.emailadd && birthdate == ConsultationRegister.birthdate
                && mobilenum == ConsultationRegister.mobilenum && medicalhistory == ConsultationRegister.medicalhistory)
            {
                MessageBox.Show("Client succesfully registered.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                VIEWFORM viewForm = new VIEWFORM();
                viewForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Fill out all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CONSULTATIONFORM_Load(object sender, EventArgs e)
        {
            
        }
    }
}
