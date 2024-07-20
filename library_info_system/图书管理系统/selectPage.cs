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
    public partial class selectPage : Form
    {
        Form form;
        public selectPage(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void reader_btn_Click(object sender, EventArgs e)
        {
            Form rl = new readerLogIn(this);
            this.Hide();
            rl.ShowDialog();
            //Application.ExitThread();
        }

        private void manager_btn_Click(object sender, EventArgs e)
        {
            Form al = new adminLogIn(this);
            this.Hide();
            al.ShowDialog();
           // Application.ExitThread();
        }
    }
}
