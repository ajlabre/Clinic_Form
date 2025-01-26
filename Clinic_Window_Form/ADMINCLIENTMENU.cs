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
    public partial class ADMINCLIENTMENU : Form
    {
        public ADMINCLIENTMENU()
        {
            InitializeComponent();
        }

        private void qstnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnVIEW_Click(object sender, EventArgs e)
        {
            ADMINLOGIN AdminMenu = new ADMINLOGIN();
            AdminMenu.Show();
            Hide();
        }

        private void btnREGISTER_Click(object sender, EventArgs e)
        {
            WELCOMEFORMMENU Welcomefrm = new WELCOMEFORMMENU();
            Welcomefrm.Show();
            Hide();
        }

        private void qstnClient_Click(object sender, EventArgs e)
        {

        }

        private void ADMINCLIENTMENU_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegisterAdmin_Click(object sender, EventArgs e)
        {
            REGISTERADMIN RegisterAdmin = new REGISTERADMIN();
            RegisterAdmin.Show();
            Hide();
        }
    }
}
