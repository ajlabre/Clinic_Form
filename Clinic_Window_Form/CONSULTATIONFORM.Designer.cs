namespace Clinic_Window_Form
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox6 = new TextBox();
            label11 = new Label();
            textBox7 = new TextBox();
            label12 = new Label();
            textBox8 = new TextBox();
            label13 = new Label();
            textBox9 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label14 = new Label();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 61);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Book", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(75, 21);
            label1.Name = "label1";
            label1.Size = new Size(401, 37);
            label1.TabIndex = 5;
            label1.Text = "CLINIC CONSULTATION FORM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Cambria", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(30, 101);
            label3.Name = "label3";
            label3.Size = new Size(105, 22);
            label3.TabIndex = 8;
            label3.Text = "Full Name: ";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Cambria", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(30, 155);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 9;
            label2.Text = "Address: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Cambria", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(30, 300);
            label4.Name = "label4";
            label4.Size = new Size(102, 22);
            label4.TabIndex = 10;
            label4.Text = "Birthdate: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientInactiveCaption;
            label5.Font = new Font("Cambria", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(30, 350);
            label5.Name = "label5";
            label5.Size = new Size(80, 22);
            label5.TabIndex = 11;
            label5.Text = "Gender: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientInactiveCaption;
            label6.Font = new Font("Cambria", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(30, 397);
            label6.Name = "label6";
            label6.Size = new Size(141, 22);
            label6.TabIndex = 12;
            label6.Text = "Email Address: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientInactiveCaption;
            label7.Font = new Font("Cambria", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(30, 447);
            label7.Name = "label7";
            label7.Size = new Size(150, 22);
            label7.TabIndex = 13;
            label7.Text = "Mobile Number: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.GradientInactiveCaption;
            label8.Font = new Font("Cambria", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(30, 495);
            label8.Name = "label8";
            label8.Size = new Size(150, 22);
            label8.TabIndex = 14;
            label8.Text = "Medical History:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            radioButton1.ForeColor = Color.Black;
            radioButton1.Location = new Point(188, 350);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(86, 25);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "FEMALE";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            radioButton2.ForeColor = Color.Black;
            radioButton2.Location = new Point(302, 350);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 25);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "MALE";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.CalendarMonthBackground = SystemColors.GradientActiveCaption;
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(188, 293);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(261, 29);
            dateTimePicker1.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(188, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 23);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 23);
            textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(188, 397);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(261, 23);
            textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(188, 447);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(261, 23);
            textBox4.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.GradientInactiveCaption;
            label9.Font = new Font("Cambria", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(123, 162);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 23;
            label9.Text = "HOUSE NO.";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.GradientInactiveCaption;
            label10.Font = new Font("Cambria", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(393, 162);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 25;
            label10.Text = "STREET";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(466, 155);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(157, 23);
            textBox6.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.GradientInactiveCaption;
            label11.Font = new Font("Cambria", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(97, 203);
            label11.Name = "label11";
            label11.Size = new Size(97, 15);
            label11.TabIndex = 27;
            label11.Text = "VILLAGE/SUBD.";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(200, 200);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(157, 23);
            textBox7.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.GradientInactiveCaption;
            label12.Font = new Font("Cambria", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(379, 203);
            label12.Name = "label12";
            label12.Size = new Size(70, 15);
            label12.TabIndex = 29;
            label12.Text = "BARANGAY";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(466, 200);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(157, 23);
            textBox8.TabIndex = 28;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.GradientInactiveCaption;
            label13.Font = new Font("Cambria", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(95, 249);
            label13.Name = "label13";
            label13.Size = new Size(99, 15);
            label13.TabIndex = 31;
            label13.Text = "CITY/PROVINCE";
            label13.Click += label13_Click;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(200, 246);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(157, 23);
            textBox9.TabIndex = 30;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Asthma", "Hypertension", "Diabetes", "Heart Disease", "Cancer " });
            comboBox1.Location = new Point(188, 495);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 23);
            comboBox1.TabIndex = 32;
            comboBox1.Text = "Please Select.";
            comboBox1.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(477, 559);
            button1.Name = "button1";
            button1.Size = new Size(143, 30);
            button1.TabIndex = 33;
            button1.Text = "CONFIRM";
            button1.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.GradientInactiveCaption;
            label14.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ControlText;
            label14.Location = new Point(188, 545);
            label14.Name = "label14";
            label14.Size = new Size(57, 19);
            label14.TabIndex = 34;
            label14.Text = "Others:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(251, 541);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(198, 23);
            textBox5.TabIndex = 35;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(654, 627);
            Controls.Add(textBox5);
            Controls.Add(label14);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label13);
            Controls.Add(textBox9);
            Controls.Add(label12);
            Controls.Add(textBox8);
            Controls.Add(label11);
            Controls.Add(textBox7);
            Controls.Add(label10);
            Controls.Add(textBox6);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.GradientActiveCaption;
            Name = "Form2";
            Text = "CONSULTATION FORM";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label9;
        private Label label10;
        private TextBox textBox6;
        private Label label11;
        private TextBox textBox7;
        private Label label12;
        private TextBox textBox8;
        private Label label13;
        private TextBox textBox9;
        private ComboBox comboBox1;
        private Button button1;
        private Label label14;
        private TextBox textBox5;
    }
}