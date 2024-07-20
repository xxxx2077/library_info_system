namespace 图书管理系统
{
    partial class BorrowList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchBookButtom = new System.Windows.Forms.Button();
            this.lblBookNameForSearch = new System.Windows.Forms.Label();
            this.bookNameTextBox_borrow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.borrowerTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.exitButtom = new System.Windows.Forms.Button();
            this.confirmBtn_borrow = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookNameTextBox_return = new System.Windows.Forms.TextBox();
            this.returnerTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.confirmBtn_return = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BrNoTextBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.borrow__groupbox = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.return_groupbox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.borrow__groupbox.SuspendLayout();
            this.return_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1258, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // searchBookButtom
            // 
            this.searchBookButtom.Location = new System.Drawing.Point(504, 412);
            this.searchBookButtom.Margin = new System.Windows.Forms.Padding(4);
            this.searchBookButtom.Name = "searchBookButtom";
            this.searchBookButtom.Size = new System.Drawing.Size(98, 32);
            this.searchBookButtom.TabIndex = 38;
            this.searchBookButtom.Text = "查找";
            this.searchBookButtom.UseVisualStyleBackColor = true;
            this.searchBookButtom.Click += new System.EventHandler(this.searchBookButtom_Click);
            // 
            // lblBookNameForSearch
            // 
            this.lblBookNameForSearch.AutoSize = true;
            this.lblBookNameForSearch.Location = new System.Drawing.Point(59, 419);
            this.lblBookNameForSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookNameForSearch.Name = "lblBookNameForSearch";
            this.lblBookNameForSearch.Size = new System.Drawing.Size(98, 18);
            this.lblBookNameForSearch.TabIndex = 37;
            this.lblBookNameForSearch.Text = "图书书名：";
            // 
            // bookNameTextBox_borrow
            // 
            this.bookNameTextBox_borrow.Location = new System.Drawing.Point(176, 412);
            this.bookNameTextBox_borrow.Margin = new System.Windows.Forms.Padding(4);
            this.bookNameTextBox_borrow.Name = "bookNameTextBox_borrow";
            this.bookNameTextBox_borrow.Size = new System.Drawing.Size(308, 28);
            this.bookNameTextBox_borrow.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 465);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 39;
            this.label1.Text = "借阅人编号：";
            // 
            // borrowerTextBox
            // 
            this.borrowerTextBox.Location = new System.Drawing.Point(176, 462);
            this.borrowerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.borrowerTextBox.Name = "borrowerTextBox";
            this.borrowerTextBox.Size = new System.Drawing.Size(308, 28);
            this.borrowerTextBox.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 458);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 32);
            this.button1.TabIndex = 41;
            this.button1.Text = "查找";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitButtom
            // 
            this.exitButtom.Location = new System.Drawing.Point(882, 400);
            this.exitButtom.Margin = new System.Windows.Forms.Padding(4);
            this.exitButtom.Name = "exitButtom";
            this.exitButtom.Size = new System.Drawing.Size(150, 48);
            this.exitButtom.TabIndex = 52;
            this.exitButtom.Text = "退出";
            this.exitButtom.UseVisualStyleBackColor = true;
            this.exitButtom.Click += new System.EventHandler(this.exitButtom_Click);
            // 
            // confirmBtn_borrow
            // 
            this.confirmBtn_borrow.Location = new System.Drawing.Point(705, 440);
            this.confirmBtn_borrow.Name = "confirmBtn_borrow";
            this.confirmBtn_borrow.Size = new System.Drawing.Size(140, 50);
            this.confirmBtn_borrow.TabIndex = 53;
            this.confirmBtn_borrow.Text = "借阅办理";
            this.confirmBtn_borrow.UseVisualStyleBackColor = true;
            this.confirmBtn_borrow.Click += new System.EventHandler(this.confirmBtn_borrow_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(0, 26);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 37;
            this.dataGridView2.Size = new System.Drawing.Size(1258, 333);
            this.dataGridView2.TabIndex = 54;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 394);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "图书书名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 444);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 56;
            this.label3.Text = "归还人编号：";
            // 
            // bookNameTextBox_return
            // 
            this.bookNameTextBox_return.Location = new System.Drawing.Point(176, 394);
            this.bookNameTextBox_return.Margin = new System.Windows.Forms.Padding(4);
            this.bookNameTextBox_return.Name = "bookNameTextBox_return";
            this.bookNameTextBox_return.Size = new System.Drawing.Size(308, 28);
            this.bookNameTextBox_return.TabIndex = 57;
            // 
            // returnerTextBox
            // 
            this.returnerTextBox.Location = new System.Drawing.Point(176, 441);
            this.returnerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.returnerTextBox.Name = "returnerTextBox";
            this.returnerTextBox.Size = new System.Drawing.Size(308, 28);
            this.returnerTextBox.TabIndex = 58;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 387);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 32);
            this.button2.TabIndex = 59;
            this.button2.Text = "查找";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(504, 437);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 32);
            this.button3.TabIndex = 60;
            this.button3.Text = "查找";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // confirmBtn_return
            // 
            this.confirmBtn_return.Location = new System.Drawing.Point(705, 398);
            this.confirmBtn_return.Name = "confirmBtn_return";
            this.confirmBtn_return.Size = new System.Drawing.Size(140, 50);
            this.confirmBtn_return.TabIndex = 61;
            this.confirmBtn_return.Text = "归还办理";
            this.confirmBtn_return.UseVisualStyleBackColor = true;
            this.confirmBtn_return.Click += new System.EventHandler(this.confirmBtn_return_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 510);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 63;
            this.label4.Text = "借阅编号：";
            // 
            // BrNoTextBox
            // 
            this.BrNoTextBox.Location = new System.Drawing.Point(176, 507);
            this.BrNoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.BrNoTextBox.Name = "BrNoTextBox";
            this.BrNoTextBox.Size = new System.Drawing.Size(308, 28);
            this.BrNoTextBox.TabIndex = 64;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(504, 503);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 32);
            this.button6.TabIndex = 65;
            this.button6.Text = "查找";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // borrow__groupbox
            // 
            this.borrow__groupbox.Controls.Add(this.button4);
            this.borrow__groupbox.Controls.Add(this.dataGridView1);
            this.borrow__groupbox.Controls.Add(this.lblBookNameForSearch);
            this.borrow__groupbox.Controls.Add(this.label1);
            this.borrow__groupbox.Controls.Add(this.button6);
            this.borrow__groupbox.Controls.Add(this.label4);
            this.borrow__groupbox.Controls.Add(this.BrNoTextBox);
            this.borrow__groupbox.Controls.Add(this.borrowerTextBox);
            this.borrow__groupbox.Controls.Add(this.bookNameTextBox_borrow);
            this.borrow__groupbox.Controls.Add(this.button1);
            this.borrow__groupbox.Controls.Add(this.searchBookButtom);
            this.borrow__groupbox.Controls.Add(this.confirmBtn_borrow);
            this.borrow__groupbox.Location = new System.Drawing.Point(30, 23);
            this.borrow__groupbox.Name = "borrow__groupbox";
            this.borrow__groupbox.Size = new System.Drawing.Size(1258, 538);
            this.borrow__groupbox.TabIndex = 69;
            this.borrow__groupbox.TabStop = false;
            this.borrow__groupbox.Text = "借阅信息表";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(882, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 50);
            this.button4.TabIndex = 66;
            this.button4.Text = "刷新";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // return_groupbox
            // 
            this.return_groupbox.Controls.Add(this.confirmBtn_return);
            this.return_groupbox.Controls.Add(this.dataGridView2);
            this.return_groupbox.Controls.Add(this.label2);
            this.return_groupbox.Controls.Add(this.button3);
            this.return_groupbox.Controls.Add(this.button2);
            this.return_groupbox.Controls.Add(this.label3);
            this.return_groupbox.Controls.Add(this.bookNameTextBox_return);
            this.return_groupbox.Controls.Add(this.returnerTextBox);
            this.return_groupbox.Controls.Add(this.exitButtom);
            this.return_groupbox.Location = new System.Drawing.Point(30, 567);
            this.return_groupbox.Name = "return_groupbox";
            this.return_groupbox.Size = new System.Drawing.Size(1258, 501);
            this.return_groupbox.TabIndex = 70;
            this.return_groupbox.TabStop = false;
            this.return_groupbox.Text = "归还信息表";
            // 
            // BorrowList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 1057);
            this.Controls.Add(this.borrow__groupbox);
            this.Controls.Add(this.return_groupbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BorrowList";
            this.Text = "借阅清单";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.borrow__groupbox.ResumeLayout(false);
            this.borrow__groupbox.PerformLayout();
            this.return_groupbox.ResumeLayout(false);
            this.return_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchBookButtom;
        private System.Windows.Forms.Label lblBookNameForSearch;
        private System.Windows.Forms.TextBox bookNameTextBox_borrow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox borrowerTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitButtom;
        private System.Windows.Forms.Button confirmBtn_borrow;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookNameTextBox_return;
        private System.Windows.Forms.TextBox returnerTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button confirmBtn_return;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BrNoTextBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox borrow__groupbox;
        private System.Windows.Forms.GroupBox return_groupbox;
        private System.Windows.Forms.Button button4;
    }
}