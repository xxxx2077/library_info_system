namespace 图书管理系统
{
    partial class BooksStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksStore));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BSStatusComboBox = new System.Windows.Forms.ComboBox();
            this.searchBookButtom = new System.Windows.Forms.Button();
            this.lblBookNameForSearch = new System.Windows.Forms.Label();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.booksDVG = new System.Windows.Forms.DataGridView();
            this.searchByKindButtom = new System.Windows.Forms.Button();
            this.lblKind = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.exitButtom = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.bookNameText = new System.Windows.Forms.TextBox();
            this.BSDateText = new System.Windows.Forms.TextBox();
            this.ISBNText = new System.Windows.Forms.TextBox();
            this.lblPress = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.alterButtom = new System.Windows.Forms.Button();
            this.deleteBook = new System.Windows.Forms.Button();
            this.lblBookKind = new System.Windows.Forms.Label();
            this.BSStatusText = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksDVG)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BSStatusComboBox);
            this.groupBox1.Controls.Add(this.searchBookButtom);
            this.groupBox1.Controls.Add(this.lblBookNameForSearch);
            this.groupBox1.Controls.Add(this.bookNameTextBox);
            this.groupBox1.Controls.Add(this.booksDVG);
            this.groupBox1.Controls.Add(this.searchByKindButtom);
            this.groupBox1.Controls.Add(this.lblKind);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1450, 790);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图书馆藏信息";
            // 
            // BSStatusComboBox
            // 
            this.BSStatusComboBox.FormattingEnabled = true;
            this.BSStatusComboBox.Items.AddRange(new object[] {
            "在库",
            "借出",
            "丢失",
            "损坏"});
            this.BSStatusComboBox.Location = new System.Drawing.Point(767, 40);
            this.BSStatusComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BSStatusComboBox.Name = "BSStatusComboBox";
            this.BSStatusComboBox.Size = new System.Drawing.Size(157, 26);
            this.BSStatusComboBox.TabIndex = 52;
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
            this.lblKind.Text = "图书状态：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BSStatusText);
            this.groupBox2.Controls.Add(this.exitButtom);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.bookNameText);
            this.groupBox2.Controls.Add(this.BSDateText);
            this.groupBox2.Controls.Add(this.ISBNText);
            this.groupBox2.Controls.Add(this.lblPress);
            this.groupBox2.Controls.Add(this.lblTime);
            this.groupBox2.Controls.Add(this.lblBookKind);
            this.groupBox2.Controls.Add(this.lblBookName);
            this.groupBox2.Controls.Add(this.alterButtom);
            this.groupBox2.Controls.Add(this.deleteBook);
            this.groupBox2.Location = new System.Drawing.Point(57, 574);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1354, 172);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "可修改部分";
            // 
            // exitButtom
            // 
            this.exitButtom.Location = new System.Drawing.Point(914, 70);
            this.exitButtom.Margin = new System.Windows.Forms.Padding(4);
            this.exitButtom.Name = "exitButtom";
            this.exitButtom.Size = new System.Drawing.Size(150, 28);
            this.exitButtom.TabIndex = 51;
            this.exitButtom.Text = "退出";
            this.exitButtom.UseVisualStyleBackColor = true;
            this.exitButtom.Click += new System.EventHandler(this.exitButtom_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(702, 29);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 32);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "刷新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // bookNameText
            // 
            this.bookNameText.Location = new System.Drawing.Point(167, 24);
            this.bookNameText.Margin = new System.Windows.Forms.Padding(4);
            this.bookNameText.Name = "bookNameText";
            this.bookNameText.ReadOnly = true;
            this.bookNameText.Size = new System.Drawing.Size(148, 28);
            this.bookNameText.TabIndex = 48;
            // 
            // BSDateText
            // 
            this.BSDateText.Location = new System.Drawing.Point(167, 70);
            this.BSDateText.Margin = new System.Windows.Forms.Padding(4);
            this.BSDateText.Name = "BSDateText";
            this.BSDateText.Size = new System.Drawing.Size(148, 28);
            this.BSDateText.TabIndex = 46;
            // 
            // ISBNText
            // 
            this.ISBNText.Location = new System.Drawing.Point(436, 24);
            this.ISBNText.Margin = new System.Windows.Forms.Padding(4);
            this.ISBNText.Name = "ISBNText";
            this.ISBNText.Size = new System.Drawing.Size(157, 28);
            this.ISBNText.TabIndex = 44;
            // 
            // lblPress
            // 
            this.lblPress.AutoSize = true;
            this.lblPress.Location = new System.Drawing.Point(335, 70);
            this.lblPress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPress.Name = "lblPress";
            this.lblPress.Size = new System.Drawing.Size(98, 18);
            this.lblPress.TabIndex = 43;
            this.lblPress.Text = "图书状态：";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(61, 70);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(98, 18);
            this.lblTime.TabIndex = 42;
            this.lblTime.Text = "入库时间：";
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
            this.alterButtom.Location = new System.Drawing.Point(914, 26);
            this.alterButtom.Margin = new System.Windows.Forms.Padding(4);
            this.alterButtom.Name = "alterButtom";
            this.alterButtom.Size = new System.Drawing.Size(150, 32);
            this.alterButtom.TabIndex = 37;
            this.alterButtom.Text = "修改书目";
            this.alterButtom.UseVisualStyleBackColor = true;
            this.alterButtom.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // deleteBook
            // 
            this.deleteBook.Location = new System.Drawing.Point(702, 70);
            this.deleteBook.Margin = new System.Windows.Forms.Padding(4);
            this.deleteBook.Name = "deleteBook";
            this.deleteBook.Size = new System.Drawing.Size(150, 32);
            this.deleteBook.TabIndex = 32;
            this.deleteBook.Text = "删除书目";
            this.deleteBook.UseVisualStyleBackColor = true;
            this.deleteBook.Click += new System.EventHandler(this.deleteBook_Click);
            // 
            // lblBookKind
            // 
            this.lblBookKind.AutoSize = true;
            this.lblBookKind.Location = new System.Drawing.Point(335, 30);
            this.lblBookKind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookKind.Name = "lblBookKind";
            this.lblBookKind.Size = new System.Drawing.Size(62, 18);
            this.lblBookKind.TabIndex = 41;
            this.lblBookKind.Text = "ISBN：";
            // 
            // BSStatusText
            // 
            this.BSStatusText.FormattingEnabled = true;
            this.BSStatusText.Items.AddRange(new object[] {
            "在库",
            "借出",
            "丢失",
            "损坏"});
            this.BSStatusText.Location = new System.Drawing.Point(436, 67);
            this.BSStatusText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BSStatusText.Name = "BSStatusText";
            this.BSStatusText.Size = new System.Drawing.Size(157, 26);
            this.BSStatusText.TabIndex = 54;
            // 
            // BooksStore
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
            this.Name = "BooksStore";
            this.Text = "图书馆藏管理";
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
        private System.Windows.Forms.TextBox BSDateText;
        private System.Windows.Forms.TextBox ISBNText;
        private System.Windows.Forms.Label lblPress;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Button alterButtom;
        private System.Windows.Forms.Button searchBookButtom;
        private System.Windows.Forms.Label lblBookNameForSearch;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Button deleteBook;
        private System.Windows.Forms.DataGridView booksDVG;
        private System.Windows.Forms.Button searchByKindButtom;
        private System.Windows.Forms.Label lblKind;
        private System.Windows.Forms.ComboBox BSStatusComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBookKind;
        private System.Windows.Forms.ComboBox BSStatusText;
    }
}