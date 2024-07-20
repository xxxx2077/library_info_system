using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class commonUI : Form
    {
        Form form;
        string sno;
        DataBaseConection dataBaseConection = new DataBaseConection();
        DataTable dt = new DataTable();
        string BExnum;
        string ISBN;
        public commonUI(Form form,string SNo)
        {
            InitializeComponent();
            this.form = form;
            this.sno = SNo;
            showBookInfo(getBookInfo());
            showBookMoreInfo(0);
            InitializeBookType();
        }

        private void InitializeBookType()
        {
            DataTable bookTypeTable = dataBaseConection.getBookType();
            foreach (DataRow dr in bookTypeTable.Rows)
            {

                bookClassComboBox.Items.Add(dr["BTName"]);
            }
        }

        private void showBookMoreInfo(int rowIndex)
        {
            ISBN = dt.Rows[rowIndex][0].ToString();
            string BName = dt.Rows[rowIndex][1].ToString();
            string BWriter = dt.Rows[rowIndex][2].ToString();
            string BTName = dt.Rows[rowIndex][3].ToString();
            string BEdition = dt.Rows[rowIndex][4].ToString();
            string PName = dt.Rows[rowIndex][5].ToString();
            string BPDate = dt.Rows[rowIndex][6].ToString();
            string BIntro = dt.Rows[rowIndex][8].ToString();
            BExnum = dt.Rows[rowIndex][9].ToString();
            ISBN_textbox.Text = ISBN;
            BName_textbox.Text = BName;
            BWriter_textbox.Text = BWriter;
            BTName_textbox.Text = BTName;
            BEdition_textbox.Text = BEdition;
            PName_textbox.Text = PName;
            bookDigestTextBox.Text = BIntro;
            BExnum_textbox.Text = BExnum;
            BPDate_textbox.Text = BPDate;
        }
        private void btnQuery_Click(object sender, EventArgs e)
        {
            BorrowRecord borrowRecord = new BorrowRecord(this, sno);
            borrowRecord.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void searchBookButtom_Click(object sender, EventArgs e)
        {
            string bookName = bookNameTextBox.Text.ToString();
            if (bookName == String.Empty)
                MessageBox.Show("书名不能为空", "搜索终止");
            else
            {
                DataTable res = dataBaseConection.seekBookByName(bookName);
                if (res.Rows.Count == 0)
                    MessageBox.Show("查无此书", "查询结果");
                else
                {
                    showBookInfo(res);
                    booksDVG.BackgroundColor = Color.White;
                }

            }
        }


        private void searchByKindButtom_Click(object sender, EventArgs e)
        {
            string bookType = bookClassComboBox.SelectedItem.ToString();
            if (bookType == string.Empty)
            {
                MessageBox.Show("类型名不能为空", "搜索终止");
            }
            else
            {
                DataTable res = dataBaseConection.seekBookByType(bookType);
                res.Columns.Remove("现在库数量");
                res.Columns.Remove("库存总量");
                if (res.Rows.Count == 0)
                    MessageBox.Show("查无此书", "查询结果");
                else
                {
                    showBookInfo(res);
                    booksDVG.BackgroundColor = Color.White;
                }
            }

        }

        private void booksDVG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = booksDVG.CurrentCell.RowIndex;
            showBookMoreInfo(rowIndex);
        }

        private void borrowButtoom_Click(object sender, EventArgs e)
        {
            string BName = booksDVG.CurrentRow.Cells[1].Value.ToString();
            int bexnum = int.Parse(BExnum);
            string SNo = sno;
            int res = -1;
            if(bexnum <= 0)
            {
                res = 2;
            }
            else
            {
                res = dataBaseConection.borrowAdd(BName, SNo, ISBN);
            }          
            switch (res){
                case 0:
                    MessageBox.Show("您已提交借阅申请，等待管理员办理", "借书成功");
                    break;
                case 1:
                    MessageBox.Show("您借阅册数已达上限", "借书失败");
                    break;
                case 2:
                    MessageBox.Show("该书已借出", "借书失败");
                    break;
                case 3:
                    MessageBox.Show("借书过程出错", "借书失败");
                    break;
                case -1:
                    MessageBox.Show("系统故障", "借书失败");
                    break;
            }
            showBookInfo(getBookInfo());
        }

        private DataTable getBookInfo()
        {
            dt = dataBaseConection.showBookInfo();
            return dt;
        }

        public void showBookInfo(DataTable dt)
        {         
            DataTable dataTable = new DataTable();
            if (dt != null)
            {
                dataTable = dt.DefaultView.ToTable(false, new string[] { "书名", "图书类型", "作者", "出版社","出版日期"});

            }
            booksDVG.DataSource = dataTable;
        }

        private void lblContent_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            showBookInfo(getBookInfo());
        }
    }
}
