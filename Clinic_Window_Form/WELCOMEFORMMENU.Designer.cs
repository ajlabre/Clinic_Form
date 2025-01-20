namespace Clinic_Window_Form
{
    partial class WELCOMEFORMMENU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WELCOMEFORMMENU));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnNEXTMAINMENU = new Button();
            btnCANCELMAINMENU = new Button();
            lblCancel = new Label();
            lblNext = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 61);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(75, 20);
            label1.Name = "label1";
            label1.Size = new Size(464, 33);
            label1.TabIndex = 7;
            label1.Text = "CLINIC CONSULTATION FORM";
            // 
            // btnNEXTMAINMENU
            // 
            btnNEXTMAINMENU.BackColor = SystemColors.GradientActiveCaption;
            btnNEXTMAINMENU.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNEXTMAINMENU.Location = new Point(338, 101);
            btnNEXTMAINMENU.Name = "btnNEXTMAINMENU";
            btnNEXTMAINMENU.Size = new Size(156, 48);
            btnNEXTMAINMENU.TabIndex = 9;
            btnNEXTMAINMENU.Text = "NEXT";
            btnNEXTMAINMENU.UseVisualStyleBackColor = false;
            btnNEXTMAINMENU.Click += btnNEXTMAINMENU_Click;
            // 
            // btnCANCELMAINMENU
            // 
            btnCANCELMAINMENU.BackColor = SystemColors.GradientActiveCaption;
            btnCANCELMAINMENU.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCANCELMAINMENU.Location = new Point(338, 173);
            btnCANCELMAINMENU.Name = "btnCANCELMAINMENU";
            btnCANCELMAINMENU.Size = new Size(155, 48);
            btnCANCELMAINMENU.TabIndex = 10;
            btnCANCELMAINMENU.Text = "CANCEL";
            btnCANCELMAINMENU.UseVisualStyleBackColor = false;
            btnCANCELMAINMENU.Click += btnCANCELMAINMENU_Click;
            // 
            // lblCancel
            // 
            lblCancel.AutoSize = true;
            lblCancel.BackColor = SystemColors.GradientInactiveCaption;
            lblCancel.Font = new Font("Cambria", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCancel.ForeColor = SystemColors.ControlText;
            lblCancel.Location = new Point(58, 187);
            lblCancel.Name = "lblCancel";
            lblCancel.Size = new Size(218, 22);
            lblCancel.TabIndex = 14;
            lblCancel.Text = "CANCEL the consultation";
            lblCancel.Click += lblCancel_Click;
            // 
            // lblNext
            // 
            lblNext.AutoSize = true;
            lblNext.BackColor = SystemColors.GradientInactiveCaption;
            lblNext.Font = new Font("Cambria", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNext.ForeColor = SystemColors.ControlText;
            lblNext.Location = new Point(58, 115);
            lblNext.Name = "lblNext";
            lblNext.Size = new Size(275, 22);
            lblNext.TabIndex = 13;
            lblNext.Text = "NEXT to register a consultation";
            lblNext.Click += lblNext_Click;
            // 
            // WELCOMEFORMMENU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(550, 261);
            Controls.Add(lblCancel);
            Controls.Add(lblNext);
            Controls.Add(btnCANCELMAINMENU);
            Controls.Add(btnNEXTMAINMENU);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "WELCOMEFORMMENU";
            Text = "WELCOME FORM";
            Load += WELCOMEFORMMENU_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnNEXTMAINMENU;
        private Button btnCANCELMAINMENU;
        private Label lblCancel;
        private Label lblNext;
    }
}