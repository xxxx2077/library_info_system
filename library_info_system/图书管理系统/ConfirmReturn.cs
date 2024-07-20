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
    public partial class ConfirmReturn : Form
    {
        DataBaseConection dataBaseConection = new DataBaseConection();
        Form form;
        private int MID;
        private int rtno;
        private int bsno;
        private string SNo;
        private string bookName;
        private string ISBN;
        private int overdueDays;
        private float price;
        private float fineperday = 1;
        private float losttimes = 2;
        private float damagedtimes = 1;
        public ConfirmReturn(Form form, string bookName,string ISBN,string SNo, int MID,int rtno, int bsno,int overdueDays,float price)
        {
            InitializeComponent();
            this.form = form;
            this.MID = MID;
            this.rtno = rtno;
            this.bsno = bsno;
            this.overdueDays = overdueDays;
            this.price = price;
            this.SNo = SNo;
            this.bookName = bookName;   
            this.ISBN = ISBN;
        }

        private void normalBtn_Click(object sender, EventArgs e)
        {
            if(dataBaseConection.confirmReturn(ISBN,SNo, MID, rtno,bsno,0,false,false,false))
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

        private void OverdueBtn_Click(object sender, EventArgs e)
        {
            float fines = fineperday * overdueDays;
            Fines finesPage = new Fines(form, 2, bookName, ISBN,SNo, MID, rtno, bsno, price, fines);
            finesPage.Show();
            form.Show();
            this.Close();
        }

        private void LostBtn_Click(object sender, EventArgs e)
        {
            float fines = losttimes *price;
            Fines finesPage = new Fines(form, 3, bookName, ISBN, SNo, MID, rtno, bsno, price, fines);
            finesPage.Show();
            form.Show();
            this.Close();
        }

        private void DamagedBtn_Click(object sender, EventArgs e)
        {
            float fines = damagedtimes * price;
            Fines finesPage = new Fines(form, 4, bookName, ISBN, SNo, MID, rtno, bsno, price,fines);
            finesPage.Show();
            form.Show();
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }
    }


}
