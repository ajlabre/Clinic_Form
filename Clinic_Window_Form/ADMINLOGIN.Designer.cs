namespace Clinic_Window_Form
{
    partial class ADMINLOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMINLOGIN));
            ClinicImage = new PictureBox();
            lblConsultationForm = new Label();
            lblusername = new Label();
            lblPIN = new Label();
            txtboxUsername = new TextBox();
            txtboxPin = new TextBox();
            btnCONFIRMADMIN = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)ClinicImage).BeginInit();
            SuspendLayout();
            // 
            // ClinicImage
            // 
            ClinicImage.Image = (Image)resources.GetObject("ClinicImage.Image");
            ClinicImage.Location = new Point(11, 12);
            ClinicImage.Name = "ClinicImage";
            ClinicImage.Size = new Size(57, 61);
            ClinicImage.TabIndex = 10;
            ClinicImage.TabStop = false;
            // 
            // lblConsultationForm
            // 
            lblConsultationForm.AutoSize = true;
            lblConsultationForm.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsultationForm.ForeColor = Color.DarkBlue;
            lblConsultationForm.Location = new Point(74, 21);
            lblConsultationForm.Name = "lblConsultationForm";
            lblConsultationForm.Size = new Size(464, 33);
            lblConsultationForm.TabIndex = 9;
            lblConsultationForm.Text = "CLINIC CONSULTATION FORM";
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.BackColor = SystemColors.GradientInactiveCaption;
            lblusername.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblusername.Location = new Point(74, 76);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(124, 25);
            lblusername.TabIndex = 11;
            lblusername.Text = "USERNAME:";
            lblusername.Click += qstnAdmin_Click;
            // 
            // lblPIN
            // 
            lblPIN.AutoSize = true;
            lblPIN.BackColor = SystemColors.GradientInactiveCaption;
            lblPIN.Font = new Font("Cambria", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPIN.Location = new Point(74, 128);
            lblPIN.Name = "lblPIN";
            lblPIN.Size = new Size(52, 25);
            lblPIN.TabIndex = 12;
            lblPIN.Text = "PIN:";
            // 
            // txtboxUsername
            // 
            txtboxUsername.Location = new Point(219, 73);
            txtboxUsername.Name = "txtboxUsername";
            txtboxUsername.Size = new Size(216, 23);
            txtboxUsername.TabIndex = 13;
            txtboxUsername.TextChanged += txtboxUsername_TextChanged;
            // 
            // txtboxPin
            // 
            txtboxPin.Location = new Point(219, 128);
            txtboxPin.Name = "txtboxPin";
            txtboxPin.Size = new Size(216, 23);
            txtboxPin.TabIndex = 14;
            txtboxPin.TextChanged += txtboxPin_TextChanged;
            // 
            // btnCONFIRMADMIN
            // 
            btnCONFIRMADMIN.BackColor = SystemColors.GradientActiveCaption;
            btnCONFIRMADMIN.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCONFIRMADMIN.ForeColor = SystemColors.ControlText;
            btnCONFIRMADMIN.Location = new Point(403, 165);
            btnCONFIRMADMIN.Name = "btnCONFIRMADMIN";
            btnCONFIRMADMIN.Size = new Size(143, 30);
            btnCONFIRMADMIN.TabIndex = 34;
            btnCONFIRMADMIN.Text = "CONFIRM";
            btnCONFIRMADMIN.UseVisualStyleBackColor = false;
            btnCONFIRMADMIN.Click += btnCONFIRMADMIN_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.GradientActiveCaption;
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ControlText;
            btnCancel.Location = new Point(22, 165);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(143, 30);
            btnCancel.TabIndex = 44;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // ADMINLOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(558, 207);
            Controls.Add(btnCancel);
            Controls.Add(btnCONFIRMADMIN);
            Controls.Add(txtboxPin);
            Controls.Add(txtboxUsername);
            Controls.Add(lblPIN);
            Controls.Add(lblusername);
            Controls.Add(ClinicImage);
            Controls.Add(lblConsultationForm);
            Name = "ADMINLOGIN";
            Text = "ADMINLOGIN";
            Load += ADMINLOGIN_Load;
            ((System.ComponentModel.ISupportInitialize)ClinicImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ClinicImage;
        private Label lblConsultationForm;
        private Label lblusername;
        private Label lblPIN;
        private TextBox txtboxUsername;
        private TextBox txtboxPin;
        private Button btnCONFIRMADMIN;
        private Button btnCancel;
    }
}