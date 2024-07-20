using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 图书管理系统
{
    public partial class readerLogIn : Form
    {
        const string nameLinmit = @"^[0-9]";
        const string passwordLinmit = @"^[a-zA-Z0-9]*$";
        private string sno;
        private string password;
        private int readerType=3;
        Form form;

        public readerLogIn(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }

        public void LoginInfo()
        {
            DataBaseConection dataBaseConection = new DataBaseConection();

            if (nameTextBox.Text == String.Empty || passwordTextBox.Text == String.Empty)
            {
                MessageBox.Show("用户名称或用户密码不能为空", "登录提示");
                Clear();
                return;
            }
            if ((!Regex.IsMatch(nameTextBox.Text, nameLinmit))||(!Regex.IsMatch(passwordTextBox.Text, passwordLinmit)))
            {
                MessageBox.Show("用户名称和用户密码只能由字母和数字组成", "登录提示");
                Clear();
                return;
            }
            else
            {
                sno = nameTextBox.Text;
                password = passwordTextBox.Text;
                commonUI commonUI = new commonUI(this, sno);
                if (dataBaseConection.readerLogin(sno, password, readerType))
                {
                    /*dataBaseConection.LoginRecord(CommonName, DateTime.Now.ToString("F"));*/
                    MessageBox.Show("欢迎您登陆本系统", "消息提示");
                    commonUI.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("您的用户名或密码或读者类型有误", "登陆失败");
                
                Clear();
            }

           
        }

        public void Clear()
        {
            nameTextBox.Clear();
            passwordTextBox.Clear();
            passwordTextBox.Focus();
        }

        private void passwordModificationButton_Click(object sender, EventArgs e)
        {
            Form passwordModification = new PasswordModification(this);
            passwordModification.Show();
            this.Hide();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {          
            LoginInfo();        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Form readerRegister = new readerRegister(this);
            readerRegister.Show();
            this.Hide();
        }

        private void teacherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            number_label.Text = "教师编号";
            readerType = 1;
        }

        private void employeeRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            number_label.Text = "职工编号";
            readerType = 2;
        }

        private void studentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            number_label.Text = "学号";
            readerType = 3;
        }
    }
}
