namespace 图书管理系统
{
    partial class readerRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(readerRegister));
            this.registerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.RName_textbox = new System.Windows.Forms.TextBox();
            this.Rtelephone_textbox = new System.Windows.Forms.TextBox();
            this.pwd_textbox1 = new System.Windows.Forms.TextBox();
            this.pwd_textbox2 = new System.Windows.Forms.TextBox();
            this.sex_label = new System.Windows.Forms.Label();
            this.pwd_label1 = new System.Windows.Forms.Label();
            this.identity_label = new System.Windows.Forms.Label();
            this.pwd_label2 = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.SNo_textbox = new System.Windows.Forms.TextBox();
            this.number_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox_pwd1 = new System.Windows.Forms.CheckBox();
            this.checkBox_pwd2 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(115, 377);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(164, 51);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "注册";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(363, 377);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(158, 50);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("宋体", 12F);
            this.name_label.Location = new System.Drawing.Point(111, 33);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(58, 24);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "姓名";
            // 
            // RName_textbox
            // 
            this.RName_textbox.Location = new System.Drawing.Point(238, 29);
            this.RName_textbox.Name = "RName_textbox";
            this.RName_textbox.Size = new System.Drawing.Size(283, 28);
            this.RName_textbox.TabIndex = 3;
            // 
            // Rtelephone_textbox
            // 
            this.Rtelephone_textbox.Location = new System.Drawing.Point(238, 226);
            this.Rtelephone_textbox.MaxLength = 11;
            this.Rtelephone_textbox.Name = "Rtelephone_textbox";
            this.Rtelephone_textbox.Size = new System.Drawing.Size(283, 28);
            this.Rtelephone_textbox.TabIndex = 5;
            // 
            // pwd_textbox1
            // 
            this.pwd_textbox1.Location = new System.Drawing.Point(238, 277);
            this.pwd_textbox1.MaxLength = 16;
            this.pwd_textbox1.Name = "pwd_textbox1";
            this.pwd_textbox1.PasswordChar = '*';
            this.pwd_textbox1.Size = new System.Drawing.Size(171, 28);
            this.pwd_textbox1.TabIndex = 6;
            // 
            // pwd_textbox2
            // 
            this.pwd_textbox2.Location = new System.Drawing.Point(238, 329);
            this.pwd_textbox2.MaxLength = 16;
            this.pwd_textbox2.Name = "pwd_textbox2";
            this.pwd_textbox2.PasswordChar = '*';
            this.pwd_textbox2.Size = new System.Drawing.Size(171, 28);
            this.pwd_textbox2.TabIndex = 7;
            // 
            // sex_label
            // 
            this.sex_label.AutoSize = true;
            this.sex_label.Font = new System.Drawing.Font("宋体", 12F);
            this.sex_label.Location = new System.Drawing.Point(111, 130);
            this.sex_label.Name = "sex_label";
            this.sex_label.Size = new System.Drawing.Size(58, 24);
            this.sex_label.TabIndex = 9;
            this.sex_label.Text = "性别";
            // 
            // pwd_label1
            // 
            this.pwd_label1.AutoSize = true;
            this.pwd_label1.Font = new System.Drawing.Font("宋体", 12F);
            this.pwd_label1.Location = new System.Drawing.Point(111, 277);
            this.pwd_label1.Name = "pwd_label1";
            this.pwd_label1.Size = new System.Drawing.Size(58, 24);
            this.pwd_label1.TabIndex = 10;
            this.pwd_label1.Text = "密码";
            // 
            // identity_label
            // 
            this.identity_label.AutoSize = true;
            this.identity_label.Font = new System.Drawing.Font("宋体", 12F);
            this.identity_label.Location = new System.Drawing.Point(111, 83);
            this.identity_label.Name = "identity_label";
            this.identity_label.Size = new System.Drawing.Size(58, 24);
            this.identity_label.TabIndex = 11;
            this.identity_label.Text = "身份";
            // 
            // pwd_label2
            // 
            this.pwd_label2.AutoSize = true;
            this.pwd_label2.Font = new System.Drawing.Font("宋体", 12F);
            this.pwd_label2.Location = new System.Drawing.Point(111, 329);
            this.pwd_label2.Name = "pwd_label2";
            this.pwd_label2.Size = new System.Drawing.Size(106, 24);
            this.pwd_label2.TabIndex = 12;
            this.pwd_label2.Text = "确认密码";
            // 
            // telephone
            // 
            this.telephone.AutoSize = true;
            this.telephone.Font = new System.Drawing.Font("宋体", 12F);
            this.telephone.Location = new System.Drawing.Point(111, 230);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(106, 24);
            this.telephone.TabIndex = 13;
            this.telephone.Text = "手机号码";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 22);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "男";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(93, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 22);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "女";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(174, 4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(69, 22);
            this.radioButton5.TabIndex = 18;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "教师";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(88, 4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(69, 22);
            this.radioButton4.TabIndex = 17;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "职工";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(0, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(69, 22);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "学生";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // SNo_textbox
            // 
            this.SNo_textbox.Location = new System.Drawing.Point(238, 182);
            this.SNo_textbox.MaxLength = 8;
            this.SNo_textbox.Name = "SNo_textbox";
            this.SNo_textbox.Size = new System.Drawing.Size(283, 28);
            this.SNo_textbox.TabIndex = 19;
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Font = new System.Drawing.Font("宋体", 12F);
            this.number_label.Location = new System.Drawing.Point(111, 182);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(58, 24);
            this.number_label.TabIndex = 20;
            this.number_label.Text = "学号";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Location = new System.Drawing.Point(238, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 24);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Location = new System.Drawing.Point(286, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 29);
            this.panel2.TabIndex = 22;
            // 
            // checkBox_pwd1
            // 
            this.checkBox_pwd1.AutoSize = true;
            this.checkBox_pwd1.Location = new System.Drawing.Point(415, 279);
            this.checkBox_pwd1.Name = "checkBox_pwd1";
            this.checkBox_pwd1.Size = new System.Drawing.Size(106, 22);
            this.checkBox_pwd1.TabIndex = 23;
            this.checkBox_pwd1.Text = "显示密码";
            this.checkBox_pwd1.UseVisualStyleBackColor = true;
            this.checkBox_pwd1.CheckedChanged += new System.EventHandler(this.checkBox_pwd1_CheckedChanged);
            // 
            // checkBox_pwd2
            // 
            this.checkBox_pwd2.AutoSize = true;
            this.checkBox_pwd2.Location = new System.Drawing.Point(415, 329);
            this.checkBox_pwd2.Name = "checkBox_pwd2";
            this.checkBox_pwd2.Size = new System.Drawing.Size(106, 22);
            this.checkBox_pwd2.TabIndex = 24;
            this.checkBox_pwd2.Text = "显示密码";
            this.checkBox_pwd2.UseVisualStyleBackColor = true;
            this.checkBox_pwd2.CheckedChanged += new System.EventHandler(this.checkBox_pwd2_CheckedChanged);
            // 
            // readerRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 449);
            this.Controls.Add(this.checkBox_pwd2);
            this.Controls.Add(this.checkBox_pwd1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.number_label);
            this.Controls.Add(this.SNo_textbox);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.pwd_label2);
            this.Controls.Add(this.identity_label);
            this.Controls.Add(this.pwd_label1);
            this.Controls.Add(this.sex_label);
            this.Controls.Add(this.pwd_textbox2);
            this.Controls.Add(this.pwd_textbox1);
            this.Controls.Add(this.Rtelephone_textbox);
            this.Controls.Add(this.RName_textbox);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "readerRegister";
            this.Text = "读者注册";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox RName_textbox;
        private System.Windows.Forms.TextBox Rtelephone_textbox;
        private System.Windows.Forms.TextBox pwd_textbox1;
        private System.Windows.Forms.TextBox pwd_textbox2;
        private System.Windows.Forms.Label sex_label;
        private System.Windows.Forms.Label pwd_label1;
        private System.Windows.Forms.Label identity_label;
        private System.Windows.Forms.Label pwd_label2;
        private System.Windows.Forms.Label telephone;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox SNo_textbox;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox_pwd1;
        private System.Windows.Forms.CheckBox checkBox_pwd2;
    }
}