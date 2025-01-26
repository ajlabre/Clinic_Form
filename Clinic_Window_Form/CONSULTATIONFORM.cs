using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Clinic_Window_Form
{
    public partial class ConsultationForm : Form
    {
        public List<string> ConsultationInfo { get; private set; }
        public ConsultationForm()
        {
            InitializeComponent();
            ConsultationInfo = new List<string>();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCONFIRMFORM_Click(object sender, EventArgs e)
        {
            ConsultationInfo.Add(txtboxFullName.Text);
            ConsultationInfo.Add(txtboxHouseNo.Text);
            ConsultationInfo.Add(txtboxVillageSubd.Text);
            ConsultationInfo.Add(txtboxStreet.Text);
            ConsultationInfo.Add(txtboxBrgy.Text);
            ConsultationInfo.Add(DatePickerBirthdate.Text);
            ConsultationInfo.Add(rdbtnFemale.Text);
            ConsultationInfo.Add(rdbtnMale.Text);
            ConsultationInfo.Add(txtboxEmailAdd.Text);
            ConsultationInfo.Add(txtboxMobileNum.Text);
            ConsultationInfo.Add(cmboxMedHistory.Text);
            ConsultationInfo.Add(txtboxOthersMedHistory.Text);

            MessageBox.Show("Client succesfully registered.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ADMINCLIENTMENU AdminClient = new ADMINCLIENTMENU();
            AdminClient.Show();
            Hide();
        }

        private static void Add(string text)
        {
            throw new NotImplementedException();
        }

        private void txtboxHouseNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxStreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxVillageSubd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxBrgy_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxCityProvince_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatePickerBirthdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtboxEmailAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxMobileNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmboxMedHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtboxOthersMedHistory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
