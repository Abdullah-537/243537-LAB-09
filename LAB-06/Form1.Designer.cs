namespace LAB_06
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtName = new TextBox();
            button1 = new Button();
            lblName = new Label();
            lblAge = new Label();
            lblDepart = new Label();
            cbDeprt = new ComboBox();
            lblReg = new Label();
            txtRoll = new TextBox();
            lblCNIC = new Label();
            button2 = new Button();
            button3 = new Button();
            txtFather = new TextBox();
            label1 = new Label();
            DTPdob = new DateTimePicker();
            cbinter = new ComboBox();
            cbMat = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAddress = new TextBox();
            txtCNIC = new TextBox();
            label5 = new Label();
            rbmale = new RadioButton();
            rbFemale = new RadioButton();
            label6 = new Label();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            ViewStudents = new DataGridView();
            label7 = new Label();
            Back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ViewStudents).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.LightCoral;
            txtName.Location = new Point(212, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Maroon;
            button1.Location = new Point(194, 384);
            button1.Name = "button1";
            button1.Size = new Size(118, 54);
            button1.TabIndex = 2;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Maroon;
            lblName.Location = new Point(212, 48);
            lblName.Name = "lblName";
            lblName.Size = new Size(77, 30);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.ForeColor = Color.Maroon;
            lblAge.Location = new Point(212, 111);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(144, 30);
            lblAge.TabIndex = 5;
            lblAge.Text = "Father Name:";
            // 
            // lblDepart
            // 
            lblDepart.AutoSize = true;
            lblDepart.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDepart.ForeColor = Color.Maroon;
            lblDepart.Location = new Point(212, 191);
            lblDepart.Name = "lblDepart";
            lblDepart.Size = new Size(181, 30);
            lblDepart.TabIndex = 6;
            lblDepart.Text = "Degrree Program";
            // 
            // cbDeprt
            // 
            cbDeprt.BackColor = Color.LightCoral;
            cbDeprt.FormattingEnabled = true;
            cbDeprt.Items.AddRange(new object[] { "BS Computer Science", "BS Artificial intelligence", "BS Software Engineering", "BS Cyber Security", "BS Data Science", "BS Mathematics" });
            cbDeprt.Location = new Point(212, 224);
            cbDeprt.Name = "cbDeprt";
            cbDeprt.Size = new Size(121, 23);
            cbDeprt.TabIndex = 7;
            // 
            // lblReg
            // 
            lblReg.AutoSize = true;
            lblReg.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReg.ForeColor = Color.Maroon;
            lblReg.Location = new Point(475, 51);
            lblReg.Name = "lblReg";
            lblReg.Size = new Size(92, 30);
            lblReg.TabIndex = 8;
            lblReg.Text = "Reg No:";
            // 
            // txtRoll
            // 
            txtRoll.BackColor = Color.LightCoral;
            txtRoll.Location = new Point(475, 84);
            txtRoll.Name = "txtRoll";
            txtRoll.Size = new Size(100, 23);
            txtRoll.TabIndex = 9;
            // 
            // lblCNIC
            // 
            lblCNIC.AutoSize = true;
            lblCNIC.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCNIC.ForeColor = Color.Maroon;
            lblCNIC.Location = new Point(475, 110);
            lblCNIC.Name = "lblCNIC";
            lblCNIC.Size = new Size(69, 30);
            lblCNIC.TabIndex = 11;
            lblCNIC.Text = "CNIC:";
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Maroon;
            button2.Location = new Point(318, 384);
            button2.Name = "button2";
            button2.Size = new Size(118, 54);
            button2.TabIndex = 12;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCoral;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Maroon;
            button3.Location = new Point(442, 384);
            button3.Name = "button3";
            button3.Size = new Size(118, 54);
            button3.TabIndex = 13;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txtFather
            // 
            txtFather.BackColor = Color.LightCoral;
            txtFather.Location = new Point(212, 144);
            txtFather.Name = "txtFather";
            txtFather.Size = new Size(100, 23);
            txtFather.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(475, 169);
            label1.Name = "label1";
            label1.Size = new Size(63, 30);
            label1.TabIndex = 15;
            label1.Text = "DOB:";
            // 
            // DTPdob
            // 
            DTPdob.Location = new Point(475, 202);
            DTPdob.MaxDate = new DateTime(2010, 12, 31, 0, 0, 0, 0);
            DTPdob.Name = "DTPdob";
            DTPdob.Size = new Size(200, 23);
            DTPdob.TabIndex = 16;
            DTPdob.Value = new DateTime(2010, 12, 31, 0, 0, 0, 0);
            // 
            // cbinter
            // 
            cbinter.BackColor = Color.LightCoral;
            cbinter.FormattingEnabled = true;
            cbinter.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            cbinter.Location = new Point(475, 261);
            cbinter.Name = "cbinter";
            cbinter.Size = new Size(121, 23);
            cbinter.TabIndex = 17;
            // 
            // cbMat
            // 
            cbMat.BackColor = Color.LightCoral;
            cbMat.FormattingEnabled = true;
            cbMat.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            cbMat.Location = new Point(212, 345);
            cbMat.Name = "cbMat";
            cbMat.Size = new Size(121, 23);
            cbMat.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(475, 228);
            label2.Name = "label2";
            label2.Size = new Size(124, 30);
            label2.TabIndex = 19;
            label2.Text = "Inter Grade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(212, 312);
            label3.Name = "label3";
            label3.Size = new Size(146, 30);
            label3.TabIndex = 20;
            label3.Text = "Matric Grade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(212, 250);
            label4.Name = "label4";
            label4.Size = new Size(91, 30);
            label4.TabIndex = 21;
            label4.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.LightCoral;
            txtAddress.Location = new Point(212, 283);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 22;
            // 
            // txtCNIC
            // 
            txtCNIC.BackColor = Color.LightCoral;
            txtCNIC.Location = new Point(475, 143);
            txtCNIC.Name = "txtCNIC";
            txtCNIC.Size = new Size(113, 23);
            txtCNIC.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(475, 287);
            label5.Name = "label5";
            label5.Size = new Size(91, 30);
            label5.TabIndex = 24;
            label5.Text = "Gender:";
            // 
            // rbmale
            // 
            rbmale.AutoSize = true;
            rbmale.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbmale.ForeColor = Color.Maroon;
            rbmale.Location = new Point(478, 320);
            rbmale.Name = "rbmale";
            rbmale.Size = new Size(97, 36);
            rbmale.TabIndex = 25;
            rbmale.TabStop = true;
            rbmale.Text = "MALE";
            rbmale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbFemale.ForeColor = Color.Maroon;
            rbFemale.Location = new Point(581, 320);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(112, 36);
            rbFemale.TabIndex = 26;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(245, 13);
            label6.Name = "label6";
            label6.Size = new Size(284, 30);
            label6.TabIndex = 27;
            label6.Text = "Student Registration Form";
            // 
            // button4
            // 
            button4.BackColor = Color.LightCoral;
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Maroon;
            button4.Location = new Point(566, 384);
            button4.Name = "button4";
            button4.Size = new Size(118, 54);
            button4.TabIndex = 28;
            button4.Text = "Select";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 326);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // ViewStudents
            // 
            ViewStudents.BackgroundColor = Color.PeachPuff;
            ViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewStudents.Location = new Point(0, 81);
            ViewStudents.Name = "ViewStudents";
            ViewStudents.Size = new Size(811, 309);
            ViewStudents.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(332, 51);
            label7.Name = "label7";
            label7.Size = new Size(106, 30);
            label7.TabIndex = 31;
            label7.Text = "Data Grid";
            // 
            // Back
            // 
            Back.BackColor = Color.LightCoral;
            Back.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.Maroon;
            Back.Location = new Point(12, 21);
            Back.Name = "Back";
            Back.Size = new Size(118, 54);
            Back.TabIndex = 32;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = false;
            Back.Click += Back_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(Back);
            Controls.Add(label7);
            Controls.Add(ViewStudents);
            Controls.Add(pictureBox1);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(rbFemale);
            Controls.Add(rbmale);
            Controls.Add(label5);
            Controls.Add(txtCNIC);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbMat);
            Controls.Add(cbinter);
            Controls.Add(DTPdob);
            Controls.Add(label1);
            Controls.Add(txtFather);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(lblCNIC);
            Controls.Add(txtRoll);
            Controls.Add(lblReg);
            Controls.Add(cbDeprt);
            Controls.Add(lblDepart);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(button1);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Button button1;
        private Label lblName;
        private NumericUpDown NUDage;
        private Label lblAge;
        private Label lblDepart;
        private ComboBox cbDeprt;
        private Label lblReg;
        private TextBox txtRoll;
        private Label lblCNIC;
        private Button button2;
        private Button button3;
        private TextBox txtFather;
        private Label label1;
        private DateTimePicker DTPdob;
        private ComboBox cbinter;
        private ComboBox cbMat;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAddress;
        private TextBox txtCNIC;
        private Label label5;
        private RadioButton rbmale;
        private RadioButton rbFemale;
        private Label label6;
        private Button button4;
        private PictureBox pictureBox1;
        private DataGridView ViewStudents;
        private Label label7;
        private Button Back;
    }
}
