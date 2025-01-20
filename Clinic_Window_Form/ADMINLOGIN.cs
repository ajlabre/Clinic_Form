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
            MessageBox.Show("Admin confirmed successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            VIEWFORM viewForm = new VIEWFORM();
            viewForm.Show();
            Hide();
        }
    }
}
