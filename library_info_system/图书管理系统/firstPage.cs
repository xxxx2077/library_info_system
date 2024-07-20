using System;
using System.Drawing;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class firstPage : Form
    {
        public firstPage()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogInlinkLabel.LinkVisited = true;
            Form selectPage = new selectPage(this);
            selectPage.Show();
            //this.Hide();
            
        }

        Image cyImage;
        private void Form1_Load(object sender, EventArgs e)
        {
            cyImage = Properties.Resources.sysu;
            pictureBox.Image = cyImage;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
