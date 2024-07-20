using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class BorrowList : Form
    {
        DataBaseConection dataBaseConection = new DataBaseConection();
        DataTable borrowTable;
        DataTable returnTable;
        Form form;
        private int brno;
        private int btno;
        private int bsno;
        private int rtno;
        private int MID;
        private string bookName;
        private int overdueDays=0;
        private float price = 0;
        private string SNo;
        private string ISBN;
        private bool BtStatus;
        public BorrowList(Form form,int MID)
        {
            InitializeComponent();
            this.form = form;
            this.MID = MID;
            showInfo();
        }


        //图书查找
        private void searchBookButtom_Click(object sender, EventArgs e)
        {
            string bookName = bookNameTextBox_borrow.Text;
            if (bookNameTextBox_borrow.Text == String.Empty)
                MessageBox.Show("书名不能为空", "搜索终止");
            else
            {
                if (dataBaseConection.seekBorrowRecordByBookName(bookName).Rows.Count == 0)
                    MessageBox.Show("查无此书", "查询结果");
                else
                    dataGridView1.DataSource = dataBaseConection.seekBorrowRecordByBookName(bookName);
                    dataGridView1.BackgroundColor = Color.White;
            }
        }

        //按用户名查找
        private void button1_Click(object sender, EventArgs e)
        {
            string SNo = borrowerTextBox.Text;
            if (borrowerTextBox.Text == String.Empty)
                MessageBox.Show("名字不能为空", "搜索终止");
            else
            {
                if (dataBaseConection.seekBorrowRecordByUserName(SNo).Rows.Count == 0)
                    MessageBox.Show("查无此书", "查询结果");
                else
                    dataGridView1.DataSource = dataBaseConection.seekBorrowRecordByUserName(SNo);
                    dataGridView1.BackgroundColor = Color.White;
            }

        }

        //按借阅编号查找
        private void button6_Click(object sender, EventArgs e)
        {
            string BrNo = BrNoTextBox.Text;
            if (BrNoTextBox.Text == String.Empty)
                MessageBox.Show("名字不能为空", "搜索终止");
            else
            {
                if (dataBaseConection.seekBorrowRecordByBrNo(BrNo).Rows.Count == 0)
                    MessageBox.Show("查无此书", "查询结果");
                else
                    dataGridView1.DataSource = dataBaseConection.seekBorrowRecordByBrNo(BrNo);
                dataGridView1.BackgroundColor = Color.White;
            }
        }

        public void showInfo()
        {
            borrowTable = dataBaseConection.showborrow();
            dataGridView1.DataSource = borrowTable;
            returnTable = dataBaseConection.showReturn();
            dataGridView2.DataSource = returnTable;
        }

        private void exitButtom_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string s = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            bsno = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            if (s != string.Empty)
            {
                brno = int.Parse(s);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            string s = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            brno = int.Parse(dataGridView2.CurrentRow.Cells[1].Value.ToString());
            foreach(DataRow dr in borrowTable.Rows)
            {
                if (int.Parse(dr["借书序号"].ToString()) == brno)
                {
                    bsno = (int)dr["馆藏图书编号"];
                    ISBN = (string)dr["ISBN"];
                }
            }          
            bookName = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            overdueDays = int.Parse(dataGridView2.CurrentRow.Cells[8].Value.ToString());
            SNo = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            price = float.Parse(dataGridView2.CurrentRow.Cells[10].Value.ToString());
            BtStatus = bool.Parse(dataGridView2.CurrentRow.Cells[7].Value.ToString());
            if (s!= string.Empty)
            {
                rtno = int.Parse(s);
            }
        }


        private void confirmBtn_borrow_Click(object sender, EventArgs e)
        {          
            dataBaseConection.confirmBorrow(MID,brno,bsno);
            showInfo();
        }

        private void confirmBtn_return_Click(object sender, EventArgs e)
        {
            if (BtStatus)
                MessageBox.Show("请勿重复办理","办理失败");
            else
            {
                ConfirmReturn confirmReturn = new ConfirmReturn(this, bookName, ISBN,SNo, MID, rtno, bsno, overdueDays, price);
                this.Hide();
                confirmReturn.Show();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bookName = bookNameTextBox_return.Text;
            if (bookNameTextBox_return.Text == String.Empty)
                MessageBox.Show("书名不能为空", "搜索终止");
            else
            {
                if (dataBaseConection.seekReturnRecordByBookName(bookName).Rows.Count == 0)
                    MessageBox.Show("查无此书", "查询结果");
                else
                    dataGridView2.DataSource = dataBaseConection.seekReturnRecordByBookName(bookName);
                dataGridView2.BackgroundColor = Color.White;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string SNo = returnerTextBox.Text;
            if (returnerTextBox.Text == String.Empty)
                MessageBox.Show("名字不能为空", "搜索终止");
            else
            {
                if (dataBaseConection.seekReturnRecordBySNo(SNo).Rows.Count == 0)
                    MessageBox.Show("查无此书", "查询结果");
                else
                    dataGridView2.DataSource = dataBaseConection.seekReturnRecordBySNo(SNo);
                dataGridView2.BackgroundColor = Color.White;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showInfo();
        }
    }
}
