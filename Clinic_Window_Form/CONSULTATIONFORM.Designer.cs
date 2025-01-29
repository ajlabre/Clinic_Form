namespace Clinic_Window_Form
{
    partial class CONSULTATIONFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CONSULTATIONFORM));
            ClinicImage = new PictureBox();
            lblClinicConsultationForm = new Label();
            txtboxFullName = new TextBox();
            lblFullName = new Label();
            lblAddress = new Label();
            txtboxAddress = new TextBox();
            txtboxEmailAdd = new TextBox();
            lblEmailAdd = new Label();
            lblBirthdate = new Label();
            txtboxMobileNum = new TextBox();
            lblMobileNum = new Label();
            lblMedicalHistory = new Label();
            lblGender = new Label();
            btnCONFIRM = new Button();
            btnCancel = new Button();
            txtboxGender = new TextBox();
            txtboxBirthdate = new TextBox();
            txtboxMedHistory = new TextBox();
            btnCheck = new Button();
            btnCheckClient = new Button();
            ((System.ComponentModel.ISupportInitialize)ClinicImage).BeginInit();
            SuspendLayout();
            // 
            // ClinicImage
            // 
            ClinicImage.Image = (Image)resources.GetObject("ClinicImage.Image");
            ClinicImage.Location = new Point(13, 16);
            ClinicImage.Name = "ClinicImage";
            ClinicImage.Size = new Size(57, 61);
            ClinicImage.TabIndex = 10;
            ClinicImage.TabStop = false;
            // 
            // lblClinicConsultationForm
            // 
            lblClinicConsultationForm.AutoSize = true;
            lblClinicConsultationForm.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClinicConsultationForm.ForeColor = Color.DarkBlue;
            lblClinicConsultationForm.Location = new Point(76, 25);
            lblClinicConsultationForm.Name = "lblClinicConsultationForm";
            lblClinicConsultationForm.Size = new Size(464, 33);
            lblClinicConsultationForm.TabIndex = 9;
            lblClinicConsultationForm.Text = "CLINIC CONSULTATION FORM";
            // 
            // txtboxFullName
            // 
            txtboxFullName.Location = new Point(187, 95);
            txtboxFullName.Name = "txtboxFullName";
            txtboxFullName.Size = new Size(216, 23);
            txtboxFullName.TabIndex = 15;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.BackColor = SystemColors.GradientInactiveCaption;
            lblFullName.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(35, 93);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(106, 25);
            lblFullName.TabIndex = 14;
            lblFullName.Text = "Full Name";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = SystemColors.GradientInactiveCaption;
            lblAddress.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(35, 143);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(87, 25);
            lblAddress.TabIndex = 16;
            lblAddress.Text = "Address";
            // 
            // txtboxAddress
            // 
            txtboxAddress.Location = new Point(187, 145);
            txtboxAddress.Name = "txtboxAddress";
            txtboxAddress.Size = new Size(353, 23);
            txtboxAddress.TabIndex = 21;
            // 
            // txtboxEmailAdd
            // 
            txtboxEmailAdd.Location = new Point(187, 239);
            txtboxEmailAdd.Name = "txtboxEmailAdd";
            txtboxEmailAdd.Size = new Size(216, 23);
            txtboxEmailAdd.TabIndex = 28;
            // 
            // lblEmailAdd
            // 
            lblEmailAdd.AutoSize = true;
            lblEmailAdd.BackColor = SystemColors.GradientInactiveCaption;
            lblEmailAdd.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEmailAdd.Location = new Point(35, 239);
            lblEmailAdd.Name = "lblEmailAdd";
            lblEmailAdd.Size = new Size(146, 25);
            lblEmailAdd.TabIndex = 27;
            lblEmailAdd.Text = "Email Address";
            // 
            // lblBirthdate
            // 
            lblBirthdate.AutoSize = true;
            lblBirthdate.BackColor = SystemColors.GradientInactiveCaption;
            lblBirthdate.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBirthdate.Location = new Point(35, 290);
            lblBirthdate.Name = "lblBirthdate";
            lblBirthdate.Size = new Size(105, 25);
            lblBirthdate.TabIndex = 29;
            lblBirthdate.Text = "BirthDate";
            // 
            // txtboxMobileNum
            // 
            txtboxMobileNum.Location = new Point(187, 344);
            txtboxMobileNum.Name = "txtboxMobileNum";
            txtboxMobileNum.Size = new Size(216, 23);
            txtboxMobileNum.TabIndex = 31;
            // 
            // lblMobileNum
            // 
            lblMobileNum.AutoSize = true;
            lblMobileNum.BackColor = SystemColors.GradientInactiveCaption;
            lblMobileNum.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMobileNum.Location = new Point(31, 342);
            lblMobileNum.Name = "lblMobileNum";
            lblMobileNum.Size = new Size(150, 25);
            lblMobileNum.TabIndex = 30;
            lblMobileNum.Text = "MobileNumber";
            // 
            // lblMedicalHistory
            // 
            lblMedicalHistory.AutoSize = true;
            lblMedicalHistory.BackColor = SystemColors.GradientInactiveCaption;
            lblMedicalHistory.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMedicalHistory.Location = new Point(31, 395);
            lblMedicalHistory.Name = "lblMedicalHistory";
            lblMedicalHistory.Size = new Size(159, 25);
            lblMedicalHistory.TabIndex = 32;
            lblMedicalHistory.Text = "Medical History";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = SystemColors.GradientInactiveCaption;
            lblGender.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(35, 188);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(138, 25);
            lblGender.TabIndex = 35;
            lblGender.Text = "Gender (F/M)";
            // 
            // btnCONFIRM
            // 
            btnCONFIRM.BackColor = SystemColors.GradientActiveCaption;
            btnCONFIRM.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCONFIRM.ForeColor = SystemColors.ControlText;
            btnCONFIRM.Location = new Point(427, 457);
            btnCONFIRM.Name = "btnCONFIRM";
            btnCONFIRM.Size = new Size(143, 30);
            btnCONFIRM.TabIndex = 40;
            btnCONFIRM.Text = "CONFIRM";
            btnCONFIRM.UseVisualStyleBackColor = false;
            btnCONFIRM.Click += btnCONFIRM_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.GradientActiveCaption;
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ControlText;
            btnCancel.Location = new Point(30, 457);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(143, 30);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtboxGender
            // 
            txtboxGender.Location = new Point(187, 188);
            txtboxGender.Name = "txtboxGender";
            txtboxGender.Size = new Size(86, 23);
            txtboxGender.TabIndex = 42;
            // 
            // txtboxBirthdate
            // 
            txtboxBirthdate.Location = new Point(187, 290);
            txtboxBirthdate.Name = "txtboxBirthdate";
            txtboxBirthdate.Size = new Size(216, 23);
            txtboxBirthdate.TabIndex = 43;
            // 
            // txtboxMedHistory
            // 
            txtboxMedHistory.Location = new Point(187, 395);
            txtboxMedHistory.Name = "txtboxMedHistory";
            txtboxMedHistory.Size = new Size(216, 23);
            txtboxMedHistory.TabIndex = 44;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = SystemColors.GradientActiveCaption;
            btnCheck.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCheck.ForeColor = SystemColors.ControlText;
            btnCheck.Location = new Point(235, 457);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(143, 30);
            btnCheck.TabIndex = 45;
            btnCheck.Text = "CHECK";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnCheckClient
            // 
            btnCheckClient.BackColor = SystemColors.GradientActiveCaption;
            btnCheckClient.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCheckClient.ForeColor = SystemColors.ControlText;
            btnCheckClient.Location = new Point(418, 91);
            btnCheckClient.Name = "btnCheckClient";
            btnCheckClient.Size = new Size(73, 30);
            btnCheckClient.TabIndex = 46;
            btnCheckClient.Text = "CHECK";
            btnCheckClient.UseVisualStyleBackColor = false;
            btnCheckClient.Visible = false;
            btnCheckClient.Click += btnCheckClient_Click;
            // 
            // CONSULTATIONFORM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(592, 513);
            Controls.Add(btnCheckClient);
            Controls.Add(btnCheck);
            Controls.Add(txtboxMedHistory);
            Controls.Add(txtboxBirthdate);
            Controls.Add(txtboxGender);
            Controls.Add(btnCancel);
            Controls.Add(btnCONFIRM);
            Controls.Add(lblGender);
            Controls.Add(lblMedicalHistory);
            Controls.Add(txtboxMobileNum);
            Controls.Add(lblMobileNum);
            Controls.Add(lblBirthdate);
            Controls.Add(txtboxEmailAdd);
            Controls.Add(lblEmailAdd);
            Controls.Add(txtboxAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtboxFullName);
            Controls.Add(lblFullName);
            Controls.Add(ClinicImage);
            Controls.Add(lblClinicConsultationForm);
            Name = "CONSULTATIONFORM";
            Text = "CONSULTATIONFORM";
            Load += CONSULTATIONFORM_Load;
            ((System.ComponentModel.ISupportInitialize)ClinicImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ClinicImage;
        private Label lblClinicConsultationForm;
        private TextBox txtboxFullName;
        private Label lblFullName;
        private Label lblAddress;
        private TextBox txtboxAddress;
        private TextBox txtboxEmailAdd;
        private Label lblEmailAdd;
        private Label lblBirthdate;
        private TextBox txtboxMobileNum;
        private Label lblMobileNum;
        private Label lblMedicalHistory;
        private Label lblGender;
        private Button btnCONFIRM;
        private Button btnCancel;
        private TextBox txtboxGender;
        private TextBox txtboxBirthdate;
        private TextBox txtboxMedHistory;
        private Button btnCheck;
        private Button btnCheckClient;
    }
}