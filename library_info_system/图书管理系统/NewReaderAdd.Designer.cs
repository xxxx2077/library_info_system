namespace 图书管理系统
{
    partial class NewReaderAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.readerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.backButtom = new System.Windows.Forms.Button();
            this.SNoTextBox = new System.Windows.Forms.TextBox();
            this.addBookButtom = new System.Windows.Forms.Button();
            this.readerNameTextBox = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPress = new System.Windows.Forms.Label();
            this.lblBookKind = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.telephoneTextBox);
            this.groupBox1.Controls.Add(this.sexComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.readerTypeComboBox);
            this.groupBox1.Controls.Add(this.backButtom);
            this.groupBox1.Controls.Add(this.SNoTextBox);
            this.groupBox1.Controls.Add(this.addBookButtom);
            this.groupBox1.Controls.Add(this.readerNameTextBox);
            this.groupBox1.Controls.Add(this.lblBookName);
            this.groupBox1.Controls.Add(this.lblAuthor);
            this.groupBox1.Controls.Add(this.lblPress);
            this.groupBox1.Controls.Add(this.lblBookKind);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(708, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增读者信息";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(39, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 75;
            this.label4.Text = "基本信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 61;
            this.label3.Text = "性别：";
            // 
            // readerTypeComboBox
            // 
            this.readerTypeComboBox.FormattingEnabled = true;
            this.readerTypeComboBox.Location = new System.Drawing.Point(501, 77);
            this.readerTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.readerTypeComboBox.Name = "readerTypeComboBox";
            this.readerTypeComboBox.Size = new System.Drawing.Size(156, 26);
            this.readerTypeComboBox.TabIndex = 57;
            // 
            // backButtom
            // 
            this.backButtom.Location = new System.Drawing.Point(516, 214);
            this.backButtom.Margin = new System.Windows.Forms.Padding(4);
            this.backButtom.Name = "backButtom";
            this.backButtom.Size = new System.Drawing.Size(141, 58);
            this.backButtom.TabIndex = 56;
            this.backButtom.Text = "返回";
            this.backButtom.UseVisualStyleBackColor = true;
            this.backButtom.Click += new System.EventHandler(this.backButtom_Click);
            // 
            // SNoTextBox
            // 
            this.SNoTextBox.Location = new System.Drawing.Point(132, 77);
            this.SNoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SNoTextBox.Name = "SNoTextBox";
            this.SNoTextBox.Size = new System.Drawing.Size(232, 28);
            this.SNoTextBox.TabIndex = 55;
            // 
            // addBookButtom
            // 
            this.addBookButtom.Location = new System.Drawing.Point(43, 214);
            this.addBookButtom.Margin = new System.Windows.Forms.Padding(4);
            this.addBookButtom.Name = "addBookButtom";
            this.addBookButtom.Size = new System.Drawing.Size(141, 58);
            this.addBookButtom.TabIndex = 43;
            this.addBookButtom.Text = "确认添加";
            this.addBookButtom.UseVisualStyleBackColor = true;
            this.addBookButtom.Click += new System.EventHandler(this.addReaderButtom_Click);
            // 
            // readerNameTextBox
            // 
            this.readerNameTextBox.Location = new System.Drawing.Point(132, 122);
            this.readerNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.readerNameTextBox.Name = "readerNameTextBox";
            this.readerNameTextBox.Size = new System.Drawing.Size(232, 28);
            this.readerNameTextBox.TabIndex = 54;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(40, 80);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(98, 18);
            this.lblBookName.TabIndex = 46;
            this.lblBookName.Text = "读者编号：";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(40, 125);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(98, 18);
            this.lblAuthor.TabIndex = 47;
            this.lblAuthor.Text = "读者姓名：";
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.Location = new System.Drawing.Point(40, 169);
            this.lblPress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(98, 18);
            this.lblPress.TabIndex = 50;
            this.lblPress.Text = "联系电话：";
            // 
            // lblBookKind
            // 
            this.lblBookKind.AutoSize = true;
            this.lblBookKind.Location = new System.Drawing.Point(396, 80);
            this.lblBookKind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookKind.Name = "lblBookKind";
            this.lblBookKind.Size = new System.Drawing.Size(98, 18);
            this.lblBookKind.TabIndex = 48;
            this.lblBookKind.Text = "读者类别：";
            // 
            // sexComboBox
            // 
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sexComboBox.Location = new System.Drawing.Point(501, 122);
            this.sexComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(156, 26);
            this.sexComboBox.TabIndex = 77;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point(132, 166);
            this.telephoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(232, 28);
            this.telephoneTextBox.TabIndex = 78;
            // 
            // NewReaderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 314);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewReaderAdd";
            this.Text = "读者添加系统";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox readerTypeComboBox;
        private System.Windows.Forms.Button backButtom;
        private System.Windows.Forms.TextBox SNoTextBox;
        private System.Windows.Forms.Button addBookButtom;
        private System.Windows.Forms.TextBox readerNameTextBox;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPress;
        private System.Windows.Forms.Label lblBookKind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.ComboBox sexComboBox;
    }
}