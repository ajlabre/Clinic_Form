using ClinicConsultationLogic;

namespace Clinic_Window_Form
{
    public partial class REGISTERADMIN : Form
    {
        public REGISTERADMIN()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ADMINCLIENTMENU AdminClientMenu = new ADMINCLIENTMENU();
            AdminClientMenu.Show();
            Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //    lblusername.Visible = true;
            //    lblPIN.Visible = true;
            //    lblConsultationForm.Visible = true;
            //    lblRegisterAdmin.Visible = true;

            //    txtboxRegisterUser.Visible = true;
            //    txtboxRegisterPin.Visible = true;
            //    btnConfirm.Visible = true;
            //    btnCancel.Visible = true;

            ClinicManage.AddAdmin(txtboxRegisterUser.Text,
            txtboxRegisterPin.Text);

            txtboxRegisterUser.Text = "";
            txtboxRegisterPin.Text = "";

            MessageBox.Show("Admin Registered Successfully",
            "Admin Registration", MessageBoxButtons.OK);

            btnCheckAdmin.Visible = true;
            //ADMINCLIENTMENU AdminClientMenu = new ADMINCLIENTMENU();
            //AdminClientMenu.Show();
            //Hide();
        }

        private void REGISTERADMIN_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckAdmin_Click(object sender, EventArgs e)
        {
            lblusername.Visible = true;
            txtboxRegisterUser.Visible = true;
            btnCheckAdmin.Visible = true;
            btnCheckinUser.Visible = true;

            btnConfirm.Visible = false;
            lblPIN.Visible = false;
            txtboxRegisterPin.Visible = false;

        }

        private void btnCheckinUser_Click(object sender, EventArgs e)
        {
            var result = ClinicManage.ViewAdmin(txtboxRegisterUser.Text);

            if (result)
            {
                MessageBox.Show("Admin exists.",
                "Admin Check", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Admin does not exists.",
                "Admin Check", MessageBoxButtons.OK);
            }
        }
    }
}
