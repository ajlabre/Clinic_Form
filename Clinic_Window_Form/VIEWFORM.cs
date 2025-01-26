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
    public partial class VIEWFORM : Form
    {
        private DataTable ConsultationData;

        public VIEWFORM (DataTable ConsultationInfo)
        {
            InitializeComponent();

            ConsultationData = ConsultationInfo;

            dataGridView1.DataSource = ConsultationData;

        }
        public VIEWFORM()
        {
            InitializeComponent();

            ConsultationData = new DataTable();

            dataGridView1.DataSource = ConsultationData;
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                selectedRow.Cells["FullName"].Value = txtboxFullName.HeaderText;
                selectedRow.Cells["HouseNo"].Value = txtboxHouseNo.HeaderText;
                selectedRow.Cells["VillageSubd"].Value = txtboxVillageSubd.HeaderText;
                selectedRow.Cells["Street"].Value = txtboxStreet.HeaderText;
                selectedRow.Cells["Brgy"].Value = txtboxBrgy.HeaderText;
                selectedRow.Cells["Gender"].Value = cmbGender.HeaderText;
                selectedRow.Cells["Birthdate"].Value = DatePickerBirthdate.ValueType;
                selectedRow.Cells["Email"].Value = txtboxEmailAdd.HeaderText;
                selectedRow.Cells["MobileNum"].Value = txtboxMobileNum.HeaderText;
                selectedRow.Cells["MedHistory"].Value = cmboxMedHistory.HeaderText;
                selectedRow.Cells["OthersMedHistory"].Value = txtboxOthersMedHistory.HeaderText;

            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        DataRow dataRow = ((DataRowView)row.DataBoundItem).Row;
                        dataRow.Delete();

                        dataGridView1.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
