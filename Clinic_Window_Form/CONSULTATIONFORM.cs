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
            ADMINCLIENTMENU AdminClientMenu = new ADMINCLIENTMENU();
            AdminClientMenu.Show();
            Hide();
        }
        private void CONSULTATIONFORM_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
        }
    }
}
