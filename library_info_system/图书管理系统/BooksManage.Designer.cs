namespace 图书管理系统
{
    partial class BooksManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksManage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.booksDVG = new System.Windows.Forms.DataGridView();
            this.bookClassComboBox = new System.Windows.Forms.ComboBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.bookDigestTextBox = new System.Windows.Forms.TextBox();
            this.searchBookButtom = new System.Windows.Forms.Button();
            this.lblBookNameForSearch = new System.Windows.Forms.Label();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.searchByKindButtom = new System.Windows.Forms.Button();
            this.lblKind = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addBookStoreButton = new System.Windows.Forms.Button();
            this.PublisherComboBox = new System.Windows.Forms.ComboBox();
            this.bookTypeComboBox = new System.Windows.Forms.ComboBox();
            this.editionBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ISBNBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButtom = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.bookNameText = new System.Windows.Forms.TextBox();
            this.authorText = new System.Windows.Forms.TextBox();
            this.publishTimeText = new System.Windows.Forms.TextBox();
            this.lblPress = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblBookKind = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.alterButtom = new System.Windows.Forms.Button();
            this.deleteBook = new System.Windows.Forms.Button();
            this.bookAddButtom = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDVG)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.booksDVG);
            this.groupBox1.Controls.Add(this.bookClassComboBox);
            this.groupBox1.Controls.Add(this.lblContent);
            this.groupBox1.Controls.Add(this.bookDigestTextBox);
            this.groupBox1.Controls.Add(this.searchBookButtom);
            this.groupBox1.Controls.Add(this.lblBookNameForSearch);
            this.groupBox1.Controls.Add(this.bookNameTextBox);
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
            this.groupBox1.Text = "图书信息";
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
            this.booksDVG.Size = new System.Drawing.Size(1354, 250);
            this.booksDVG.TabIndex = 30;
            this.booksDVG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksDVG_CellClick);
            // 
            // bookClassComboBox
            // 
            this.bookClassComboBox.FormattingEnabled = true;
            this.bookClassComboBox.Location = new System.Drawing.Point(767, 40);
            this.bookClassComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bookClassComboBox.Name = "bookClassComboBox";
            this.bookClassComboBox.Size = new System.Drawing.Size(157, 26);
            this.bookClassComboBox.TabIndex = 52;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblContent.Location = new System.Drawing.Point(52, 344);
            this.lblContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(130, 24);
            this.lblContent.TabIndex = 38;
            this.lblContent.Text = "内容摘要：";
            // 
            // bookDigestTextBox
            // 
            this.bookDigestTextBox.Location = new System.Drawing.Point(57, 374);
            this.bookDigestTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bookDigestTextBox.Multiline = true;
            this.bookDigestTextBox.Name = "bookDigestTextBox";
            this.bookDigestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.bookDigestTextBox.Size = new System.Drawing.Size(1355, 192);
            this.bookDigestTextBox.TabIndex = 36;
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
            this.searchBookButtom.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // lblBookNameForSearch
            // 
            this.lblBookNameForSearch.AutoSize = true;
            this.lblBookNameForSearch.Location = new System.Drawing.Point(54, 44);
            this.lblBookNameForSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookNameForSearch.Name = "lblBookNameForSearch";
            this.lblBookNameForSearch.Size = new System.Drawing.Size(98, 18);
            this.lblBookNameForSearch.TabIndex = 34;
            this.lblBookNameForSearch.Text = "图书书名：";
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(160, 40);
            this.bookNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(390, 28);
            this.bookNameTextBox.TabIndex = 33;
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
            this.lblKind.Text = "书籍类别：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addBookStoreButton);
            this.groupBox2.Controls.Add(this.PublisherComboBox);
            this.groupBox2.Controls.Add(this.bookTypeComboBox);
            this.groupBox2.Controls.Add(this.editionBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.priceBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ISBNBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.exitButtom);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.bookNameText);
            this.groupBox2.Controls.Add(this.authorText);
            this.groupBox2.Controls.Add(this.publishTimeText);
            this.groupBox2.Controls.Add(this.lblPress);
            this.groupBox2.Controls.Add(this.lblTime);
            this.groupBox2.Controls.Add(this.lblBookKind);
            this.groupBox2.Controls.Add(this.lblAuthor);
            this.groupBox2.Controls.Add(this.lblBookName);
            this.groupBox2.Controls.Add(this.alterButtom);
            this.groupBox2.Controls.Add(this.deleteBook);
            this.groupBox2.Controls.Add(this.bookAddButtom);
            this.groupBox2.Location = new System.Drawing.Point(57, 574);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1354, 211);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "可修改部分";
            // 
            // addBookStoreButton
            // 
            this.addBookStoreButton.Location = new System.Drawing.Point(820, 106);
            this.addBookStoreButton.Margin = new System.Windows.Forms.Padding(4);
            this.addBookStoreButton.Name = "addBookStoreButton";
            this.addBookStoreButton.Size = new System.Drawing.Size(150, 48);
            this.addBookStoreButton.TabIndex = 73;
            this.addBookStoreButton.Text = "新增馆藏";
            this.addBookStoreButton.UseVisualStyleBackColor = true;
            this.addBookStoreButton.Click += new System.EventHandler(this.addBookStoreButton_Click);
            // 
            // PublisherComboBox
            // 
            this.PublisherComboBox.FormattingEnabled = true;
            this.PublisherComboBox.Location = new System.Drawing.Point(752, 22);
            this.PublisherComboBox.Name = "PublisherComboBox";
            this.PublisherComboBox.Size = new System.Drawing.Size(218, 26);
            this.PublisherComboBox.TabIndex = 72;
            // 
            // bookTypeComboBox
            // 
            this.bookTypeComboBox.FormattingEnabled = true;
            this.bookTypeComboBox.Location = new System.Drawing.Point(436, 28);
            this.bookTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bookTypeComboBox.Name = "bookTypeComboBox";
            this.bookTypeComboBox.Size = new System.Drawing.Size(206, 26);
            this.bookTypeComboBox.TabIndex = 58;
            // 
            // editionBox
            // 
            this.editionBox.Location = new System.Drawing.Point(436, 106);
            this.editionBox.Name = "editionBox";
            this.editionBox.Size = new System.Drawing.Size(206, 28);
            this.editionBox.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 56;
            this.label3.Text = "版次";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(132, 113);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(148, 28);
            this.priceBox.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 54;
            this.label2.Text = "价格";
            // 
            // ISBNBox
            // 
            this.ISBNBox.Location = new System.Drawing.Point(752, 66);
            this.ISBNBox.Name = "ISBNBox";
            this.ISBNBox.ReadOnly = true;
            this.ISBNBox.Size = new System.Drawing.Size(218, 28);
            this.ISBNBox.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 52;
            this.label1.Text = "ISBN";
            // 
            // exitButtom
            // 
            this.exitButtom.Location = new System.Drawing.Point(1183, 93);
            this.exitButtom.Margin = new System.Windows.Forms.Padding(4);
            this.exitButtom.Name = "exitButtom";
            this.exitButtom.Size = new System.Drawing.Size(150, 45);
            this.exitButtom.TabIndex = 51;
            this.exitButtom.Text = "退出";
            this.exitButtom.UseVisualStyleBackColor = true;
            this.exitButtom.Click += new System.EventHandler(this.exitButtom_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1183, 26);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 48);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "刷新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // bookNameText
            // 
            this.bookNameText.Location = new System.Drawing.Point(132, 26);
            this.bookNameText.Margin = new System.Windows.Forms.Padding(4);
            this.bookNameText.Name = "bookNameText";
            this.bookNameText.Size = new System.Drawing.Size(148, 28);
            this.bookNameText.TabIndex = 48;
            // 
            // authorText
            // 
            this.authorText.Location = new System.Drawing.Point(132, 66);
            this.authorText.Margin = new System.Windows.Forms.Padding(4);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(148, 28);
            this.authorText.TabIndex = 47;
            // 
            // publishTimeText
            // 
            this.publishTimeText.Location = new System.Drawing.Point(436, 64);
            this.publishTimeText.Margin = new System.Windows.Forms.Padding(4);
            this.publishTimeText.Name = "publishTimeText";
            this.publishTimeText.Size = new System.Drawing.Size(206, 28);
            this.publishTimeText.TabIndex = 46;
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.Location = new System.Drawing.Point(665, 29);
            this.lblPress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(80, 18);
            this.lblPress.TabIndex = 43;
            this.lblPress.Text = "出版社：";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(335, 70);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(98, 18);
            this.lblTime.TabIndex = 42;
            this.lblTime.Text = "出版日期：";
            // 
            // lblBookKind
            // 
            this.lblBookKind.AutoSize = true;
            this.lblBookKind.Location = new System.Drawing.Point(335, 30);
            this.lblBookKind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookKind.Name = "lblBookKind";
            this.lblBookKind.Size = new System.Drawing.Size(98, 18);
            this.lblBookKind.TabIndex = 41;
            this.lblBookKind.Text = "图书类别：";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(61, 70);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(62, 18);
            this.lblAuthor.TabIndex = 40;
            this.lblAuthor.Text = "作者：";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(61, 30);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(62, 18);
            this.lblBookName.TabIndex = 39;
            this.lblBookName.Text = "书名：";
            // 
            // alterButtom
            // 
            this.alterButtom.Location = new System.Drawing.Point(997, 26);
            this.alterButtom.Margin = new System.Windows.Forms.Padding(4);
            this.alterButtom.Name = "alterButtom";
            this.alterButtom.Size = new System.Drawing.Size(150, 48);
            this.alterButtom.TabIndex = 37;
            this.alterButtom.Text = "修改书目";
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
            this.deleteBook.Text = "删除书目";
            this.deleteBook.UseVisualStyleBackColor = true;
            this.deleteBook.Click += new System.EventHandler(this.deleteBook_Click);
            // 
            // bookAddButtom
            // 
            this.bookAddButtom.Location = new System.Drawing.Point(662, 106);
            this.bookAddButtom.Margin = new System.Windows.Forms.Padding(4);
            this.bookAddButtom.Name = "bookAddButtom";
            this.bookAddButtom.Size = new System.Drawing.Size(150, 48);
            this.bookAddButtom.TabIndex = 31;
            this.bookAddButtom.Text = "新增书目信息";
            this.bookAddButtom.UseVisualStyleBackColor = true;
            this.bookAddButtom.Click += new System.EventHandler(this.bookAddButtom_Click);
            // 
            // BooksManage
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
            this.Name = "BooksManage";
            this.Text = "图书管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDVG)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exitButtom;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox bookNameText;
        private System.Windows.Forms.TextBox authorText;
        private System.Windows.Forms.TextBox publishTimeText;
        private System.Windows.Forms.Label lblPress;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBookKind;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Button alterButtom;
        private System.Windows.Forms.TextBox bookDigestTextBox;
        private System.Windows.Forms.Button searchBookButtom;
        private System.Windows.Forms.Label lblBookNameForSearch;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Button deleteBook;
        private System.Windows.Forms.Button bookAddButtom;
        private System.Windows.Forms.DataGridView booksDVG;
        private System.Windows.Forms.Button searchByKindButtom;
        private System.Windows.Forms.Label lblKind;
        private System.Windows.Forms.ComboBox bookClassComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ISBNBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox editionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bookTypeComboBox;
        private System.Windows.Forms.ComboBox PublisherComboBox;
        private System.Windows.Forms.Button addBookStoreButton;
    }
}