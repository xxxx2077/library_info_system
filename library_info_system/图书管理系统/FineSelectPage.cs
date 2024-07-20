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
    public partial class FineSelectPage : Form
    {
        Form form;
        public FineSelectPage(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OverdueFine od = new OverdueFine(this);
            this.Hide();
            od.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DamagedFine df = new DamagedFine(this);
            this.Hide();
            df.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LostFine lf = new LostFine(this);
            this.Hide();
            lf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }
    }
}
