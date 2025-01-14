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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblusername = new Label();
            lblPIN = new Label();
            txtboxUsername = new TextBox();
            txtboxPin = new TextBox();
            btnCONFIRMADMIN = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 61);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Book", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(74, 21);
            label1.Name = "label1";
            label1.Size = new Size(401, 37);
            label1.TabIndex = 9;
            label1.Text = "CLINIC CONSULTATION FORM";
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
            // 
            // txtboxPin
            // 
            txtboxPin.Location = new Point(219, 128);
            txtboxPin.Name = "txtboxPin";
            txtboxPin.Size = new Size(216, 23);
            txtboxPin.TabIndex = 14;
            // 
            // btnCONFIRMADMIN
            // 
            btnCONFIRMADMIN.BackColor = SystemColors.GradientActiveCaption;
            btnCONFIRMADMIN.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCONFIRMADMIN.ForeColor = SystemColors.ControlText;
            btnCONFIRMADMIN.Location = new Point(403, 157);
            btnCONFIRMADMIN.Name = "btnCONFIRMADMIN";
            btnCONFIRMADMIN.Size = new Size(143, 30);
            btnCONFIRMADMIN.TabIndex = 34;
            btnCONFIRMADMIN.Text = "CONFIRM";
            btnCONFIRMADMIN.UseVisualStyleBackColor = false;
            // 
            // ADMINLOGIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(558, 201);
            Controls.Add(btnCONFIRMADMIN);
            Controls.Add(txtboxPin);
            Controls.Add(txtboxUsername);
            Controls.Add(lblPIN);
            Controls.Add(lblusername);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ADMINLOGIN";
            Text = "ADMINLOGIN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label lblusername;
        private Label lblPIN;
        private TextBox txtboxUsername;
        private TextBox txtboxPin;
        private Button btnCONFIRMADMIN;
    }
}