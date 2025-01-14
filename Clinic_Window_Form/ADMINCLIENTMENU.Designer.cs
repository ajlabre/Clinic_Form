
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            qstnAdmin = new Label();
            btnVIEW = new Button();
            btnREGISTER = new Button();
            qstnClient = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 61);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Book", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(77, 25);
            label1.Name = "label1";
            label1.Size = new Size(401, 37);
            label1.TabIndex = 7;
            label1.Text = "CLINIC CONSULTATION FORM";
            // 
            // qstnAdmin
            // 
            qstnAdmin.AutoSize = true;
            qstnAdmin.BackColor = SystemColors.GradientInactiveCaption;
            qstnAdmin.Font = new Font("Cambria", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            qstnAdmin.Location = new Point(75, 143);
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
            btnVIEW.Location = new Point(66, 98);
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
            btnREGISTER.Location = new Point(305, 98);
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
            qstnClient.Location = new Point(317, 143);
            qstnClient.Name = "qstnClient";
            qstnClient.Size = new Size(129, 17);
            qstnClient.TabIndex = 11;
            qstnClient.Text = "\"Are you a Client?\"";
            qstnClient.Click += qstnClient_Click;
            // 
            // ADMINCLIENTMENU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(517, 214);
            Controls.Add(btnREGISTER);
            Controls.Add(qstnClient);
            Controls.Add(btnVIEW);
            Controls.Add(qstnAdmin);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ADMINCLIENTMENU";
            Text = "MAIN MENU ";
            Load += ADMINCLIENTMENU_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label qstnAdmin;
        private Button btnVIEW;
        private Button btnREGISTER;
        private Label qstnClient;
    }
}