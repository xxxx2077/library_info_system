namespace 图书管理系统
{
    partial class ReaderManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderManage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.usersDGV = new System.Windows.Forms.DataGridView();
            this.readerClassComboBox = new System.Windows.Forms.ComboBox();
            this.searchBookButtom = new System.Windows.Forms.Button();
            this.lblBookNameForSearch = new System.Windows.Forms.Label();
            this.readerNameTextBox = new System.Windows.Forms.TextBox();
            this.searchByKindButtom = new System.Windows.Forms.Button();
            this.lblKind = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.isLostcomboBox = new System.Windows.Forms.ComboBox();
            this.validDateText = new System.Windows.Forms.TextBox();
            this.RFTimesText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.readerSexComboBox = new System.Windows.Forms.ComboBox();
            this.readerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.registerDateText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.readsText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.totalReadText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBookKind = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SNoText = new System.Windows.Forms.TextBox();
            this.readerNameText = new System.Windows.Forms.TextBox();
            this.telephoneText = new System.Windows.Forms.TextBox();
            this.lblPress = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.alterButtom = new System.Windows.Forms.Button();
            this.deleteBook = new System.Windows.Forms.Button();
            this.readerAddButtom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.usersDGV);
            this.groupBox1.Controls.Add(this.readerClassComboBox);
            this.groupBox1.Controls.Add(this.searchBookButtom);
            this.groupBox1.Controls.Add(this.lblBookNameForSearch);
            this.groupBox1.Controls.Add(this.readerNameTextBox);
            this.groupBox1.Controls.Add(this.searchByKindButtom);
            this.groupBox1.Controls.Add(this.lblKind);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1466, 798);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "读者信息";
            // 
            // usersDGV
            // 
            this.usersDGV.AllowUserToAddRows = false;
            this.usersDGV.AllowUserToDeleteRows = false;
            this.usersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.usersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDGV.Location = new System.Drawing.Point(57, 90);
            this.usersDGV.Margin = new System.Windows.Forms.Padding(4);
            this.usersDGV.Name = "usersDGV";
            this.usersDGV.ReadOnly = true;
            this.usersDGV.RowHeadersWidth = 82;
            this.usersDGV.RowTemplate.Height = 23;
            this.usersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDGV.Size = new System.Drawing.Size(1354, 455);
            this.usersDGV.TabIndex = 30;
            this.usersDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDVG_CellClick);
            // 
            // readerClassComboBox
            // 
            this.readerClassComboBox.FormattingEnabled = true;
            this.readerClassComboBox.Location = new System.Drawing.Point(767, 40);
            this.readerClassComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.readerClassComboBox.Name = "readerClassComboBox";
            this.readerClassComboBox.Size = new System.Drawing.Size(157, 26);
            this.readerClassComboBox.TabIndex = 52;
            // 
            // searchBookButtom
            // 
            this.searchBookButtom.Location = new System.Drawing.Point(560, 36);
            this.searchBookButtom.Margin = new System.Windows.Forms.Padding(4);
            this.searchBookButtom.Name = "searchBookButtom";
            this.searchBookButtom.Size = new System.Drawing.Size(98, 32);
            this.searchBookButtom.TabIndex = 35;
            this.searchBookButtom.Text = "查找";
            this.searchBookButtom.UseVisualStyleBackColor = true;
            this.searchBookButtom.Click += new System.EventHandler(this.btnSearchReader_Click);
            // 
            // lblBookNameForSearch
            // 
            this.lblBookNameForSearch.AutoSize = true;
            this.lblBookNameForSearch.Location = new System.Drawing.Point(54, 44);
            this.lblBookNameForSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookNameForSearch.Name = "lblBookNameForSearch";
            this.lblBookNameForSearch.Size = new System.Drawing.Size(98, 18);
            this.lblBookNameForSearch.TabIndex = 34;
            this.lblBookNameForSearch.Text = "读者姓名：";
            // 
            // readerNameTextBox
            // 
            this.readerNameTextBox.Location = new System.Drawing.Point(160, 40);
            this.readerNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.readerNameTextBox.Name = "readerNameTextBox";
            this.readerNameTextBox.Size = new System.Drawing.Size(390, 28);
            this.readerNameTextBox.TabIndex = 33;
            // 
            // searchByKindButtom
            // 
            this.searchByKindButtom.Location = new System.Drawing.Point(933, 38);
            this.searchByKindButtom.Margin = new System.Windows.Forms.Padding(4);
            this.searchByKindButtom.Name = "searchByKindButtom";
            this.searchByKindButtom.Size = new System.Drawing.Size(94, 30);
            this.searchByKindButtom.TabIndex = 29;
            this.searchByKindButtom.Text = "按类查找";
            this.searchByKindButtom.UseVisualStyleBackColor = true;
            this.searchByKindButtom.Click += new System.EventHandler(this.searchByKindButtom_Click);
            // 
            // lblKind
            // 
            this.lblKind.AutoSize = true;
            this.lblKind.Location = new System.Drawing.Point(668, 44);
            this.lblKind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKind.Name = "lblKind";
            this.lblKind.Size = new System.Drawing.Size(98, 18);
            this.lblKind.TabIndex = 27;
            this.lblKind.Text = "读者类别：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.isLostcomboBox);
            this.groupBox2.Controls.Add(this.validDateText);
            this.groupBox2.Controls.Add(this.RFTimesText);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.readerSexComboBox);
            this.groupBox2.Controls.Add(this.readerTypeComboBox);
            this.groupBox2.Controls.Add(this.registerDateText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.readsText);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.totalReadText);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblBookKind);
            this.groupBox2.Controls.Add(this.exitButton);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.SNoText);
            this.groupBox2.Controls.Add(this.readerNameText);
            this.groupBox2.Controls.Add(this.telephoneText);
            this.groupBox2.Controls.Add(this.lblPress);
            this.groupBox2.Controls.Add(this.lblTime);
            this.groupBox2.Controls.Add(this.lblAuthor);
            this.groupBox2.Controls.Add(this.lblBookName);
            this.groupBox2.Controls.Add(this.alterButtom);
            this.groupBox2.Controls.Add(this.deleteBook);
            this.groupBox2.Controls.Add(this.readerAddButtom);
            this.groupBox2.Location = new System.Drawing.Point(57, 574);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1354, 216);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "可修改部分";
            // 
            // isLostcomboBox
            // 
            this.isLostcomboBox.FormattingEnabled = true;
            this.isLostcomboBox.Items.AddRange(new object[] {
            "是",
            "否"});
            this.isLostcomboBox.Location = new System.Drawing.Point(783, 116);
            this.isLostcomboBox.Name = "isLostcomboBox";
            this.isLostcomboBox.Size = new System.Drawing.Size(153, 26);
            this.isLostcomboBox.TabIndex = 79;
            // 
            // validDateText
            // 
            this.validDateText.Location = new System.Drawing.Point(436, 158);
            this.validDateText.Name = "validDateText";
            this.validDateText.Size = new System.Drawing.Size(206, 28);
            this.validDateText.TabIndex = 78;
            // 
            // RFTimesText
            // 
            this.RFTimesText.Location = new System.Drawing.Point(783, 158);
            this.RFTimesText.Name = "RFTimesText";
            this.RFTimesText.ReadOnly = true;
            this.RFTimesText.Size = new System.Drawing.Size(153, 28);
            this.RFTimesText.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(665, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 76;
            this.label6.Text = "违规次数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 74;
            this.label5.Text = "是否挂失";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(665, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 73;
            this.label4.Text = "现借图书数：";
            // 
            // readerSexComboBox
            // 
            this.readerSexComboBox.FormattingEnabled = true;
            this.readerSexComboBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.readerSexComboBox.Location = new System.Drawing.Point(436, 28);
            this.readerSexComboBox.Name = "readerSexComboBox";
            this.readerSexComboBox.Size = new System.Drawing.Size(165, 26);
            this.readerSexComboBox.TabIndex = 72;
            // 
            // readerTypeComboBox
            // 
            this.readerTypeComboBox.FormattingEnabled = true;
            this.readerTypeComboBox.Location = new System.Drawing.Point(167, 118);
            this.readerTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.readerTypeComboBox.Name = "readerTypeComboBox";
            this.readerTypeComboBox.Size = new System.Drawing.Size(148, 26);
            this.readerTypeComboBox.TabIndex = 58;
            // 
            // registerDateText
            // 
            this.registerDateText.Location = new System.Drawing.Point(436, 113);
            this.registerDateText.Name = "registerDateText";
            this.registerDateText.Size = new System.Drawing.Size(206, 28);
            this.registerDateText.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 56;
            this.label3.Text = "登记日期：";
            // 
            // readsText
            // 
            this.readsText.Location = new System.Drawing.Point(783, 26);
            this.readsText.Name = "readsText";
            this.readsText.Size = new System.Drawing.Size(148, 28);
            this.readsText.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 54;
            this.label2.Text = "读者性别";
            // 
            // totalReadText
            // 
            this.totalReadText.Location = new System.Drawing.Point(783, 70);
            this.totalReadText.Name = "totalReadText";
            this.totalReadText.Size = new System.Drawing.Size(153, 28);
            this.totalReadText.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 52;
            this.label1.Text = "累计借书数";
            // 
            // lblBookKind
            // 
            this.lblBookKind.AutoSize = true;
            this.lblBookKind.Location = new System.Drawing.Point(62, 121);
            this.lblBookKind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookKind.Name = "lblBookKind";
            this.lblBookKind.Size = new System.Drawing.Size(98, 18);
            this.lblBookKind.TabIndex = 41;
            this.lblBookKind.Text = "读者类型：";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1093, 146);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 48);
            this.exitButton.TabIndex = 51;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButtom_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1183, 86);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 48);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "刷新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // SNoText
            // 
            this.SNoText.Location = new System.Drawing.Point(167, 26);
            this.SNoText.Margin = new System.Windows.Forms.Padding(4);
            this.SNoText.Name = "SNoText";
            this.SNoText.ReadOnly = true;
            this.SNoText.Size = new System.Drawing.Size(148, 28);
            this.SNoText.TabIndex = 48;
            // 
            // readerNameText
            // 
            this.readerNameText.Location = new System.Drawing.Point(167, 73);
            this.readerNameText.Margin = new System.Windows.Forms.Padding(4);
            this.readerNameText.Name = "readerNameText";
            this.readerNameText.Size = new System.Drawing.Size(148, 28);
            this.readerNameText.TabIndex = 47;
            // 
            // telephoneText
            // 
            this.telephoneText.Location = new System.Drawing.Point(436, 70);
            this.telephoneText.Margin = new System.Windows.Forms.Padding(4);
            this.telephoneText.Name = "telephoneText";
            this.telephoneText.Size = new System.Drawing.Size(165, 28);
            this.telephoneText.TabIndex = 46;
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.Location = new System.Drawing.Point(335, 161);
            this.lblPress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(98, 18);
            this.lblPress.TabIndex = 43;
            this.lblPress.Text = "有效期至：";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(335, 76);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(98, 18);
            this.lblTime.TabIndex = 42;
            this.lblTime.Text = "联系电话：";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(62, 76);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(98, 18);
            this.lblAuthor.TabIndex = 40;
            this.lblAuthor.Text = "读者姓名：";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(62, 31);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(98, 18);
            this.lblBookName.TabIndex = 39;
            this.lblBookName.Text = "读者编号：";
            // 
            // alterButtom
            // 
            this.alterButtom.Location = new System.Drawing.Point(1183, 26);
            this.alterButtom.Margin = new System.Windows.Forms.Padding(4);
            this.alterButtom.Name = "alterButtom";
            this.alterButtom.Size = new System.Drawing.Size(150, 48);
            this.alterButtom.TabIndex = 37;
            this.alterButtom.Text = "修改读者信息";
            this.alterButtom.UseVisualStyleBackColor = true;
            this.alterButtom.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // deleteBook
            // 
            this.deleteBook.Location = new System.Drawing.Point(997, 90);
            this.deleteBook.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBook.Name = "deleteBook";
            this.deleteBook.Size = new System.Drawing.Size(150, 48);
            this.deleteBook.TabIndex = 32;
            this.deleteBook.Text = "删除读者";
            this.deleteBook.UseVisualStyleBackColor = true;
            this.deleteBook.Click += new System.EventHandler(this.deleteBook_Click);
            // 
            // readerAddButtom
            // 
            this.readerAddButtom.Location = new System.Drawing.Point(997, 26);
            this.readerAddButtom.Margin = new System.Windows.Forms.Padding(4);
            this.readerAddButtom.Name = "readerAddButtom";
            this.readerAddButtom.Size = new System.Drawing.Size(150, 48);
            this.readerAddButtom.TabIndex = 31;
            this.readerAddButtom.Text = "新增读者";
            this.readerAddButtom.UseVisualStyleBackColor = true;
            this.readerAddButtom.Click += new System.EventHandler(this.readerAddButtom_Click);
            // 
            // ReaderManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 798);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReaderManage";
            this.Text = "读者管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox SNoText;
        private System.Windows.Forms.TextBox readerNameText;
        private System.Windows.Forms.TextBox telephoneText;
        private System.Windows.Forms.Label lblPress;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBookKind;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Button alterButtom;
        private System.Windows.Forms.Button searchBookButtom;
        private System.Windows.Forms.Label lblBookNameForSearch;
        private System.Windows.Forms.TextBox readerNameTextBox;
        private System.Windows.Forms.Button deleteBook;
        private System.Windows.Forms.Button readerAddButtom;
        private System.Windows.Forms.DataGridView usersDGV;
        private System.Windows.Forms.Button searchByKindButtom;
        private System.Windows.Forms.Label lblKind;
        private System.Windows.Forms.ComboBox readerClassComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox totalReadText;
        private System.Windows.Forms.TextBox readsText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox registerDateText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox readerTypeComboBox;
        private System.Windows.Forms.ComboBox readerSexComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox validDateText;
        private System.Windows.Forms.TextBox RFTimesText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox isLostcomboBox;
    }
}