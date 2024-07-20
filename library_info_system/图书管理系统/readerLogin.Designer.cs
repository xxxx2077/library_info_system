namespace 图书管理系统
{
    partial class readerLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(readerLogIn));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.employeeRadioButton2 = new System.Windows.Forms.RadioButton();
            this.teacherRadioButton = new System.Windows.Forms.RadioButton();
            this.passwordModificationButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.logInButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.number_label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.registerButton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.passwordModificationButton);
            this.groupBox1.Controls.Add(this.CancelButton);
            this.groupBox1.Controls.Add(this.logInButton);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.number_label);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("宋体", 9F);
            this.registerButton.Location = new System.Drawing.Point(312, 206);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(93, 28);
            this.registerButton.TabIndex = 12;
            this.registerButton.Text = "注册";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("宋体", 9F);
            this.textBox1.Location = new System.Drawing.Point(312, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(93, 28);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "还没注册？";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.studentRadioButton);
            this.panel1.Controls.Add(this.employeeRadioButton2);
            this.panel1.Controls.Add(this.teacherRadioButton);
            this.panel1.Location = new System.Drawing.Point(84, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 65);
            this.panel1.TabIndex = 10;
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.Checked = true;
            this.studentRadioButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.studentRadioButton.Location = new System.Drawing.Point(3, 26);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(71, 22);
            this.studentRadioButton.TabIndex = 7;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "学生";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            this.studentRadioButton.CheckedChanged += new System.EventHandler(this.studentRadioButton_CheckedChanged);
            // 
            // employeeRadioButton2
            // 
            this.employeeRadioButton2.AutoSize = true;
            this.employeeRadioButton2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.employeeRadioButton2.Location = new System.Drawing.Point(151, 26);
            this.employeeRadioButton2.Name = "employeeRadioButton2";
            this.employeeRadioButton2.Size = new System.Drawing.Size(71, 22);
            this.employeeRadioButton2.TabIndex = 8;
            this.employeeRadioButton2.TabStop = true;
            this.employeeRadioButton2.Text = "职工";
            this.employeeRadioButton2.UseVisualStyleBackColor = true;
            this.employeeRadioButton2.CheckedChanged += new System.EventHandler(this.employeeRadioButton2_CheckedChanged);
            // 
            // teacherRadioButton
            // 
            this.teacherRadioButton.AutoSize = true;
            this.teacherRadioButton.Location = new System.Drawing.Point(74, 26);
            this.teacherRadioButton.Name = "teacherRadioButton";
            this.teacherRadioButton.Size = new System.Drawing.Size(71, 22);
            this.teacherRadioButton.TabIndex = 9;
            this.teacherRadioButton.TabStop = true;
            this.teacherRadioButton.Text = "教师";
            this.teacherRadioButton.UseVisualStyleBackColor = true;
            this.teacherRadioButton.CheckedChanged += new System.EventHandler(this.teacherRadioButton_CheckedChanged);
            // 
            // passwordModificationButton
            // 
            this.passwordModificationButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordModificationButton.Location = new System.Drawing.Point(192, 262);
            this.passwordModificationButton.Name = "passwordModificationButton";
            this.passwordModificationButton.Size = new System.Drawing.Size(100, 39);
            this.passwordModificationButton.TabIndex = 6;
            this.passwordModificationButton.Text = "修改密码";
            this.passwordModificationButton.UseVisualStyleBackColor = true;
            this.passwordModificationButton.Click += new System.EventHandler(this.passwordModificationButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CancelButton.Location = new System.Drawing.Point(319, 262);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(84, 39);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // logInButton
            // 
            this.logInButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logInButton.Location = new System.Drawing.Point(68, 262);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(94, 39);
            this.logInButton.TabIndex = 4;
            this.logInButton.Text = "登录";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(192, 125);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(211, 28);
            this.passwordTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(192, 67);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(211, 28);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(80, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户密码：";
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.number_label.Location = new System.Drawing.Point(80, 67);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(67, 22);
            this.number_label.TabIndex = 0;
            this.number_label.Text = "学号：";
            this.number_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // readerLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 346);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "readerLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.Button passwordModificationButton;
        private System.Windows.Forms.RadioButton employeeRadioButton2;
        private System.Windows.Forms.RadioButton studentRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton teacherRadioButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}