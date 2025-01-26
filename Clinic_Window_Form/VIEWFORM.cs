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
        private DataTable dataInfo;
        public VIEWFORM()
        {
            InitializeComponent();

            dataInfo = new DataTable();

            dataInfo.Columns.Add("ID", typeof(int));
            dataInfo.Columns.Add("FullName", typeof(string));

            dataGridView1.DataSource = dataInfo;
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
    }
}
