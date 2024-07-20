using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class Publisher : Form
    {
        Form form;
        DataBaseConection dataBaseConection = new DataBaseConection();

        private string pressName;
        private string linkman;
        private string telephone;
        private string province;
        private string city;
        private string addr;
        private int PID;

        public Publisher(Form form)
        {
            InitializeComponent();
            this.form = form;
            showPublisherInfo();
        }

        private void exitButtom_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void bookAddButtom_Click(object sender, EventArgs e)
        {
            NewPublisherAdd newPublisherAdd = new NewPublisherAdd(this);
            newPublisherAdd.Show();
            this.Hide();
        }

        private void btnSearchPublisher_Click(object sender, EventArgs e)
        {
            string pressName = pressNameTextBox.Text;
            if (pressNameTextBox.Text == String.Empty)
                MessageBox.Show("出版社名不能为空", "搜索终止");
            else
            {
                if (dataBaseConection.seekPublisherByName(pressName).Rows.Count == 0)
                    MessageBox.Show("查无此出版社", "查询结果");
                else
                    booksDVG.DataSource = dataBaseConection.seekPublisherByName(pressName);
                booksDVG.BackgroundColor = Color.White;
                pressNameTextBox.Clear();
            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            pressName = pressNameText.Text;
            linkman = linkmanText.Text;
            telephone = telephoneText.Text;
            province = provinceText.Text;
            city = cityText.Text;
            addr = addrText.Text;
            if (pressNameText.Text == String.Empty || telephoneText.Text == String.Empty || addrText.Text == String.Empty
                || provinceText.Text == String.Empty || cityText.Text == String.Empty || linkmanText.Text == String.Empty)
            {
                MessageBox.Show("所有项目数据不应该为空", "修改失败");
                return;
            }
            else
            {
                dataBaseConection.PublisherInfoChange(PID, pressName, linkman,telephone, province, city, addr);
                showPublisherInfo();
                MessageBox.Show("修改成功", "修改结果");

            }
        }

        private void booksDVG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateInfo();
        } 

        private void deletePublisher_Click(object sender, EventArgs e)
        {
            PID = int.Parse(booksDVG.CurrentRow.Cells[0].Value.ToString());
            dataBaseConection.deletePublisher(PID);
            showPublisherInfo();
            MessageBox.Show("出版社删除成功", "消息提示");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            showPublisherInfo();
        }

        public void updateInfo()
        {
            PID = int.Parse(booksDVG.CurrentRow.Cells[0].Value.ToString());
            string[] publisherinfos = dataBaseConection.PublisherInfos(PID);
            pressNameText.Text = publisherinfos[1];
            linkmanText.Text = publisherinfos[2];
            telephoneText.Text = publisherinfos[3];
            provinceText.Text = publisherinfos[4];
            cityText.Text = publisherinfos[5];
            addrText.Text = publisherinfos[6];
            pressName = pressNameText.Text;
            linkman = linkmanText.Text;
            telephone = telephoneText.Text;
            province = provinceText.Text;
            city = cityText.Text;
            addr = addrText.Text;
        }

        public void showPublisherInfo()
        {

            booksDVG.DataSource = dataBaseConection.getPublisher();
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            NewPublisherAdd newPublisherAdd = new NewPublisherAdd(this);
            newPublisherAdd.Show();
            this.Hide();
        }
    }
}
