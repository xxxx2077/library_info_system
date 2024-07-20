using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 图书管理系统
{
    public partial class adminLogIn : Form
    {
        const string nameLinmit = @"^[a-zA-Z0-9]*$";
        const string passwordLinmit = @"^[a-zA-Z0-9]*$";
        private string telephone;
        private string password;
        private int MID;
        Form form;     

        public adminLogIn(Form form)
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
            telephone = nameTextBox.Text;
            
            DataBaseConection dataBaseConection = new DataBaseConection();

            if (nameTextBox.Text == String.Empty || passwordTextBox.Text == String.Empty)
            {
                MessageBox.Show("用户名称或用户密码不能为空", "登陆提示");
                Clear();
                return;
            }
            if ((!Regex.IsMatch(nameTextBox.Text, nameLinmit))||(!Regex.IsMatch(passwordTextBox.Text, passwordLinmit)))
            {
                MessageBox.Show("用户名称和用户密码只能由字母和数字组成", "登陆提示");
                Clear();
                return;
            }
            else
            {
                telephone = nameTextBox.Text;
                password = passwordTextBox.Text;
                MID = dataBaseConection.adminLogin(telephone, password);
                if (MID>0)
                {
                    /*dataBaseConection.LoginRecord(CommonName, DateTime.Now.ToString("F"));*/
                    Admin admin = new Admin(this, MID);
                    MessageBox.Show("欢迎您登陆本系统", "消息提示");           
                    admin.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("您的用户名或密码有误", "登陆失败");
                
                Clear();
            }

           
        }

        public void Clear()
        {
            nameTextBox.Clear();
            passwordTextBox.Clear();
            nameTextBox.Focus();
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
    }
}
