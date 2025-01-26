namespace Clinic_Window_Form
{
    partial class VIEWFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VIEWFORM));
            ClinicImage = new PictureBox();
            lblClinicConsultationForm = new Label();
            Calendar = new MonthCalendar();
            dataGridView1 = new DataGridView();
            btnMainMenu = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            txtboxOthersMedHistory = new DataGridViewTextBoxColumn();
            cmboxMedHistory = new DataGridViewComboBoxColumn();
            txtboxMobileNum = new DataGridViewTextBoxColumn();
            txtboxEmailAdd = new DataGridViewTextBoxColumn();
            DatePickerBirthdate = new DataGridViewTextBoxColumn();
            cmbGender = new DataGridViewButtonColumn();
            txtboxBrgy = new DataGridViewTextBoxColumn();
            txtboxStreet = new DataGridViewTextBoxColumn();
            txtboxVillageSubd = new DataGridViewTextBoxColumn();
            txtboxHouseNo = new DataGridViewTextBoxColumn();
            txtboxFullName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ClinicImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ClinicImage
            // 
            ClinicImage.Image = (Image)resources.GetObject("ClinicImage.Image");
            ClinicImage.Location = new Point(20, 17);
            ClinicImage.Name = "ClinicImage";
            ClinicImage.Size = new Size(57, 61);
            ClinicImage.TabIndex = 8;
            ClinicImage.TabStop = false;
            // 
            // lblClinicConsultationForm
            // 
            lblClinicConsultationForm.AutoSize = true;
            lblClinicConsultationForm.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClinicConsultationForm.ForeColor = Color.DarkBlue;
            lblClinicConsultationForm.Location = new Point(83, 26);
            lblClinicConsultationForm.Name = "lblClinicConsultationForm";
            lblClinicConsultationForm.Size = new Size(464, 33);
            lblClinicConsultationForm.TabIndex = 7;
            lblClinicConsultationForm.Text = "CLINIC CONSULTATION FORM";
            // 
            // Calendar
            // 
            Calendar.Location = new Point(559, 18);
            Calendar.Name = "Calendar";
            Calendar.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { txtboxFullName, txtboxHouseNo, txtboxVillageSubd, txtboxStreet, txtboxBrgy, cmbGender, DatePickerBirthdate, txtboxEmailAdd, txtboxMobileNum, cmboxMedHistory, txtboxOthersMedHistory });
            dataGridView1.GridColor = SystemColors.MenuHighlight;
            dataGridView1.Location = new Point(20, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(519, 320);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnMainMenu
            // 
            btnMainMenu.BackColor = SystemColors.GradientActiveCaption;
            btnMainMenu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnMainMenu.ForeColor = SystemColors.ControlText;
            btnMainMenu.Location = new Point(559, 192);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(227, 30);
            btnMainMenu.TabIndex = 34;
            btnMainMenu.Text = "MAIN MENU";
            btnMainMenu.UseVisualStyleBackColor = false;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.GradientActiveCaption;
            btnEdit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.ControlText;
            btnEdit.Location = new Point(559, 361);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(102, 30);
            btnEdit.TabIndex = 35;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.GradientActiveCaption;
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.ControlText;
            btnDelete.Location = new Point(559, 397);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 30);
            btnDelete.TabIndex = 36;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtboxOthersMedHistory
            // 
            txtboxOthersMedHistory.HeaderText = "OthersMedHistory";
            txtboxOthersMedHistory.Name = "txtboxOthersMedHistory";
            // 
            // cmboxMedHistory
            // 
            cmboxMedHistory.HeaderText = "MedHistory";
            cmboxMedHistory.Name = "cmboxMedHistory";
            cmboxMedHistory.Resizable = DataGridViewTriState.True;
            cmboxMedHistory.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // txtboxMobileNum
            // 
            txtboxMobileNum.HeaderText = "MobileNum";
            txtboxMobileNum.Name = "txtboxMobileNum";
            // 
            // txtboxEmailAdd
            // 
            txtboxEmailAdd.HeaderText = "Email";
            txtboxEmailAdd.Name = "txtboxEmailAdd";
            // 
            // DatePickerBirthdate
            // 
            DatePickerBirthdate.HeaderText = "Birthdate";
            DatePickerBirthdate.Name = "DatePickerBirthdate";
            // 
            // cmbGender
            // 
            cmbGender.HeaderText = "Gender";
            cmbGender.Name = "cmbGender";
            // 
            // txtboxBrgy
            // 
            txtboxBrgy.HeaderText = "Brgy";
            txtboxBrgy.Name = "txtboxBrgy";
            // 
            // txtboxStreet
            // 
            txtboxStreet.HeaderText = "Street";
            txtboxStreet.Name = "txtboxStreet";
            // 
            // txtboxVillageSubd
            // 
            txtboxVillageSubd.HeaderText = "VillageSubd";
            txtboxVillageSubd.Name = "txtboxVillageSubd";
            // 
            // txtboxHouseNo
            // 
            txtboxHouseNo.HeaderText = "HouseNo";
            txtboxHouseNo.Name = "txtboxHouseNo";
            // 
            // txtboxFullName
            // 
            txtboxFullName.HeaderText = "FullName";
            txtboxFullName.Name = "txtboxFullName";
            // 
            // VIEWFORM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnMainMenu);
            Controls.Add(dataGridView1);
            Controls.Add(Calendar);
            Controls.Add(ClinicImage);
            Controls.Add(lblClinicConsultationForm);
            Name = "VIEWFORM";
            Text = "VIEWFORM";
            Load += VIEWFORM_Load;
            ((System.ComponentModel.ISupportInitialize)ClinicImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ClinicImage;
        private Label lblClinicConsultationForm;
        private MonthCalendar Calendar;
        private DataGridView dataGridView1;
        private Button btnMainMenu;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridViewTextBoxColumn txtboxFullName;
        private DataGridViewTextBoxColumn txtboxHouseNo;
        private DataGridViewTextBoxColumn txtboxVillageSubd;
        private DataGridViewTextBoxColumn txtboxStreet;
        private DataGridViewTextBoxColumn txtboxBrgy;
        private DataGridViewButtonColumn cmbGender;
        private DataGridViewTextBoxColumn DatePickerBirthdate;
        private DataGridViewTextBoxColumn txtboxEmailAdd;
        private DataGridViewTextBoxColumn txtboxMobileNum;
        private DataGridViewComboBoxColumn cmboxMedHistory;
        private DataGridViewTextBoxColumn txtboxOthersMedHistory;
    }
}