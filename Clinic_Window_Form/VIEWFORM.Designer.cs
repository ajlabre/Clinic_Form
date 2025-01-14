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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            monthCalendar1 = new MonthCalendar();
            label3 = new Label();
            button1 = new Button();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 61);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Book", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(79, 22);
            label1.Name = "label1";
            label1.Size = new Size(401, 37);
            label1.TabIndex = 5;
            label1.Text = "CLINIC CONSULTATION FORM";
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.Window;
            monthCalendar1.Location = new Point(564, 13);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Cambria", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(16, 86);
            label3.Name = "label3";
            label3.Size = new Size(224, 22);
            label3.TabIndex = 10;
            label3.Text = "CONSULTATION RECORDS";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(640, 187);
            button1.Name = "button1";
            button1.Size = new Size(148, 34);
            button1.TabIndex = 11;
            button1.Text = "MAIN MENU";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(21, 124);
            listView1.Name = "listView1";
            listView1.Size = new Size(531, 304);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // VIEWFORM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(monthCalendar1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "VIEWFORM";
            Text = "CONSULTATION REPORT";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private MonthCalendar monthCalendar1;
        private Label label3;
        private Button button1;
        private ListView listView1;
    }
}