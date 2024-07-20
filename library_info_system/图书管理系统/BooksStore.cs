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
    public partial class BooksStore : Form
    {
        Form form;
        DataBaseConection dataBaseConection = new DataBaseConection();

        private string ISBN;
        private int MID;
        private int BSNo;
        int BSStatus = -1;

        public BooksStore(Form form,int MID)
        {
            InitializeComponent();
            this.form = form;
            this.MID = MID;
            BSStatusComboBox.SelectedIndex = 0;
            showBookStoreInfo();
        }

        private void exitButtom_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string bookName = bookNameTextBox.Text;
            if (bookNameTextBox.Text == String.Empty)
                MessageBox.Show("书名不能为空", "搜索终止");
            else
            {
                if (dataBaseConection.seekBookStoreByName(bookName).Rows.Count == 0)
                    MessageBox.Show("查无此书", "查询结果");
                else
                    booksDVG.DataSource = dataBaseConection.seekBookStoreByName(bookName);
                booksDVG.BackgroundColor = Color.White;
            }
            bookNameTextBox.Clear();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (bookNameText.Text == String.Empty || ISBNText.Text == String.Empty
                || BSStatusText.Text == String.Empty || BSDateText.Text == String.Empty)
            {
                MessageBox.Show("所有项目数据不应该为空", "修改失败");
                return;
            }
            else
            {
                string BSStatus_str = BSStatusText.Text.ToString();
                switch (BSStatus_str)
                {
                    case "在库":
                        BSStatus = 0;
                        break;
                    case "借出":
                        BSStatus = 1;
                        break;
                    case "丢失":
                        BSStatus = 2;
                        break;
                    case "损坏":
                        BSStatus = 3;
                        break;
                }
                DateTime dt = Convert.ToDateTime(BSDateText.Text.ToString());
                string BSDate = dt.ToString("yyyy-MM-dd HH:mm:ss");
                dataBaseConection.bookStoreInfoChange(BSNo,ISBN, BSDate,
                   BSStatus);
                showBookStoreInfo();
                MessageBox.Show("修改成功", "修改结果");

            }
        }

        private void searchByKindButtom_Click(object sender, EventArgs e)
        {
            string BSStatus_str = BSStatusComboBox.SelectedItem.ToString();
            switch (BSStatus_str)
            {
                case "在库":
                    BSStatus = 0;
                    break;
                case "借出":
                    BSStatus = 1;
                    break;
                case "丢失":
                    BSStatus = 2;
                    break;
                case "损坏":
                    BSStatus = 3;
                    break;
            }
            booksDVG.DataSource = dataBaseConection.seekBookStoreByBSStatus(BSStatus);
        }

        private void booksDVG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateInfo();
        }

        private void deleteBook_Click(object sender, EventArgs e)
        {
            BSNo = int.Parse(booksDVG.CurrentRow.Cells[0].Value.ToString());
            ISBN = booksDVG.CurrentRow.Cells[2].Value.ToString();
            dataBaseConection.bookStoreDelete(BSNo,ISBN);
            showBookStoreInfo();
            MessageBox.Show("书籍删除成功", "消息提示");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            showBookStoreInfo();
        }

        public void updateInfo()
        {
            BSNo = int.Parse(booksDVG.CurrentRow.Cells[0].Value.ToString());
            ISBN = booksDVG.CurrentRow.Cells[2].Value.ToString();
            string[] bookstoreinfos = dataBaseConection.bookStoreInfos(BSNo,ISBN);
            bookNameText.Text = bookstoreinfos[1];
            ISBNText.Text = bookstoreinfos[2];
            BSDateText.Text = bookstoreinfos[3];
            BSStatus = int.Parse(bookstoreinfos[4]);
            switch (BSStatus)
            {
                case 0:
                    BSStatusText.Text = "在库";
                    break;
                case 1:
                    BSStatusText.Text = "借出";
                    break;
                case 2:
                    BSStatusText.Text = "丢失";
                    break;
                case 3:
                    BSStatusText.Text = "损坏";
                    break;
            }
            Console.WriteLine(bookstoreinfos[4]);
        }

        public void showBookStoreInfo()
        {
            
            booksDVG.DataSource = dataBaseConection.showBookStoreInfo();
            
        }
    }
}
