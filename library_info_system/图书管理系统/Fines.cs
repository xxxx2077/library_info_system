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
    public partial class Fines : Form
    {
        Form form;
        DataBaseConection dataBaseConection = new DataBaseConection();
        private float fines;
        private int MID;
        private int rtno;
        private int bsno;
        private int num;
        private string bookName;
        private string ISBN;
        private string SNo;
        public Fines(Form form,int num,string bookName, string ISBN,string SNo,int MID, int rtno, int bsno, float price,float fines)
        {
            InitializeComponent();
            this.form = form;
            this.MID = MID;
            this.rtno = rtno;
            this.bsno = bsno;
            this.fines = fines;
            this.num = num;
            this.SNo = SNo;
            this.bookName = bookName;
            this.ISBN = ISBN;
            bookNameTextBox.Text = bookName;
            PriceTextBox.Text = price.ToString();
            FinesTextBox.Text = fines.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(num){
                case 2:
                    {
                        if (dataBaseConection.confirmReturn(ISBN,SNo,MID, rtno, bsno, fines,true, false, false))
                        {
                            MessageBox.Show("成功办理", "办理成功");
                        }
                        else
                        {
                            MessageBox.Show("办理失败", "办理失败");
                        }
                        form.Show();
                        this.Close();
                    }
                    break;
                case 3:
                    {
                        if (dataBaseConection.confirmReturn(ISBN, SNo, MID, rtno, bsno, fines, false, false, true))
                        {
                            MessageBox.Show("成功办理", "办理成功");
                        }
                        else
                        {
                            MessageBox.Show("办理失败", "办理失败");
                        }
                        form.Show();
                        this.Close();
                    }
                    break;
                case 4:
                    {
                        if (dataBaseConection.confirmReturn(ISBN, SNo, MID, rtno, bsno, fines, false, true, false))
                        {
                            MessageBox.Show("成功办理", "办理成功");
                        }
                        else
                        {
                            MessageBox.Show("办理失败", "办理失败");
                        }
                        form.Show();
                        this.Close();
                    }
                    break;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }
    }
}
