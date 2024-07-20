namespace 图书管理系统
{
    partial class Publisher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Publisher));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchBookButtom = new System.Windows.Forms.Button();
            this.lblBookNameForSearch = new System.Windows.Forms.Label();
            this.pressNameTextBox = new System.Windows.Forms.TextBox();
            this.booksDVG = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.addrText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pressNameText = new System.Windows.Forms.TextBox();
            this.linkmanText = new System.Windows.Forms.TextBox();
            this.telephoneText = new System.Windows.Forms.TextBox();
            this.lblPress = new System.Windows.Forms.Label();
            this.linkmanLabel = new System.Windows.Forms.Label();
            this.lblBookKind = new System.Windows.Forms.Label();
            this.publisherName = new System.Windows.Forms.Label();
            this.alterButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.provinceText = new System.Windows.Forms.ComboBox();
            this.cityText = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDVG)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchBookButtom);
            this.groupBox1.Controls.Add(this.lblBookNameForSearch);
            this.groupBox1.Controls.Add(this.pressNameTextBox);
            this.groupBox1.Controls.Add(this.booksDVG);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1450, 790);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "出版社信息";
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
            this.searchBookButtom.Click += new System.EventHandler(this.btnSearchPublisher_Click);
            // 
            // lblBookNameForSearch
            // 
            this.lblBookNameForSearch.AutoSize = true;
            this.lblBookNameForSearch.Location = new System.Drawing.Point(54, 44);
            this.lblBookNameForSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookNameForSearch.Name = "lblBookNameForSearch";
            this.lblBookNameForSearch.Size = new System.Drawing.Size(98, 18);
            this.lblBookNameForSearch.TabIndex = 34;
            this.lblBookNameForSearch.Text = "出版社名：";
            // 
            // pressNameTextBox
            // 
            this.pressNameTextBox.Location = new System.Drawing.Point(160, 40);
            this.pressNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pressNameTextBox.Name = "pressNameTextBox";
            this.pressNameTextBox.Size = new System.Drawing.Size(390, 28);
            this.pressNameTextBox.TabIndex = 33;
            // 
            // booksDVG
            // 
            this.booksDVG.AllowUserToAddRows = false;
            this.booksDVG.AllowUserToDeleteRows = false;
            this.booksDVG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksDVG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.booksDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDVG.Location = new System.Drawing.Point(57, 90);
            this.booksDVG.Margin = new System.Windows.Forms.Padding(4);
            this.booksDVG.Name = "booksDVG";
            this.booksDVG.ReadOnly = true;
            this.booksDVG.RowHeadersWidth = 82;
            this.booksDVG.RowTemplate.Height = 23;
            this.booksDVG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksDVG.Size = new System.Drawing.Size(1354, 441);
            this.booksDVG.TabIndex = 30;
            this.booksDVG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDVG_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cityText);
            this.groupBox2.Controls.Add(this.provinceText);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.addrText);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.exitButton);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.pressNameText);
            this.groupBox2.Controls.Add(this.linkmanText);
            this.groupBox2.Controls.Add(this.telephoneText);
            this.groupBox2.Controls.Add(this.lblPress);
            this.groupBox2.Controls.Add(this.linkmanLabel);
            this.groupBox2.Controls.Add(this.lblBookKind);
            this.groupBox2.Controls.Add(this.publisherName);
            this.groupBox2.Controls.Add(this.alterButton);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Location = new System.Drawing.Point(57, 574);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1354, 172);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "可修改部分";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(702, 27);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 32);
            this.addButton.TabIndex = 60;
            this.addButton.Text = "新增出版社";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addrText
            // 
            this.addrText.Location = new System.Drawing.Point(436, 114);
            this.addrText.Margin = new System.Windows.Forms.Padding(4);
            this.addrText.Name = "addrText";
            this.addrText.Size = new System.Drawing.Size(237, 28);
            this.addrText.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 56;
            this.label2.Text = "街道地址：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 55;
            this.label1.Text = "省：";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1122, 41);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(163, 57);
            this.exitButton.TabIndex = 51;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButtom_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(702, 82);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 32);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "刷新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pressNameText
            // 
            this.pressNameText.Location = new System.Drawing.Point(167, 24);
            this.pressNameText.Margin = new System.Windows.Forms.Padding(4);
            this.pressNameText.Name = "pressNameText";
            this.pressNameText.Size = new System.Drawing.Size(148, 28);
            this.pressNameText.TabIndex = 48;
            // 
            // linkmanText
            // 
            this.linkmanText.Location = new System.Drawing.Point(167, 70);
            this.linkmanText.Margin = new System.Windows.Forms.Padding(4);
            this.linkmanText.Name = "linkmanText";
            this.linkmanText.Size = new System.Drawing.Size(148, 28);
            this.linkmanText.TabIndex = 46;
            // 
            // telephoneText
            // 
            this.telephoneText.Location = new System.Drawing.Point(167, 114);
            this.telephoneText.Margin = new System.Windows.Forms.Padding(4);
            this.telephoneText.Name = "telephoneText";
            this.telephoneText.Size = new System.Drawing.Size(148, 28);
            this.telephoneText.TabIndex = 44;
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.Location = new System.Drawing.Point(335, 70);
            this.lblPress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(44, 18);
            this.lblPress.TabIndex = 43;
            this.lblPress.Text = "市：";
            // 
            // linkmanLabel
            // 
            this.linkmanLabel.AutoSize = true;
            this.linkmanLabel.Location = new System.Drawing.Point(61, 70);
            this.linkmanLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkmanLabel.Name = "linkmanLabel";
            this.linkmanLabel.Size = new System.Drawing.Size(80, 18);
            this.linkmanLabel.TabIndex = 42;
            this.linkmanLabel.Text = "联系人：";
            // 
            // lblBookKind
            // 
            this.lblBookKind.AutoSize = true;
            this.lblBookKind.Location = new System.Drawing.Point(61, 117);
            this.lblBookKind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookKind.Name = "lblBookKind";
            this.lblBookKind.Size = new System.Drawing.Size(98, 18);
            this.lblBookKind.TabIndex = 41;
            this.lblBookKind.Text = "联系电话：";
            // 
            // publisherName
            // 
            this.publisherName.AutoSize = true;
            this.publisherName.Location = new System.Drawing.Point(61, 30);
            this.publisherName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.publisherName.Name = "publisherName";
            this.publisherName.Size = new System.Drawing.Size(98, 18);
            this.publisherName.TabIndex = 39;
            this.publisherName.Text = "出版社名：";
            // 
            // alterButton
            // 
            this.alterButton.Location = new System.Drawing.Point(914, 26);
            this.alterButton.Margin = new System.Windows.Forms.Padding(4);
            this.alterButton.Name = "alterButton";
            this.alterButton.Size = new System.Drawing.Size(150, 32);
            this.alterButton.TabIndex = 37;
            this.alterButton.Text = "修改出版社信息";
            this.alterButton.UseVisualStyleBackColor = true;
            this.alterButton.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(914, 82);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 32);
            this.deleteButton.TabIndex = 32;
            this.deleteButton.Text = "删除出版社";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deletePublisher_Click);
            // 
            // provinceText
            // 
            this.provinceText.FormattingEnabled = true;
            this.provinceText.Items.AddRange(new object[] {
            "北京市",
            "重庆市",
            "上海市",
            "天津市",
            "河北省",
            "山东省",
            "辽宁省",
            "黑龙江省",
            "甘肃省",
            "吉林省",
            "青海省",
            "河南省",
            "江苏省",
            "湖北省",
            "湖南省",
            "浙江省",
            "江西省",
            "广东省",
            "云南省",
            "福建省",
            "台湾省",
            "海南省",
            "山西省",
            "四川省",
            "陕西省",
            "贵州省",
            "安徽省",
            "内蒙古自治区",
            "广西壮族自治区",
            "西藏自治区",
            "新疆维吾尔自治区",
            "宁夏回族自治区",
            "澳门特别行政区",
            "香港特别行政区"});
            this.provinceText.Location = new System.Drawing.Point(436, 19);
            this.provinceText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.provinceText.Name = "provinceText";
            this.provinceText.Size = new System.Drawing.Size(237, 26);
            this.provinceText.TabIndex = 61;
            // 
            // cityText
            // 
            this.cityText.FormattingEnabled = true;
            this.cityText.Items.AddRange(new object[] {
            "东城区",
            "西城区",
            "海淀区",
            "朝阳区",
            "丰台区",
            "门头沟区",
            "石景山区",
            "房山区",
            "通州区",
            "顺义区",
            "昌平区",
            "大兴区",
            "怀柔区",
            "平谷区",
            "延庆区",
            "密云区"});
            this.cityText.Location = new System.Drawing.Point(436, 67);
            this.cityText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(237, 26);
            this.cityText.TabIndex = 78;
            // 
            // Publisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 790);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Publisher";
            this.Text = "出版社管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDVG)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox pressNameText;
        private System.Windows.Forms.TextBox linkmanText;
        private System.Windows.Forms.TextBox telephoneText;
        private System.Windows.Forms.Label lblPress;
        private System.Windows.Forms.Label linkmanLabel;
        private System.Windows.Forms.Label publisherName;
        private System.Windows.Forms.Button alterButton;
        private System.Windows.Forms.Button searchBookButtom;
        private System.Windows.Forms.Label lblBookNameForSearch;
        private System.Windows.Forms.TextBox pressNameTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView booksDVG;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBookKind;
        private System.Windows.Forms.TextBox addrText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox provinceText;
        private System.Windows.Forms.ComboBox cityText;
    }
}