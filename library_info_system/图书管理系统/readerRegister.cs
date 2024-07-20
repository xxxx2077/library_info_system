using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace 图书管理系统
{
    
    public partial class readerRegister : Form
    {
        private int sex=-1;
        private int RTNo=-1;
        Form form;
        public readerRegister(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void Clear()
        {
            RName_textbox.Clear();
            SNo_textbox.Clear();
            Rtelephone_textbox.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            pwd_textbox1.Clear();
            pwd_textbox2.Clear();
            sex = -1;
            RTNo = -1;
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            DataBaseConection dataBaseConection = new DataBaseConection();
            string RName = RName_textbox.Text.ToString().Trim();
            string SNo = SNo_textbox.Text.ToString().Trim();
            string Rtelephone = Rtelephone_textbox.Text.ToString().Trim();
            string RPwd1 = pwd_textbox1.Text.ToString().Trim();
            string RPwd2 = pwd_textbox2.Text.ToString().Trim();
            DateTime now = DateTime.Now;
            if(RName == String.Empty || SNo == String.Empty || sex==-1||RTNo ==-1||Rtelephone == String.Empty|| RPwd1 == String.Empty|| RPwd2 == String.Empty)
            {
                MessageBox.Show("填写信息不全");
            }
/*            else if (Rtelephone)
            {

            }*/
            else if(RPwd1 != RPwd2)
            {
                MessageBox.Show("两次输入密码不一致");
                pwd_textbox1.Clear();
                pwd_textbox2.Clear();
            }
            else
            {
                int res = dataBaseConection.readerRegister(RName, RTNo, SNo, sex, Rtelephone, RPwd2, now);
                switch (res)
                {
                    case 0:
                        MessageBox.Show("注册成功");
                        Clear();
                        break;
                    case 1:
                        MessageBox.Show("注册失败");
                        Clear();
                        break;
                    case 2:
                        MessageBox.Show("该用户已注册");
                        Clear();
                        break;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            number_label.Text = "学号";
            RTNo = 1;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            number_label.Text = "职工号";
            RTNo = 2;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            number_label.Text = "教师号";
            RTNo = 3;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sex = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sex = 0;
        }

        private void checkBox_pwd2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_pwd2.Checked)
            {
                pwd_textbox2.PasswordChar = '\0';
            }
            else
            {
                pwd_textbox2.PasswordChar = '*';
            }
        }

        private void checkBox_pwd1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pwd1.Checked)
            {
                pwd_textbox1.PasswordChar = '\0';
            }
            else
            {
                pwd_textbox1.PasswordChar = '*';
            }
        }
    }
}
