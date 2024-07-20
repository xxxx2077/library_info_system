using System;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class BorrowRecord : Form
    {
        Form form;
        string sno;
        public BorrowRecord(Form form, string sno)
        {
            InitializeComponent();
            this.form = form;
            this.sno = sno;
            showRecord();         
        }

        DataBaseConection DataBaseConection = new DataBaseConection();

        private void btnBack_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            showRecord();
        }

        public void showRecord()
        {
            
            libraryRecordDGV.DataSource=DataBaseConection.borrowRecord(sno);
        }

        private void returnBookButtom_Click(object sender, EventArgs e)
        {
            if (libraryRecordDGV.Rows.Count!=0)
            {
                string t = libraryRecordDGV.CurrentRow.Cells[10].Value.ToString();
                bool isReturn = bool.Parse(t);
                if(isReturn)
                {
                    MessageBox.Show("本书已经归还不需要归还", "归还提示");
                    return;
                }
                DateTime returnTime = DateTime.Now;
                string returnTime_str = returnTime.ToString("yyyy-MM-dd HH:mm:ss");
                int BrNo = int.Parse(libraryRecordDGV.CurrentRow.Cells[0].Value.ToString());
                int BSNo = int.Parse(libraryRecordDGV.CurrentRow.Cells[1].Value.ToString());
                string SNo = libraryRecordDGV.CurrentRow.Cells[4].Value.ToString();
                bool BrStatus = bool.Parse(libraryRecordDGV.CurrentRow.Cells[9].Value.ToString());
                string borrowTime = libraryRecordDGV.CurrentRow.Cells[6].Value.ToString();
                string returnMaxTime_str = libraryRecordDGV.CurrentRow.Cells[7].Value.ToString();
                DateTime returnMaxTime = Convert.ToDateTime(returnMaxTime_str);
                int overdue = 0;
                int OverdueDays = 0;
                if (returnTime > returnMaxTime)
                {
                    overdue = 1;
                    TimeSpan tsp = returnTime - returnMaxTime;
                    OverdueDays = (int)(tsp.TotalDays);
                }
                if (overdue == 1&&DataBaseConection.returnBook(BrNo, SNo, returnTime_str, overdue, OverdueDays))
                    MessageBox.Show("本书归还成功，但由于超时，已计入个人违规次数，请去前台提交罚款", "归还提示");
                else if(overdue == 0 && DataBaseConection.returnBook(BrNo, SNo, returnTime_str, overdue, OverdueDays)) 
                    MessageBox.Show("您已经成功归还本书，等待管理员办理", "归还提示");              
                else
                    MessageBox.Show("归还过程出错", "归还失败");
                showRecord();
            }
            else
                MessageBox.Show("当前没有选中要还的书或者没有借书记录");
            
        }
    }
}
