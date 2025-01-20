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
    public partial class WELCOMEFORMMENU : Form
    {
        public WELCOMEFORMMENU()
        {
            InitializeComponent();
        }

        private void btnNEXTMAINMENU_Click(object sender, EventArgs e)
        {
            ConsultationForm Consultationfrm = new ConsultationForm();
            Consultationfrm.Show();
            Hide();
        }

        private void btnCANCELMAINMENU_Click(object sender, EventArgs e)
        {
            ADMINCLIENTMENU AdminClientform = new ADMINCLIENTMENU();
            AdminClientform.Show();
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void WELCOMEFORMMENU_Load(object sender, EventArgs e)
        {

        }

        private void lblNext_Click(object sender, EventArgs e)
        {

        }

        private void lblCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
