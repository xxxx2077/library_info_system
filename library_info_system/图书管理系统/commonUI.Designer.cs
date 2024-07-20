namespace 图书管理系统
{
    partial class commonUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(commonUI));
            this.lblKind = new System.Windows.Forms.Label();
            this.searchByKindButtom = new System.Windows.Forms.Button();
            this.booksDVG = new System.Windows.Forms.DataGridView();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.lblBookNameForSearch = new System.Windows.Forms.Label();
            this.searchBookButtom = new System.Windows.Forms.Button();
            this.bookDigestTextBox = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.borrowButtoom = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.bookClassComboBox = new System.Windows.Forms.ComboBox();
            this.bookInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BName_textbox = new System.Windows.Forms.TextBox();
            this.BWriter_textbox = new System.Windows.Forms.TextBox();
            this.PName_textbox = new System.Windows.Forms.TextBox();
            this.BTName_textbox = new System.Windows.Forms.TextBox();
            this.ISBN_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BPDate_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BEdition_textbox = new System.Windows.Forms.TextBox();
            this.BExnum_textbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.booksDVG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKind
            // 
            this.lblKind.AutoSize = true;
            this.lblKind.Location = new System.Drawing.Point(654, 50);
            this.lblKind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKind.Name = "lblKind";
            this.lblKind.Size = new System.Drawing.Size(98, 18);
            this.lblKind.TabIndex = 26;
            this.lblKind.Text = "书籍类别：";
            // 
            // searchByKindButtom
            // 
            this.searchByKindButtom.Location = new System.Drawing.Point(909, 44);
            this.searchByKindButtom.Margin = new System.Windows.Forms.Padding(4);
            this.searchByKindButtom.Name = "searchByKindButtom";
            this.searchByKindButtom.Size = new System.Drawing.Size(94, 30);
            this.searchByKindButtom.TabIndex = 28;
            this.searchByKindButtom.Text = "按类查找";
            this.searchByKindButtom.UseVisualStyleBackColor = true;
            this.searchByKindButtom.Click += new System.EventHandler(this.searchByKindButtom_Click);
            // 
            // booksDVG
            // 
            this.booksDVG.AllowUserToAddRows = false;
            this.booksDVG.AllowUserToDeleteRows = false;
            this.booksDVG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksDVG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.booksDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDVG.Location = new System.Drawing.Point(36, 86);
            this.booksDVG.Margin = new System.Windows.Forms.Padding(4);
            this.booksDVG.Name = "booksDVG";
            this.booksDVG.ReadOnly = true;
            this.booksDVG.RowHeadersWidth = 82;
            this.booksDVG.RowTemplate.Height = 23;
            this.booksDVG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksDVG.Size = new System.Drawing.Size(968, 250);
            this.booksDVG.TabIndex = 29;
            this.booksDVG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDVG_CellClick);
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(146, 44);
            this.bookNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(390, 28);
            this.bookNameTextBox.TabIndex = 30;
            // 
            // lblBookNameForSearch
            // 
            this.lblBookNameForSearch.AutoSize = true;
            this.lblBookNameForSearch.Location = new System.Drawing.Point(40, 50);
            this.lblBookNameForSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookNameForSearch.Name = "lblBookNameForSearch";
            this.lblBookNameForSearch.Size = new System.Drawing.Size(98, 18);
            this.lblBookNameForSearch.TabIndex = 31;
            this.lblBookNameForSearch.Text = "图书书名：";
            // 
            // searchBookButtom
            // 
            this.searchBookButtom.Location = new System.Drawing.Point(547, 44);
            this.searchBookButtom.Margin = new System.Windows.Forms.Padding(4);
            this.searchBookButtom.Name = "searchBookButtom";
            this.searchBookButtom.Size = new System.Drawing.Size(98, 32);
            this.searchBookButtom.TabIndex = 32;
            this.searchBookButtom.Text = "查找";
            this.searchBookButtom.UseVisualStyleBackColor = true;
            this.searchBookButtom.Click += new System.EventHandler(this.searchBookButtom_Click);
            // 
            // bookDigestTextBox
            // 
            this.bookDigestTextBox.Location = new System.Drawing.Point(43, 503);
            this.bookDigestTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bookDigestTextBox.Multiline = true;
            this.bookDigestTextBox.Name = "bookDigestTextBox";
            this.bookDigestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.bookDigestTextBox.Size = new System.Drawing.Size(966, 74);
            this.bookDigestTextBox.TabIndex = 33;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblContent.Location = new System.Drawing.Point(32, 471);
            this.lblContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(130, 24);
            this.lblContent.TabIndex = 34;
            this.lblContent.Text = "内容摘要：";
            // 
            // borrowButtoom
            // 
            this.borrowButtoom.Location = new System.Drawing.Point(43, 595);
            this.borrowButtoom.Margin = new System.Windows.Forms.Padding(4);
            this.borrowButtoom.Name = "borrowButtoom";
            this.borrowButtoom.Size = new System.Drawing.Size(195, 56);
            this.borrowButtoom.TabIndex = 35;
            this.borrowButtoom.Text = "借书";
            this.borrowButtoom.UseVisualStyleBackColor = true;
            this.borrowButtoom.Click += new System.EventHandler(this.borrowButtoom_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(809, 595);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(195, 56);
            this.btnQuery.TabIndex = 36;
            this.btnQuery.Text = "查看借书记录";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(557, 595);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(195, 56);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // bookClassComboBox
            // 
            this.bookClassComboBox.FormattingEnabled = true;
            this.bookClassComboBox.Location = new System.Drawing.Point(736, 46);
            this.bookClassComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bookClassComboBox.Name = "bookClassComboBox";
            this.bookClassComboBox.Size = new System.Drawing.Size(164, 26);
            this.bookClassComboBox.TabIndex = 38;
            // 
            // bookInfo
            // 
            this.bookInfo.AutoSize = true;
            this.bookInfo.Font = new System.Drawing.Font("宋体", 12F);
            this.bookInfo.Location = new System.Drawing.Point(32, 353);
            this.bookInfo.Name = "bookInfo";
            this.bookInfo.Size = new System.Drawing.Size(106, 24);
            this.bookInfo.TabIndex = 39;
            this.bookInfo.Text = "详细信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "书名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "作者";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 42;
            this.label4.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "出版社";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(754, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 44;
            this.label5.Text = "可借数量";
            // 
            // BName_textbox
            // 
            this.BName_textbox.Location = new System.Drawing.Point(90, 387);
            this.BName_textbox.Name = "BName_textbox";
            this.BName_textbox.ReadOnly = true;
            this.BName_textbox.Size = new System.Drawing.Size(156, 28);
            this.BName_textbox.TabIndex = 45;
            // 
            // BWriter_textbox
            // 
            this.BWriter_textbox.Location = new System.Drawing.Point(90, 433);
            this.BWriter_textbox.Name = "BWriter_textbox";
            this.BWriter_textbox.ReadOnly = true;
            this.BWriter_textbox.Size = new System.Drawing.Size(156, 28);
            this.BWriter_textbox.TabIndex = 46;
            // 
            // PName_textbox
            // 
            this.PName_textbox.Location = new System.Drawing.Point(352, 390);
            this.PName_textbox.Name = "PName_textbox";
            this.PName_textbox.ReadOnly = true;
            this.PName_textbox.Size = new System.Drawing.Size(159, 28);
            this.PName_textbox.TabIndex = 47;
            // 
            // BTName_textbox
            // 
            this.BTName_textbox.Location = new System.Drawing.Point(352, 434);
            this.BTName_textbox.Name = "BTName_textbox";
            this.BTName_textbox.ReadOnly = true;
            this.BTName_textbox.Size = new System.Drawing.Size(162, 28);
            this.BTName_textbox.TabIndex = 48;
            // 
            // ISBN_textbox
            // 
            this.ISBN_textbox.Location = new System.Drawing.Point(606, 434);
            this.ISBN_textbox.Name = "ISBN_textbox";
            this.ISBN_textbox.ReadOnly = true;
            this.ISBN_textbox.Size = new System.Drawing.Size(142, 28);
            this.ISBN_textbox.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 50;
            this.label6.Text = "出版日期";
            // 
            // BPDate_textbox
            // 
            this.BPDate_textbox.Location = new System.Drawing.Point(606, 387);
            this.BPDate_textbox.Name = "BPDate_textbox";
            this.BPDate_textbox.ReadOnly = true;
            this.BPDate_textbox.Size = new System.Drawing.Size(142, 28);
            this.BPDate_textbox.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(754, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 52;
            this.label7.Text = "版次";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 53;
            this.label8.Text = "图书类型";
            // 
            // BEdition_textbox
            // 
            this.BEdition_textbox.Location = new System.Drawing.Point(840, 387);
            this.BEdition_textbox.Name = "BEdition_textbox";
            this.BEdition_textbox.ReadOnly = true;
            this.BEdition_textbox.Size = new System.Drawing.Size(145, 28);
            this.BEdition_textbox.TabIndex = 54;
            // 
            // BExnum_textbox
            // 
            this.BExnum_textbox.Location = new System.Drawing.Point(840, 434);
            this.BExnum_textbox.Name = "BExnum_textbox";
            this.BExnum_textbox.ReadOnly = true;
            this.BExnum_textbox.Size = new System.Drawing.Size(145, 28);
            this.BExnum_textbox.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.BExnum_textbox);
            this.groupBox1.Controls.Add(this.BEdition_textbox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.BPDate_textbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ISBN_textbox);
            this.groupBox1.Controls.Add(this.BTName_textbox);
            this.groupBox1.Controls.Add(this.PName_textbox);
            this.groupBox1.Controls.Add(this.BWriter_textbox);
            this.groupBox1.Controls.Add(this.BName_textbox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bookInfo);
            this.groupBox1.Controls.Add(this.bookClassComboBox);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.borrowButtoom);
            this.groupBox1.Controls.Add(this.lblContent);
            this.groupBox1.Controls.Add(this.bookDigestTextBox);
            this.groupBox1.Controls.Add(this.searchBookButtom);
            this.groupBox1.Controls.Add(this.lblBookNameForSearch);
            this.groupBox1.Controls.Add(this.bookNameTextBox);
            this.groupBox1.Controls.Add(this.booksDVG);
            this.groupBox1.Controls.Add(this.searchByKindButtom);
            this.groupBox1.Controls.Add(this.lblKind);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1045, 682);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查书系统";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(300, 595);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(195, 56);
            this.btnUpdate.TabIndex = 56;
            this.btnUpdate.Text = "刷新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // commonUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1045, 682);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "commonUI";
            this.Text = "用户界面";
            ((System.ComponentModel.ISupportInitialize)(this.booksDVG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKind;
        private System.Windows.Forms.Button searchByKindButtom;
        private System.Windows.Forms.DataGridView booksDVG;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Label lblBookNameForSearch;
        private System.Windows.Forms.Button searchBookButtom;
        private System.Windows.Forms.TextBox bookDigestTextBox;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Button borrowButtoom;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox bookClassComboBox;
        private System.Windows.Forms.Label bookInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BName_textbox;
        private System.Windows.Forms.TextBox BWriter_textbox;
        private System.Windows.Forms.TextBox PName_textbox;
        private System.Windows.Forms.TextBox BTName_textbox;
        private System.Windows.Forms.TextBox ISBN_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BPDate_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BEdition_textbox;
        private System.Windows.Forms.TextBox BExnum_textbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
    }
}