namespace Clinic_Window_Form
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            btnVIEWFORM = new Button();
            btnMAINMENU = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 61);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Book", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(95, 36);
            label1.Name = "label1";
            label1.Size = new Size(401, 37);
            label1.TabIndex = 8;
            label1.Text = "CLINIC CONSULTATION FORM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Cambria", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(41, 128);
            label3.Name = "label3";
            label3.Size = new Size(515, 22);
            label3.TabIndex = 9;
            label3.Text = "Thank you for filling the form. Proceed to wait for your turn";
            label3.Click += label3_Click;
            // 
            // btnVIEWFORM
            // 
            btnVIEWFORM.BackColor = SystemColors.GradientActiveCaption;
            btnVIEWFORM.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnVIEWFORM.Location = new Point(409, 185);
            btnVIEWFORM.Name = "btnVIEWFORM";
            btnVIEWFORM.Size = new Size(147, 33);
            btnVIEWFORM.TabIndex = 10;
            btnVIEWFORM.Text = "VIEW FORM";
            btnVIEWFORM.UseVisualStyleBackColor = false;
            // 
            // btnMAINMENU
            // 
            btnMAINMENU.BackColor = SystemColors.GradientActiveCaption;
            btnMAINMENU.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnMAINMENU.Location = new Point(235, 185);
            btnMAINMENU.Name = "btnMAINMENU";
            btnMAINMENU.Size = new Size(152, 33);
            btnMAINMENU.TabIndex = 11;
            btnMAINMENU.Text = "MAIN MENU";
            btnMAINMENU.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(588, 241);
            Controls.Add(btnMAINMENU);
            Controls.Add(btnVIEWFORM);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "THANK YOU FOR FILLING THE FORM.";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Button btnVIEWFORM;
        private Button btnMAINMENU;
    }
}