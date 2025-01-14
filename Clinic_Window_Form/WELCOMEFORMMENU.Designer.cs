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
            label3 = new Label();
            label2 = new Label();
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
            label1.Font = new Font("Franklin Gothic Book", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(75, 20);
            label1.Name = "label1";
            label1.Size = new Size(401, 37);
            label1.TabIndex = 7;
            label1.Text = "CLINIC CONSULTATION FORM";
            // 
            // btnNEXTMAINMENU
            // 
            btnNEXTMAINMENU.BackColor = SystemColors.GradientActiveCaption;
            btnNEXTMAINMENU.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNEXTMAINMENU.Location = new Point(301, 101);
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
            btnCANCELMAINMENU.Location = new Point(301, 173);
            btnCANCELMAINMENU.Name = "btnCANCELMAINMENU";
            btnCANCELMAINMENU.Size = new Size(155, 48);
            btnCANCELMAINMENU.TabIndex = 10;
            btnCANCELMAINMENU.Text = "CANCEL";
            btnCANCELMAINMENU.UseVisualStyleBackColor = false;
            btnCANCELMAINMENU.Click += btnCANCELMAINMENU_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Cambria", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(20, 115);
            label3.Name = "label3";
            label3.Size = new Size(275, 22);
            label3.TabIndex = 11;
            label3.Text = "NEXT to register a consultation";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Cambria", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(20, 187);
            label2.Name = "label2";
            label2.Size = new Size(218, 22);
            label2.TabIndex = 12;
            label2.Text = "CANCEL the consultation";
            label2.Click += label2_Click;
            // 
            // WELCOMEFORMMENU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(499, 261);
            Controls.Add(label2);
            Controls.Add(label3);
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
        private Label label3;
        private Label label2;
    }
}