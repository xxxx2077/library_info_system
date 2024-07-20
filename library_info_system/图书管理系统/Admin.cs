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
    public partial class Admin : Form
    {
        Form form;
        int MID;
        public Admin(Form form,int MID)
        {
            InitializeComponent();
            this.form = form;
            this.MID = MID;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void UsersManageButton_Click(object sender, EventArgs e)
        {
            ReaderManage readerManage = new ReaderManage(this);
            this.Hide();
            readerManage.Show();
        }

        private void BookManageButton_Click(object sender, EventArgs e)
        {
            BooksManage booksManage = new BooksManage(this, MID);
            this.Hide();
            booksManage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BookStrorageButton_Click(object sender, EventArgs e)
        {
            BooksStore booksStore = new BooksStore(this,MID);
            this.Hide();
            booksStore.Show();
        }

        private void PublisherButton_Click(object sender, EventArgs e)
        {
            Publisher publisher = new Publisher(this);
            this.Hide();
            publisher.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            BorrowList borrowList = new BorrowList(this,MID);
            this.Hide();
            borrowList.Show();
        }

        private void FineButton_Click(object sender, EventArgs e)
        {
            FineSelectPage fineSelectPage = new FineSelectPage(this);
            this.Hide();
            fineSelectPage.Show();
        }
    }
}
