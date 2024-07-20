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
    public partial class NewBookAdd : Form
    {
        private string bookName;
        private string bookType;
        private string isbn;
        private string writer;
        private string publisher;
        private string content;
        private string bpdate;
        private float price;
        private string edition;

        public string ISBN { get { return isbn; } }
        public string Content { get { return content; } }

        Form form;
        DataBaseConection dataBaseConection = new DataBaseConection();

        public NewBookAdd(Form form)
        {
            InitializeComponent();
            InitializeBookType();
            InitializePublisher();
            this.form = form;
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
            }
        }

        private void backButtom_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void addBookButtom_Click(object sender, EventArgs e)
        {     
            if (bookNameTextBox.Text == String.Empty || bookTypeComboBox.Text == String.Empty
                || PublisherComboBox.Text == String.Empty || PriceTextBox.Text == String.Empty ||
                EditionTextBox.Text == String.Empty || ISBNTextBox.Text == String.Empty ||
                authorTextBox.Text == String.Empty || ISBNTextBox.Text == String.Empty ||
                BPDateTextBox.Text == String.Empty 
                 || contentTextBox.Text == String.Empty)
                MessageBox.Show("所有资料不能留空", "提示");
            else
            {
                getInfos();
                int res = dataBaseConection.addNewBook(false,bookName, bookType, writer, publisher,
                   bpdate, edition, ISBN, Content, price);
                switch (res)
                {
                    case 0:
                        MessageBox.Show("你已经成功添加这本书", "添加成功");
                        Clear();
                        break;
                    case 1:
                        MessageBox.Show("添加过程出错", "添加失败");
                        break;
                    case -1:
                        MessageBox.Show("出版社或书籍类型不存在", "添加失败");
                        break;
                }
                   
            }
        }

        public void getInfos()
        {
            bookName = bookNameTextBox.Text.ToString().Trim();
            bookType = bookTypeComboBox.Text.ToString();
            publisher = PublisherComboBox.Text.ToString();
            price = float.Parse(PriceTextBox.Text.ToString().Trim());
            edition = EditionTextBox.Text.ToString().Trim();
            isbn = ISBNTextBox.Text.ToString().Trim();    
            bpdate = BPDateTextBox.Text.ToString().Trim();
            content = contentTextBox.Text.ToString().Trim();
            writer = authorTextBox.Text.ToString().Trim();
            
        }

        private void Clear()
        {
            bookNameTextBox.Clear();
            PriceTextBox.Clear();
            EditionTextBox.Clear();
            ISBNTextBox.Clear();
            BPDateTextBox.Clear();
            contentTextBox.Clear();
            authorTextBox.Clear();

        }
    }
}
