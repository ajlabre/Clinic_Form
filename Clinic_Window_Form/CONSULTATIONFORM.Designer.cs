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
            txtboxHouseNo = new TextBox();
            lblAddress = new Label();
            lblHouseNo = new Label();
            lblVillageSubd = new Label();
            txtboxVillageSubd = new TextBox();
            lblStreet = new Label();
            txtboxStreet = new TextBox();
            lblBrgy = new Label();
            txtboxBrgy = new TextBox();
            lblCityProvince = new Label();
            txtboxCityProvince = new TextBox();
            txtboxEmailAdd = new TextBox();
            lblEmailAdd = new Label();
            lblBirthdate = new Label();
            txtboxMobileNum = new TextBox();
            lblMobileNum = new Label();
            MedicalHistory = new Label();
            lblGender = new Label();
            btnCONFIRM = new Button();
            btnCancel = new Button();
            txtboxGender = new TextBox();
            txtboxBirthdate = new TextBox();
            txtboxMedHistory = new TextBox();
            btnClear = new Button();
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
            // txtboxHouseNo
            // 
            txtboxHouseNo.Location = new Point(156, 169);
            txtboxHouseNo.Name = "txtboxHouseNo";
            txtboxHouseNo.Size = new Size(150, 23);
            txtboxHouseNo.TabIndex = 17;
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
            // lblHouseNo
            // 
            lblHouseNo.AutoSize = true;
            lblHouseNo.BackColor = SystemColors.GradientInactiveCaption;
            lblHouseNo.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHouseNo.Location = new Point(156, 143);
            lblHouseNo.Name = "lblHouseNo";
            lblHouseNo.Size = new Size(81, 19);
            lblHouseNo.TabIndex = 18;
            lblHouseNo.Text = "House No.";
            // 
            // lblVillageSubd
            // 
            lblVillageSubd.AutoSize = true;
            lblVillageSubd.BackColor = SystemColors.GradientInactiveCaption;
            lblVillageSubd.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblVillageSubd.Location = new Point(156, 207);
            lblVillageSubd.Name = "lblVillageSubd";
            lblVillageSubd.Size = new Size(103, 19);
            lblVillageSubd.TabIndex = 20;
            lblVillageSubd.Text = "Village/Subd";
            // 
            // txtboxVillageSubd
            // 
            txtboxVillageSubd.Location = new Point(156, 233);
            txtboxVillageSubd.Name = "txtboxVillageSubd";
            txtboxVillageSubd.Size = new Size(158, 23);
            txtboxVillageSubd.TabIndex = 19;
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.BackColor = SystemColors.GradientInactiveCaption;
            lblStreet.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStreet.Location = new Point(335, 143);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(52, 19);
            lblStreet.TabIndex = 22;
            lblStreet.Text = "Street";
            // 
            // txtboxStreet
            // 
            txtboxStreet.Location = new Point(335, 169);
            txtboxStreet.Name = "txtboxStreet";
            txtboxStreet.Size = new Size(158, 23);
            txtboxStreet.TabIndex = 21;
            // 
            // lblBrgy
            // 
            lblBrgy.AutoSize = true;
            lblBrgy.BackColor = SystemColors.GradientInactiveCaption;
            lblBrgy.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBrgy.Location = new Point(335, 207);
            lblBrgy.Name = "lblBrgy";
            lblBrgy.Size = new Size(43, 19);
            lblBrgy.TabIndex = 24;
            lblBrgy.Text = "Brgy";
            // 
            // txtboxBrgy
            // 
            txtboxBrgy.Location = new Point(335, 233);
            txtboxBrgy.Name = "txtboxBrgy";
            txtboxBrgy.Size = new Size(158, 23);
            txtboxBrgy.TabIndex = 23;
            // 
            // lblCityProvince
            // 
            lblCityProvince.AutoSize = true;
            lblCityProvince.BackColor = SystemColors.GradientInactiveCaption;
            lblCityProvince.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCityProvince.Location = new Point(156, 275);
            lblCityProvince.Name = "lblCityProvince";
            lblCityProvince.Size = new Size(108, 19);
            lblCityProvince.TabIndex = 26;
            lblCityProvince.Text = "City/Province";
            // 
            // txtboxCityProvince
            // 
            txtboxCityProvince.Location = new Point(156, 301);
            txtboxCityProvince.Name = "txtboxCityProvince";
            txtboxCityProvince.Size = new Size(158, 23);
            txtboxCityProvince.TabIndex = 25;
            // 
            // txtboxEmailAdd
            // 
            txtboxEmailAdd.Location = new Point(187, 397);
            txtboxEmailAdd.Name = "txtboxEmailAdd";
            txtboxEmailAdd.Size = new Size(216, 23);
            txtboxEmailAdd.TabIndex = 28;
            // 
            // lblEmailAdd
            // 
            lblEmailAdd.AutoSize = true;
            lblEmailAdd.BackColor = SystemColors.GradientInactiveCaption;
            lblEmailAdd.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEmailAdd.Location = new Point(35, 397);
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
            lblBirthdate.Location = new Point(35, 448);
            lblBirthdate.Name = "lblBirthdate";
            lblBirthdate.Size = new Size(105, 25);
            lblBirthdate.TabIndex = 29;
            lblBirthdate.Text = "BirthDate";
            // 
            // txtboxMobileNum
            // 
            txtboxMobileNum.Location = new Point(187, 502);
            txtboxMobileNum.Name = "txtboxMobileNum";
            txtboxMobileNum.Size = new Size(216, 23);
            txtboxMobileNum.TabIndex = 31;
            // 
            // lblMobileNum
            // 
            lblMobileNum.AutoSize = true;
            lblMobileNum.BackColor = SystemColors.GradientInactiveCaption;
            lblMobileNum.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMobileNum.Location = new Point(31, 500);
            lblMobileNum.Name = "lblMobileNum";
            lblMobileNum.Size = new Size(150, 25);
            lblMobileNum.TabIndex = 30;
            lblMobileNum.Text = "MobileNumber";
            // 
            // MedicalHistory
            // 
            MedicalHistory.AutoSize = true;
            MedicalHistory.BackColor = SystemColors.GradientInactiveCaption;
            MedicalHistory.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MedicalHistory.Location = new Point(31, 553);
            MedicalHistory.Name = "MedicalHistory";
            MedicalHistory.Size = new Size(159, 25);
            MedicalHistory.TabIndex = 32;
            MedicalHistory.Text = "Medical History";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = SystemColors.GradientInactiveCaption;
            lblGender.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(35, 346);
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
            btnCONFIRM.Location = new Point(427, 612);
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
            btnCancel.Location = new Point(30, 612);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(143, 30);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtboxGender
            // 
            txtboxGender.Location = new Point(187, 346);
            txtboxGender.Name = "txtboxGender";
            txtboxGender.Size = new Size(86, 23);
            txtboxGender.TabIndex = 42;
            // 
            // txtboxBirthdate
            // 
            txtboxBirthdate.Location = new Point(187, 448);
            txtboxBirthdate.Name = "txtboxBirthdate";
            txtboxBirthdate.Size = new Size(216, 23);
            txtboxBirthdate.TabIndex = 43;
            // 
            // txtboxMedHistory
            // 
            txtboxMedHistory.Location = new Point(187, 553);
            txtboxMedHistory.Name = "txtboxMedHistory";
            txtboxMedHistory.Size = new Size(216, 23);
            txtboxMedHistory.TabIndex = 44;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.GradientActiveCaption;
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ControlText;
            btnClear.Location = new Point(235, 612);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(143, 30);
            btnClear.TabIndex = 45;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // CONSULTATIONFORM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(592, 667);
            Controls.Add(btnClear);
            Controls.Add(txtboxMedHistory);
            Controls.Add(txtboxBirthdate);
            Controls.Add(txtboxGender);
            Controls.Add(btnCancel);
            Controls.Add(btnCONFIRM);
            Controls.Add(lblGender);
            Controls.Add(MedicalHistory);
            Controls.Add(txtboxMobileNum);
            Controls.Add(lblMobileNum);
            Controls.Add(lblBirthdate);
            Controls.Add(txtboxEmailAdd);
            Controls.Add(lblEmailAdd);
            Controls.Add(lblCityProvince);
            Controls.Add(txtboxCityProvince);
            Controls.Add(lblBrgy);
            Controls.Add(txtboxBrgy);
            Controls.Add(lblStreet);
            Controls.Add(txtboxStreet);
            Controls.Add(lblVillageSubd);
            Controls.Add(txtboxVillageSubd);
            Controls.Add(lblHouseNo);
            Controls.Add(txtboxHouseNo);
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
        private TextBox txtboxHouseNo;
        private Label lblAddress;
        private Label lblHouseNo;
        private Label lblVillageSubd;
        private TextBox txtboxVillageSubd;
        private Label lblStreet;
        private TextBox txtboxStreet;
        private Label lblBrgy;
        private TextBox txtboxBrgy;
        private Label lblCityProvince;
        private TextBox txtboxCityProvince;
        private TextBox txtboxEmailAdd;
        private Label lblEmailAdd;
        private Label lblBirthdate;
        private TextBox txtboxMobileNum;
        private Label lblMobileNum;
        private TextBox txtboxOthersMedHistory;
        private Label MedicalHistory;
        private Label label1;
        private Label lblGender;
        private Button btnCONFIRM;
        private Button btnCancel;
        private TextBox txtboxGender;
        private TextBox txtboxBirthdate;
        private TextBox txtboxMedHistory;
        private Button btnClear;
    }
}