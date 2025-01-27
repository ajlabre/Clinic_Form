﻿
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
            btnVIEW = new Button();
            btnREGISTER = new Button();
            qstnClient = new Label();
            lblRegister = new Label();
            btnRegisterAdmin = new Button();
            btnExit = new Button();
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
            ClinicImage.Click += pictureBox1_Click;
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
            qstnAdmin.Click += qstnAdmin_Click;
            // 
            // btnVIEW
            // 
            btnVIEW.BackColor = SystemColors.GradientActiveCaption;
            btnVIEW.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVIEW.Location = new Point(90, 100);
            btnVIEW.Name = "btnVIEW";
            btnVIEW.Size = new Size(163, 32);
            btnVIEW.TabIndex = 10;
            btnVIEW.Text = "VIEW RECORD";
            btnVIEW.UseVisualStyleBackColor = false;
            btnVIEW.Click += btnVIEW_Click;
            // 
            // btnREGISTER
            // 
            btnREGISTER.BackColor = SystemColors.GradientActiveCaption;
            btnREGISTER.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnREGISTER.Location = new Point(329, 100);
            btnREGISTER.Name = "btnREGISTER";
            btnREGISTER.Size = new Size(151, 32);
            btnREGISTER.TabIndex = 12;
            btnREGISTER.Text = "REGISTER";
            btnREGISTER.UseVisualStyleBackColor = false;
            btnREGISTER.Click += btnREGISTER_Click;
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
            qstnClient.Click += qstnClient_Click;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.BackColor = SystemColors.GradientInactiveCaption;
            lblRegister.Font = new Font("Cambria", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRegister.Location = new Point(163, 232);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(270, 17);
            lblRegister.TabIndex = 13;
            lblRegister.Text = "\"Register if you don't have an account.\"";
            // 
            // btnRegisterAdmin
            // 
            btnRegisterAdmin.BackColor = SystemColors.GradientActiveCaption;
            btnRegisterAdmin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRegisterAdmin.Location = new Point(206, 197);
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
            btnExit.Location = new Point(473, 227);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(68, 22);
            btnExit.TabIndex = 15;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // ADMINCLIENTMENU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(563, 270);
            Controls.Add(btnExit);
            Controls.Add(btnRegisterAdmin);
            Controls.Add(lblRegister);
            Controls.Add(btnREGISTER);
            Controls.Add(qstnClient);
            Controls.Add(btnVIEW);
            Controls.Add(qstnAdmin);
            Controls.Add(ClinicImage);
            Controls.Add(lblConsultationForm);
            Name = "ADMINCLIENTMENU";
            Text = "MAIN MENU ";
            Load += ADMINCLIENTMENU_Load;
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
        private Button btnVIEW;
        private Button btnREGISTER;
        private Label qstnClient;
        private Label lblRegister;
        private Button btnRegisterAdmin;
        private Button btnExit;
    }
}