namespace Clinic_Window_Form
{
    partial class REGISTERADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REGISTERADMIN));
            btnConfirm = new Button();
            txtboxRegisterPin = new TextBox();
            txtboxRegisterUser = new TextBox();
            lblPIN = new Label();
            lblusername = new Label();
            ClinicImage = new PictureBox();
            lblConsultationForm = new Label();
            lblRegisterAdmin = new Label();
            btnCancel = new Button();
            btnCheckAdmin = new Button();
            btnCheckinUser = new Button();
            ((System.ComponentModel.ISupportInitialize)ClinicImage).BeginInit();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = SystemColors.GradientActiveCaption;
            btnConfirm.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = SystemColors.ControlText;
            btnConfirm.Location = new Point(462, 206);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(143, 30);
            btnConfirm.TabIndex = 41;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtboxRegisterPin
            // 
            txtboxRegisterPin.Location = new Point(234, 169);
            txtboxRegisterPin.Name = "txtboxRegisterPin";
            txtboxRegisterPin.PasswordChar = '*';
            txtboxRegisterPin.Size = new Size(216, 23);
            txtboxRegisterPin.TabIndex = 40;
            // 
            // txtboxRegisterUser
            // 
            txtboxRegisterUser.Location = new Point(234, 114);
            txtboxRegisterUser.Name = "txtboxRegisterUser";
            txtboxRegisterUser.Size = new Size(216, 23);
            txtboxRegisterUser.TabIndex = 39;
            // 
            // lblPIN
            // 
            lblPIN.AutoSize = true;
            lblPIN.BackColor = SystemColors.GradientInactiveCaption;
            lblPIN.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPIN.Location = new Point(89, 169);
            lblPIN.Name = "lblPIN";
            lblPIN.Size = new Size(52, 25);
            lblPIN.TabIndex = 38;
            lblPIN.Text = "PIN:";
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.BackColor = SystemColors.GradientInactiveCaption;
            lblusername.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblusername.Location = new Point(89, 117);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(124, 25);
            lblusername.TabIndex = 37;
            lblusername.Text = "USERNAME:";
            // 
            // ClinicImage
            // 
            ClinicImage.Image = (Image)resources.GetObject("ClinicImage.Image");
            ClinicImage.Location = new Point(22, 22);
            ClinicImage.Name = "ClinicImage";
            ClinicImage.Size = new Size(57, 61);
            ClinicImage.TabIndex = 36;
            ClinicImage.TabStop = false;
            // 
            // lblConsultationForm
            // 
            lblConsultationForm.AutoSize = true;
            lblConsultationForm.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsultationForm.ForeColor = Color.DarkBlue;
            lblConsultationForm.Location = new Point(85, 31);
            lblConsultationForm.Name = "lblConsultationForm";
            lblConsultationForm.Size = new Size(464, 33);
            lblConsultationForm.TabIndex = 35;
            lblConsultationForm.Text = "CLINIC CONSULTATION FORM";
            // 
            // lblRegisterAdmin
            // 
            lblRegisterAdmin.AutoSize = true;
            lblRegisterAdmin.BackColor = SystemColors.GradientInactiveCaption;
            lblRegisterAdmin.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRegisterAdmin.Location = new Point(89, 68);
            lblRegisterAdmin.Name = "lblRegisterAdmin";
            lblRegisterAdmin.Size = new Size(144, 19);
            lblRegisterAdmin.TabIndex = 42;
            lblRegisterAdmin.Text = "Register as Admin.";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.GradientActiveCaption;
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ControlText;
            btnCancel.Location = new Point(22, 206);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(143, 30);
            btnCancel.TabIndex = 43;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCheckAdmin
            // 
            btnCheckAdmin.BackColor = SystemColors.GradientActiveCaption;
            btnCheckAdmin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCheckAdmin.ForeColor = SystemColors.ControlText;
            btnCheckAdmin.Location = new Point(246, 206);
            btnCheckAdmin.Name = "btnCheckAdmin";
            btnCheckAdmin.Size = new Size(143, 30);
            btnCheckAdmin.TabIndex = 44;
            btnCheckAdmin.Text = "CHECK";
            btnCheckAdmin.UseVisualStyleBackColor = false;
            btnCheckAdmin.Visible = false;
            btnCheckAdmin.Click += btnCheckAdmin_Click;
            // 
            // btnCheckinUser
            // 
            btnCheckinUser.BackColor = SystemColors.GradientActiveCaption;
            btnCheckinUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCheckinUser.ForeColor = SystemColors.ControlText;
            btnCheckinUser.Location = new Point(471, 107);
            btnCheckinUser.Name = "btnCheckinUser";
            btnCheckinUser.Size = new Size(78, 30);
            btnCheckinUser.TabIndex = 45;
            btnCheckinUser.Text = "CHECK";
            btnCheckinUser.UseVisualStyleBackColor = false;
            btnCheckinUser.Visible = false;
            btnCheckinUser.Click += btnCheckinUser_Click;
            // 
            // REGISTERADMIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(626, 258);
            Controls.Add(btnCheckinUser);
            Controls.Add(btnCheckAdmin);
            Controls.Add(btnCancel);
            Controls.Add(lblRegisterAdmin);
            Controls.Add(btnConfirm);
            Controls.Add(txtboxRegisterPin);
            Controls.Add(txtboxRegisterUser);
            Controls.Add(lblPIN);
            Controls.Add(lblusername);
            Controls.Add(ClinicImage);
            Controls.Add(lblConsultationForm);
            Name = "REGISTERADMIN";
            Text = " ";
            Load += REGISTERADMIN_Load;
            ((System.ComponentModel.ISupportInitialize)ClinicImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private TextBox txtboxRegisterPin;
        private TextBox txtboxRegisterUser;
        private Label lblPIN;
        private Label lblusername;
        private PictureBox ClinicImage;
        private Label lblConsultationForm;
        private Label lblRegisterAdmin;
        private Button btnCancel;
        private Button btnCheckAdmin;
        private Button btnCheckinUser;
    }
}