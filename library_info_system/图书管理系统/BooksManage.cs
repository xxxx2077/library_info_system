using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class BooksManage : Form
    {
        Form form;
        DataBaseConection dataBaseConection = new DataBaseConection();

        private string bookID;
        private int MID;

        public string BookID { get { return bookID; } }

        public BooksManage(Form form,int MID)
        {
            InitializeComponent();
            this.form = form;
            this.MID = MID; 
            /*bookClassComboBox.SelectedIndex = 0;*/
            InitializeBookType();
            InitializePublisher();
            showBook();
        }

        private void InitializePublisher()
        {
            DataTable PublisherTable = dataBaseConection.getPublisher();
            foreach (DataRow dr in PublisherTable.Rows)
            {

                PublisherComboBox.Items.Add(dr["出版社名称"]);
            }
        }

        private void InitializeBookType()
        {
            DataTable bookTypeTable = dataBaseConection.getBookType();
            foreach (DataRow dr in bookTypeTable.Rows)
            {

                bookTypeComboBox.Items.Add(dr["BTName"]);
                bookClassComboBox.Items.Add(dr["BTName"]);
            }
        }
        
        private void exitButtom_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void bookAddButtom_Click(object sender, EventArgs e)
        {
            NewBookAdd newBookAdd = new NewBookAdd(this);
            newBookAdd.Show();
            this.Hide();
        }

        private void borrowRwcordButtom_Click(object sender, EventArgs e)
        {
            BorrowList borrowRecord = new BorrowList(this,MID);
            borrowRecord.Show();
            this.Hide();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
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
                    booksDVG.DataSource = res;
                    booksDVG.BackgroundColor = Color.White;
                }
                    
            }
            bookNameTextBox.Clear();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (bookDigestTextBox.Text == String.Empty || bookNameText.Text == String.Empty || bookTypeComboBox.Text == String.Empty
                || PublisherComboBox.Text == String.Empty || authorText.Text == String.Empty || publishTimeText.Text == String.Empty||
                ISBNBox.Text == String.Empty || priceBox.Text == String.Empty)
            {
                MessageBox.Show("所有项目数据不应该为空", "修改失败");
                return;
            }
            else
            {
                
                dataBaseConection.bookInfoChange(ISBNBox.Text.ToString(), bookNameText.Text.ToString(), bookTypeComboBox.Text.ToString(),
                   PublisherComboBox.Text.ToString(), authorText.Text.ToString(), editionBox.Text.ToString(),publishTimeText.Text.ToString(), priceBox.Text.ToString());
                showBook();
                MessageBox.Show("修改成功", "修改结果");

            }
        }

        private void searchByKindButtom_Click(object sender, EventArgs e)
        {
            string bookType = bookClassComboBox.SelectedItem.ToString();
            if(bookType == string.Empty)
            {
                MessageBox.Show("类型名不能为空", "搜索终止");
            }
            else
            {
                DataTable res = dataBaseConection.seekBookByType(bookType);
                if (res.Rows.Count == 0)
                    MessageBox.Show("查无此书", "查询结果");
                else
                {
                    booksDVG.DataSource = res;
                    booksDVG.BackgroundColor = Color.White;
                }
            }
            
        }

        private void booksDVG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateInfo();
        }

        private void deleteBook_Click(object sender, EventArgs e)
        {
            string ISBN= booksDVG.CurrentRow.Cells[0].Value.ToString();
            dataBaseConection.bookDelete(ISBN);
            showBook();
            MessageBox.Show("书籍删除成功", "消息提示");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            showBook();
        }

        public void updateInfo()
        {
            string ISBN = booksDVG.CurrentRow.Cells[0].Value.ToString();
            string[] bookinfos = dataBaseConection.bookinfos(ISBN);
            bookDigestTextBox.Text = bookinfos[0];
            bookNameText.Text = bookinfos[1];
            bookTypeComboBox.Text = bookinfos[2];
            PublisherComboBox.Text = bookinfos[3];
            authorText.Text = bookinfos[4];
            publishTimeText.Text = bookinfos[5];
            ISBNBox.Text = bookinfos[6];
            priceBox.Text = bookinfos[7];
            editionBox.Text = bookinfos[8];
        }

        public void showBook()
        {
            
            booksDVG.DataSource = dataBaseConection.showBookInfo();
            
        }

        private void addBookStoreButton_Click(object sender, EventArgs e)
        {
            int res = dataBaseConection.addNewBook(true, bookNameText.Text.ToString().Trim(), 
                bookTypeComboBox.Text.ToString().Trim(), authorText.Text.ToString().Trim(),
                PublisherComboBox.Text.ToString().Trim(), publishTimeText.Text.ToString().Trim(), 
                editionBox.Text.ToString().Trim(), ISBNBox.Text.ToString().Trim(), bookDigestTextBox.Text.ToString().Trim(),
                float.Parse(priceBox.Text.ToString().Trim()));
            switch (res)
            {
                case 0:
                    MessageBox.Show("你已经成功添加这本书", "添加成功");
                    break;
                case 1:
                    MessageBox.Show("添加过程出错", "添加失败");
                    break;
                case -1:
                    MessageBox.Show("出版社或书籍类型不存在", "添加失败");
                    break;
            }
            showBook();
        }
    }
}
