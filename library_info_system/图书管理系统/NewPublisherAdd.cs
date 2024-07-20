using MySqlX.XDevAPI.Relational;
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
    public partial class NewPublisherAdd : Form
    {
        private string pressName;
        private string pressManager;
        private string province;
        private string city;
        private string telephone;
        private string addr;

        Form form;
        DataBaseConection dataBaseConection = new DataBaseConection();
        
        public NewPublisherAdd(Form form)
        {         
            InitializeComponent();
            this.form = form;
        }

        private void backButtom_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void addPublisherButton_Click(object sender, EventArgs e)
        {
            getInfos();
            if (pressNameTextBox.Text == String.Empty || provinceComboBox.Text == String.Empty||addrTextBox.Text == String.Empty||
                managerTextBox.Text == String.Empty || cityComboBox.Text == String.Empty ||telephoneTextBox.Text == String.Empty)
                MessageBox.Show("所有资料不能留空", "提示");
            else
            {
                int res = dataBaseConection.addPublisher(pressName,pressManager, telephone, province,city, addr);
                switch (res)
                {
                    case 0:
                        MessageBox.Show("你已经成功添加该出版社", "添加成功");
                        Clear();
                        break;
                    case 2:
                        MessageBox.Show("添加过程出错", "添加失败");
                        break;
                    case 1:
                        MessageBox.Show("该出版社已存在", "添加失败");
                        break;
                }
                   
            }
        }

        public void getInfos()
        {
            pressName = pressNameTextBox.Text.ToString().Trim();
            pressManager = managerTextBox.Text.ToString().Trim();
            province = provinceComboBox.Text.ToString();
            city = cityComboBox.Text.ToString();
            telephone = telephoneTextBox.Text.ToString().Trim();
            addr = addrTextBox.Text.ToString().Trim();
        }

        private void Clear()
        {
            pressNameTextBox.Clear();
            managerTextBox.Clear();
            telephoneTextBox.Clear();
            addrTextBox.Clear();
        }
    }
}
