
namespace Clinic_Window_Form
{
    partial class ADMINCLIENTMENU
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMINCLIENTMENU));
            ClinicImage = new PictureBox();
            lblConsultationForm = new Label();
            qstnAdmin = new Label();
            qstnClient = new Label();
            btnRegisterAdmin = new Button();
            btnExit = new Button();
            btnRegisterClient = new Button();
            btnCheckAdmin = new Button();
            lblcheckadmin = new Label();
            lblviewclient = new Label();
            btnViewClient = new Button();
            ((System.ComponentModel.ISupportInitialize)ClinicImage).BeginInit();
            SuspendLayout();
            // 
            // ClinicImage
            // 
            ClinicImage.Image = (Image)resources.GetObject("ClinicImage.Image");
            ClinicImage.Location = new Point(14, 16);
            ClinicImage.Name = "ClinicImage";
            ClinicImage.Size = new Size(57, 61);
            ClinicImage.TabIndex = 8;
            ClinicImage.TabStop = false;
            // 
            // lblConsultationForm
            // 
            lblConsultationForm.AutoSize = true;
            lblConsultationForm.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsultationForm.ForeColor = Color.DarkBlue;
            lblConsultationForm.Location = new Point(77, 25);
            lblConsultationForm.Name = "lblConsultationForm";
            lblConsultationForm.Size = new Size(464, 33);
            lblConsultationForm.TabIndex = 7;
            lblConsultationForm.Text = "CLINIC CONSULTATION FORM";
            // 
            // qstnAdmin
            // 
            qstnAdmin.AutoSize = true;
            qstnAdmin.BackColor = SystemColors.GradientInactiveCaption;
            qstnAdmin.Font = new Font("Cambria", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            qstnAdmin.Location = new Point(99, 145);
            qstnAdmin.Name = "qstnAdmin";
            qstnAdmin.Size = new Size(145, 17);
            qstnAdmin.TabIndex = 9;
            qstnAdmin.Text = "\"Are you an Admin?\"";
            // 
            // qstnClient
            // 
            qstnClient.AutoSize = true;
            qstnClient.BackColor = SystemColors.GradientInactiveCaption;
            qstnClient.Font = new Font("Cambria", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            qstnClient.Location = new Point(341, 145);
            qstnClient.Name = "qstnClient";
            qstnClient.Size = new Size(129, 17);
            qstnClient.TabIndex = 11;
            qstnClient.Text = "\"Are you a Client?\"";
            // 
            // btnRegisterAdmin
            // 
            btnRegisterAdmin.BackColor = SystemColors.GradientActiveCaption;
            btnRegisterAdmin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegisterAdmin.Location = new Point(81, 100);
            btnRegisterAdmin.Name = "btnRegisterAdmin";
            btnRegisterAdmin.Size = new Size(163, 32);
            btnRegisterAdmin.TabIndex = 14;
            btnRegisterAdmin.Text = "REGISTER";
            btnRegisterAdmin.UseVisualStyleBackColor = false;
            btnRegisterAdmin.Click += btnRegisterAdmin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.GradientActiveCaption;
            btnExit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(473, 275);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(68, 22);
            btnExit.TabIndex = 15;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnRegisterClient
            // 
            btnRegisterClient.BackColor = SystemColors.GradientActiveCaption;
            btnRegisterClient.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegisterClient.Location = new Point(323, 100);
            btnRegisterClient.Name = "btnRegisterClient";
            btnRegisterClient.Size = new Size(163, 32);
            btnRegisterClient.TabIndex = 16;
            btnRegisterClient.Text = "REGISTER FORM";
            btnRegisterClient.UseVisualStyleBackColor = false;
            btnRegisterClient.Click += btnRegisterClient_Click;
            // 
            // btnCheckAdmin
            // 
            btnCheckAdmin.BackColor = SystemColors.GradientActiveCaption;
            btnCheckAdmin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCheckAdmin.Location = new Point(81, 197);
            btnCheckAdmin.Name = "btnCheckAdmin";
            btnCheckAdmin.Size = new Size(163, 32);
            btnCheckAdmin.TabIndex = 17;
            btnCheckAdmin.Text = "CHECK ADMIN";
            btnCheckAdmin.UseVisualStyleBackColor = false;
            // 
            // lblcheckadmin
            // 
            lblcheckadmin.AutoSize = true;
            lblcheckadmin.BackColor = SystemColors.GradientInactiveCaption;
            lblcheckadmin.Font = new Font("Cambria", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblcheckadmin.Location = new Point(81, 243);
            lblcheckadmin.Name = "lblcheckadmin";
            lblcheckadmin.Size = new Size(163, 17);
            lblcheckadmin.TabIndex = 18;
            lblcheckadmin.Text = "\"Check admin if exists.\"";
            // 
            // lblviewclient
            // 
            lblviewclient.AutoSize = true;
            lblviewclient.BackColor = SystemColors.GradientInactiveCaption;
            lblviewclient.Font = new Font("Cambria", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblviewclient.Location = new Point(323, 243);
            lblviewclient.Name = "lblviewclient";
            lblviewclient.Size = new Size(149, 17);
            lblviewclient.TabIndex = 20;
            lblviewclient.Text = "\"View client if exists.\"";
            lblviewclient.Click += label1_Click;
            // 
            // btnViewClient
            // 
            btnViewClient.BackColor = SystemColors.GradientActiveCaption;
            btnViewClient.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnViewClient.Location = new Point(321, 197);
            btnViewClient.Name = "btnViewClient";
            btnViewClient.Size = new Size(163, 32);
            btnViewClient.TabIndex = 19;
            btnViewClient.Text = "VIEW CLIENT";
            btnViewClient.UseVisualStyleBackColor = false;
            // 
            // ADMINCLIENTMENU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(560, 315);
            Controls.Add(lblviewclient);
            Controls.Add(btnViewClient);
            Controls.Add(lblcheckadmin);
            Controls.Add(btnCheckAdmin);
            Controls.Add(btnRegisterClient);
            Controls.Add(btnExit);
            Controls.Add(btnRegisterAdmin);
            Controls.Add(qstnClient);
            Controls.Add(qstnAdmin);
            Controls.Add(ClinicImage);
            Controls.Add(lblConsultationForm);
            Name = "ADMINCLIENTMENU";
            Text = "MAIN MENU ";
            ((System.ComponentModel.ISupportInitialize)ClinicImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox ClinicImage;
        private Label lblConsultationForm;
        private Label qstnAdmin;
        private Label qstnClient;
        private Button btnRegisterAdmin;
        private Button btnExit;
        private Button btnRegisterClient;
        private Button btnCheckAdmin;
        private Label lblcheckadmin;
        private Label lblviewclient;
        private Button btnViewClient;
    }
}