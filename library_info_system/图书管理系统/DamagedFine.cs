using System;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class DamagedFine : Form
    {
        Form form;
        public DamagedFine(Form form)
        {
            InitializeComponent();
            this.form = form;
            showFine();          
        }

        DataBaseConection DataBaseConection = new DataBaseConection();

        private void btnBack_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            showFine();
        }

        public void showFine()
        {          
            libraryRecordDGV.DataSource=DataBaseConection.showFine_Damaged();
        }
    }
}
