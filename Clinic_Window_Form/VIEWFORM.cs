using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Window_Form
{
    public partial class VIEWFORM : Form
    {
        public string V1 { get; }
        public string V2 { get; }
        public string V3 { get; }
        public string V4 { get; }
        public string V5 { get; }
        public string V6 { get; }
        public string V7 { get; }
        public string V8 { get; }
        public string V9 { get; }
        public string V10 { get; }

        public VIEWFORM(string fullname, string houseno, string street, string villagesubd,
            string brgy, string cityprovince, string gender, string emailadd, string birthdate,
            string mobilenum, string medicalhistory, string othersmedhistory)
        {
            
                InitializeComponent();

                txtboxFullName.HeaderText = fullname;
                txtboxHouseNo.HeaderText = houseno;
                txtboxStreet.HeaderText = street;
                txtboxVillageSubd.HeaderText = villagesubd;
                txtboxBrgy.HeaderText = brgy;
                txtboxCityProvince.HeaderText = cityprovince;
                txtboxGender.HeaderText = gender;
                txtboxEmailAdd.HeaderText = emailadd;
                txtboxMobileNum.HeaderText = mobilenum;
                txtboxMedHistory.HeaderText = medicalhistory;
        }
        public VIEWFORM()
        {

        }

        public VIEWFORM(string text, string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8, string v9, string v10)
        {
            Text = text;
            V1 = v1;
            V2 = v2;
            V3 = v3;
            V4 = v4;
            V5 = v5;
            V6 = v6;
            V7 = v7;
            V8 = v8;
            V9 = v9;
            V10 = v10;
        }

        private void VIEWFORM_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            ADMINCLIENTMENU AdminClient = new ADMINCLIENTMENU();
            AdminClient.Show();
            Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            
        }
    
    }
}
