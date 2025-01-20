namespace Clinic_Window_Form
{
    partial class ConsultationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultationForm));
            ClinicImage = new PictureBox();
            lblClinicConsultationForm = new Label();
            lblFullName = new Label();
            lblAddress = new Label();
            lblBirthdate = new Label();
            lblGender = new Label();
            lblEmailAdd = new Label();
            lblMobileNum = new Label();
            lblMedHistory = new Label();
            rdbtnFemale = new RadioButton();
            rdbtnMale = new RadioButton();
            DatePickerBirthdate = new DateTimePicker();
            txtboxFullName = new TextBox();
            txtboxHouseNo = new TextBox();
            txtboxEmailAdd = new TextBox();
            txtboxMobileNum = new TextBox();
            lblHouseNo = new Label();
            lblStreet = new Label();
            txtboxStreet = new TextBox();
            lblVillageSubd = new Label();
            txtboxVillageSubd = new TextBox();
            lblBrgy = new Label();
            txtboxBrgy = new TextBox();
            lblCityProvince = new Label();
            txtboxCityProvince = new TextBox();
            cmboxMedHistory = new ComboBox();
            btnCONFIRMFORM = new Button();
            lblOthersMedHistory = new Label();
            txtboxOthersMedHistory = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ClinicImage).BeginInit();
            SuspendLayout();
            // 
            // ClinicImage
            // 
            ClinicImage.Image = (Image)resources.GetObject("ClinicImage.Image");
            ClinicImage.Location = new Point(12, 12);
            ClinicImage.Name = "ClinicImage";
            ClinicImage.Size = new Size(57, 61);
            ClinicImage.TabIndex = 6;
            ClinicImage.TabStop = false;
            ClinicImage.Click += pictureBox1_Click;
            // 
            // lblClinicConsultationForm
            // 
            lblClinicConsultationForm.AutoSize = true;
            lblClinicConsultationForm.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClinicConsultationForm.ForeColor = Color.DarkBlue;
            lblClinicConsultationForm.Location = new Point(75, 21);
            lblClinicConsultationForm.Name = "lblClinicConsultationForm";
            lblClinicConsultationForm.Size = new Size(464, 33);
            lblClinicConsultationForm.TabIndex = 5;
            lblClinicConsultationForm.Text = "CLINIC CONSULTATION FORM";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.BackColor = SystemColors.GradientInactiveCaption;
            lblFullName.Font = new Font("Cambria", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = SystemColors.ControlText;
            lblFullName.Location = new Point(30, 101);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(105, 22);
            lblFullName.TabIndex = 8;
            lblFullName.Text = "Full Name: ";
            lblFullName.Click += label3_Click;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = SystemColors.GradientInactiveCaption;
            lblAddress.Font = new Font("Cambria", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = SystemColors.ControlText;
            lblAddress.Location = new Point(30, 155);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(87, 22);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Address: ";
            // 
            // lblBirthdate
            // 
            lblBirthdate.AutoSize = true;
            lblBirthdate.BackColor = SystemColors.GradientInactiveCaption;
            lblBirthdate.Font = new Font("Cambria", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBirthdate.ForeColor = SystemColors.ControlText;
            lblBirthdate.Location = new Point(30, 300);
            lblBirthdate.Name = "lblBirthdate";
            lblBirthdate.Size = new Size(102, 22);
            lblBirthdate.TabIndex = 10;
            lblBirthdate.Text = "Birthdate: ";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = SystemColors.GradientInactiveCaption;
            lblGender.Font = new Font("Cambria", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGender.ForeColor = SystemColors.ControlText;
            lblGender.Location = new Point(30, 350);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(80, 22);
            lblGender.TabIndex = 11;
            lblGender.Text = "Gender: ";
            // 
            // lblEmailAdd
            // 
            lblEmailAdd.AutoSize = true;
            lblEmailAdd.BackColor = SystemColors.GradientInactiveCaption;
            lblEmailAdd.Font = new Font("Cambria", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEmailAdd.ForeColor = SystemColors.ControlText;
            lblEmailAdd.Location = new Point(30, 397);
            lblEmailAdd.Name = "lblEmailAdd";
            lblEmailAdd.Size = new Size(141, 22);
            lblEmailAdd.TabIndex = 12;
            lblEmailAdd.Text = "Email Address: ";
            // 
            // lblMobileNum
            // 
            lblMobileNum.AutoSize = true;
            lblMobileNum.BackColor = SystemColors.GradientInactiveCaption;
            lblMobileNum.Font = new Font("Cambria", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMobileNum.ForeColor = SystemColors.ControlText;
            lblMobileNum.Location = new Point(30, 447);
            lblMobileNum.Name = "lblMobileNum";
            lblMobileNum.Size = new Size(150, 22);
            lblMobileNum.TabIndex = 13;
            lblMobileNum.Text = "Mobile Number: ";
            // 
            // lblMedHistory
            // 
            lblMedHistory.AutoSize = true;
            lblMedHistory.BackColor = SystemColors.GradientInactiveCaption;
            lblMedHistory.Font = new Font("Cambria", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMedHistory.ForeColor = SystemColors.ControlText;
            lblMedHistory.Location = new Point(30, 495);
            lblMedHistory.Name = "lblMedHistory";
            lblMedHistory.Size = new Size(150, 22);
            lblMedHistory.TabIndex = 14;
            lblMedHistory.Text = "Medical History:";
            // 
            // rdbtnFemale
            // 
            rdbtnFemale.AutoSize = true;
            rdbtnFemale.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rdbtnFemale.ForeColor = Color.Black;
            rdbtnFemale.Location = new Point(188, 350);
            rdbtnFemale.Name = "rdbtnFemale";
            rdbtnFemale.Size = new Size(86, 25);
            rdbtnFemale.TabIndex = 15;
            rdbtnFemale.TabStop = true;
            rdbtnFemale.Text = "FEMALE";
            rdbtnFemale.UseVisualStyleBackColor = true;
            rdbtnFemale.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdbtnMale
            // 
            rdbtnMale.AutoSize = true;
            rdbtnMale.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            rdbtnMale.ForeColor = Color.Black;
            rdbtnMale.Location = new Point(302, 350);
            rdbtnMale.Name = "rdbtnMale";
            rdbtnMale.Size = new Size(70, 25);
            rdbtnMale.TabIndex = 16;
            rdbtnMale.TabStop = true;
            rdbtnMale.Text = "MALE";
            rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // DatePickerBirthdate
            // 
            DatePickerBirthdate.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DatePickerBirthdate.CalendarMonthBackground = SystemColors.GradientActiveCaption;
            DatePickerBirthdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DatePickerBirthdate.Location = new Point(188, 293);
            DatePickerBirthdate.Name = "DatePickerBirthdate";
            DatePickerBirthdate.Size = new Size(261, 29);
            DatePickerBirthdate.TabIndex = 17;
            // 
            // txtboxFullName
            // 
            txtboxFullName.Location = new Point(188, 100);
            txtboxFullName.Name = "txtboxFullName";
            txtboxFullName.Size = new Size(261, 23);
            txtboxFullName.TabIndex = 18;
            txtboxFullName.TextChanged += textBox1_TextChanged;
            // 
            // txtboxHouseNo
            // 
            txtboxHouseNo.Location = new Point(200, 154);
            txtboxHouseNo.Name = "txtboxHouseNo";
            txtboxHouseNo.Size = new Size(157, 23);
            txtboxHouseNo.TabIndex = 19;
            // 
            // txtboxEmailAdd
            // 
            txtboxEmailAdd.Location = new Point(188, 397);
            txtboxEmailAdd.Name = "txtboxEmailAdd";
            txtboxEmailAdd.Size = new Size(261, 23);
            txtboxEmailAdd.TabIndex = 20;
            // 
            // txtboxMobileNum
            // 
            txtboxMobileNum.Location = new Point(188, 447);
            txtboxMobileNum.Name = "txtboxMobileNum";
            txtboxMobileNum.Size = new Size(261, 23);
            txtboxMobileNum.TabIndex = 21;
            // 
            // lblHouseNo
            // 
            lblHouseNo.AutoSize = true;
            lblHouseNo.BackColor = SystemColors.GradientInactiveCaption;
            lblHouseNo.Font = new Font("Cambria", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblHouseNo.ForeColor = SystemColors.ControlText;
            lblHouseNo.Location = new Point(123, 162);
            lblHouseNo.Name = "lblHouseNo";
            lblHouseNo.Size = new Size(71, 15);
            lblHouseNo.TabIndex = 23;
            lblHouseNo.Text = "HOUSE NO.";
            lblHouseNo.Click += label9_Click;
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.BackColor = SystemColors.GradientInactiveCaption;
            lblStreet.Font = new Font("Cambria", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblStreet.ForeColor = SystemColors.ControlText;
            lblStreet.Location = new Point(393, 162);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(52, 15);
            lblStreet.TabIndex = 25;
            lblStreet.Text = "STREET";
            // 
            // txtboxStreet
            // 
            txtboxStreet.Location = new Point(466, 155);
            txtboxStreet.Name = "txtboxStreet";
            txtboxStreet.Size = new Size(157, 23);
            txtboxStreet.TabIndex = 24;
            // 
            // lblVillageSubd
            // 
            lblVillageSubd.AutoSize = true;
            lblVillageSubd.BackColor = SystemColors.GradientInactiveCaption;
            lblVillageSubd.Font = new Font("Cambria", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblVillageSubd.ForeColor = SystemColors.ControlText;
            lblVillageSubd.Location = new Point(97, 203);
            lblVillageSubd.Name = "lblVillageSubd";
            lblVillageSubd.Size = new Size(97, 15);
            lblVillageSubd.TabIndex = 27;
            lblVillageSubd.Text = "VILLAGE/SUBD.";
            // 
            // txtboxVillageSubd
            // 
            txtboxVillageSubd.Location = new Point(200, 200);
            txtboxVillageSubd.Name = "txtboxVillageSubd";
            txtboxVillageSubd.Size = new Size(157, 23);
            txtboxVillageSubd.TabIndex = 26;
            // 
            // lblBrgy
            // 
            lblBrgy.AutoSize = true;
            lblBrgy.BackColor = SystemColors.GradientInactiveCaption;
            lblBrgy.Font = new Font("Cambria", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblBrgy.ForeColor = SystemColors.ControlText;
            lblBrgy.Location = new Point(379, 203);
            lblBrgy.Name = "lblBrgy";
            lblBrgy.Size = new Size(70, 15);
            lblBrgy.TabIndex = 29;
            lblBrgy.Text = "BARANGAY";
            // 
            // txtboxBrgy
            // 
            txtboxBrgy.Location = new Point(466, 200);
            txtboxBrgy.Name = "txtboxBrgy";
            txtboxBrgy.Size = new Size(157, 23);
            txtboxBrgy.TabIndex = 28;
            // 
            // lblCityProvince
            // 
            lblCityProvince.AutoSize = true;
            lblCityProvince.BackColor = SystemColors.GradientInactiveCaption;
            lblCityProvince.Font = new Font("Cambria", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblCityProvince.ForeColor = SystemColors.ControlText;
            lblCityProvince.Location = new Point(95, 249);
            lblCityProvince.Name = "lblCityProvince";
            lblCityProvince.Size = new Size(99, 15);
            lblCityProvince.TabIndex = 31;
            lblCityProvince.Text = "CITY/PROVINCE";
            lblCityProvince.Click += label13_Click;
            // 
            // txtboxCityProvince
            // 
            txtboxCityProvince.Location = new Point(200, 246);
            txtboxCityProvince.Name = "txtboxCityProvince";
            txtboxCityProvince.Size = new Size(157, 23);
            txtboxCityProvince.TabIndex = 30;
            // 
            // cmboxMedHistory
            // 
            cmboxMedHistory.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cmboxMedHistory.FormattingEnabled = true;
            cmboxMedHistory.Items.AddRange(new object[] { "Asthma", "Hypertension", "Diabetes", "Heart Disease", "Cancer " });
            cmboxMedHistory.Location = new Point(188, 495);
            cmboxMedHistory.Name = "cmboxMedHistory";
            cmboxMedHistory.Size = new Size(261, 23);
            cmboxMedHistory.TabIndex = 32;
            cmboxMedHistory.Text = "Please Select.";
            cmboxMedHistory.UseWaitCursor = true;
            // 
            // btnCONFIRMFORM
            // 
            btnCONFIRMFORM.BackColor = SystemColors.GradientActiveCaption;
            btnCONFIRMFORM.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCONFIRMFORM.ForeColor = SystemColors.ControlText;
            btnCONFIRMFORM.Location = new Point(477, 559);
            btnCONFIRMFORM.Name = "btnCONFIRMFORM";
            btnCONFIRMFORM.Size = new Size(143, 30);
            btnCONFIRMFORM.TabIndex = 33;
            btnCONFIRMFORM.Text = "CONFIRM";
            btnCONFIRMFORM.UseVisualStyleBackColor = false;
            btnCONFIRMFORM.Click += btnCONFIRMFORM_Click;
            // 
            // lblOthersMedHistory
            // 
            lblOthersMedHistory.AutoSize = true;
            lblOthersMedHistory.BackColor = SystemColors.GradientInactiveCaption;
            lblOthersMedHistory.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOthersMedHistory.ForeColor = SystemColors.ControlText;
            lblOthersMedHistory.Location = new Point(188, 545);
            lblOthersMedHistory.Name = "lblOthersMedHistory";
            lblOthersMedHistory.Size = new Size(57, 19);
            lblOthersMedHistory.TabIndex = 34;
            lblOthersMedHistory.Text = "Others:";
            // 
            // txtboxOthersMedHistory
            // 
            txtboxOthersMedHistory.Location = new Point(251, 541);
            txtboxOthersMedHistory.Name = "txtboxOthersMedHistory";
            txtboxOthersMedHistory.Size = new Size(198, 23);
            txtboxOthersMedHistory.TabIndex = 35;
            // 
            // ConsultationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(654, 627);
            Controls.Add(txtboxOthersMedHistory);
            Controls.Add(lblOthersMedHistory);
            Controls.Add(btnCONFIRMFORM);
            Controls.Add(cmboxMedHistory);
            Controls.Add(lblCityProvince);
            Controls.Add(txtboxCityProvince);
            Controls.Add(lblBrgy);
            Controls.Add(txtboxBrgy);
            Controls.Add(lblVillageSubd);
            Controls.Add(txtboxVillageSubd);
            Controls.Add(lblStreet);
            Controls.Add(txtboxStreet);
            Controls.Add(lblHouseNo);
            Controls.Add(txtboxMobileNum);
            Controls.Add(txtboxEmailAdd);
            Controls.Add(txtboxHouseNo);
            Controls.Add(txtboxFullName);
            Controls.Add(DatePickerBirthdate);
            Controls.Add(rdbtnMale);
            Controls.Add(rdbtnFemale);
            Controls.Add(lblMedHistory);
            Controls.Add(lblMobileNum);
            Controls.Add(lblEmailAdd);
            Controls.Add(lblGender);
            Controls.Add(lblBirthdate);
            Controls.Add(lblAddress);
            Controls.Add(lblFullName);
            Controls.Add(ClinicImage);
            Controls.Add(lblClinicConsultationForm);
            ForeColor = SystemColors.GradientActiveCaption;
            Name = "ConsultationForm";
            Text = "CONSULTATION FORM";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)ClinicImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ClinicImage;
        private Label lblClinicConsultationForm;
        private Label lblFullName;
        private Label lblAddress;
        private Label lblBirthdate;
        private Label lblGender;
        private Label lblEmailAdd;
        private Label lblMobileNum;
        private Label lblMedHistory;
        private RadioButton rdbtnFemale;
        private RadioButton rdbtnMale;
        private DateTimePicker DatePickerBirthdate;
        private TextBox txtboxFullName;
        private TextBox txtboxHouseNo;
        private TextBox txtboxEmailAdd;
        private TextBox txtboxMobileNum;
        private Label lblHouseNo;
        private Label lblStreet;
        private TextBox txtboxStreet;
        private Label lblVillageSubd;
        private TextBox txtboxVillageSubd;
        private Label lblBrgy;
        private TextBox txtboxBrgy;
        private Label lblCityProvince;
        private TextBox txtboxCityProvince;
        private ComboBox cmboxMedHistory;
        private Button btnCONFIRMFORM;
        private Label lblOthersMedHistory;
        private TextBox txtboxOthersMedHistory;
    }
}