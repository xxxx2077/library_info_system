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
    public partial class NewReaderAdd : Form
    {
        private string readerName;
        private string readerType;
        private string SNo;
        private string telephone;
        private string sex_str;
        private bool sex;

        Form form;
        DataBaseConection dataBaseConection = new DataBaseConection();
        
        public NewReaderAdd(Form form)
        {         
            InitializeComponent();
            InitializeReaderType();
            this.form = form;
        }

        private void InitializeReaderType()
        {
            DataTable readerTypeTable = dataBaseConection.getReaderType();
            foreach (DataRow dr in readerTypeTable.Rows)
            {
                readerTypeComboBox.Items.Add(dr["RTName"]);
            }
        }

        private void backButtom_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void addReaderButtom_Click(object sender, EventArgs e)
        {
            getInfos();
            if (SNoTextBox.Text == String.Empty || readerTypeComboBox.Text == String.Empty||
                readerNameTextBox.Text == String.Empty || sexComboBox.Text == String.Empty ||telephoneTextBox.Text == String.Empty)
                MessageBox.Show("所有资料不能留空", "提示");
            else
            {
                bool sex = false;
                if (sex_str == "男")
                    sex = true;
                int RTNo = -1;
                switch (readerTypeComboBox.Text.ToString())
                {
                    case "教师":
                        RTNo = 1;
                        break;
                    case "职工":
                        RTNo = 2;
                        break;
                    case "学生":
                        RTNo = 3;
                        break;
                }
                if(RTNo == -1)
                {
                    MessageBox.Show("添加过程出错", "添加失败");
                    return;
                }
                DateTime RDTime = DateTime.Now;
                DateTime RVDtime;
                if (RTNo == 3)
                    RVDtime = RDTime.AddYears(4);
                else
                    RVDtime = RDTime.AddYears(50);
                string RDTime_str = RDTime.ToString("yyyy-MM-dd HH:mm:ss");
                string RVDtime_str = RVDtime.ToString("yyyy-MM-dd HH:mm:ss");
                int res = dataBaseConection.addUser(SNo,readerName, RTNo, telephone,sex, RDTime_str, RVDtime_str);
                switch (res)
                {
                    case 0:
                        MessageBox.Show("你已经成功添加该读者", "添加成功");
                        Clear();
                        break;
                    case 1:
                        MessageBox.Show("添加过程出错", "添加失败");
                        break;
                    case -1:
                        MessageBox.Show("该读者已存在", "添加失败");
                        break;
                }
                   
            }
        }

        public void getInfos()
        {
            SNo = SNoTextBox.Text.ToString().Trim();
            readerName = readerNameTextBox.Text.ToString().Trim();
            readerType = readerTypeComboBox.Text.ToString();
            sex_str = sexComboBox.Text.ToString();
            telephone = telephoneTextBox.Text.ToString().Trim();
        }

        private void Clear()
        {
            SNoTextBox.Clear();
            readerNameTextBox.Clear();
            telephoneTextBox.Clear();
        }
    }
}
