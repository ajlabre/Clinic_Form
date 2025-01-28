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

        private void btnREGISTER_Click(object sender, EventArgs e)
        {
            WELCOMEFORMMENU Welcomefrm = new WELCOMEFORMMENU();
            Welcomefrm.Show();
            Hide();
        }
        private void btnRegisterAdmin_Click(object sender, EventArgs e)
        {
            REGISTERADMIN RegisterAdmin = new REGISTERADMIN();
            RegisterAdmin.Show();
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnRegisterClient_Click(object sender, EventArgs e)
        {
            CONSULTATIONFORM Consultfrm = new CONSULTATIONFORM();
            Consultfrm.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
