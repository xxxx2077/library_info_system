using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class ReaderManage : Form
    {
        Form form;
        DataBaseConection dataBaseConection = new DataBaseConection();
        DataTable readerTypeTable;

        public ReaderManage(Form form)
        {
            InitializeComponent();
            this.form = form;
            /*bookClassComboBox.SelectedIndex = 0;*/
            InitializeReaderType();
            showReaders();
        }

        private void InitializeReaderType()
        {
            readerTypeTable = dataBaseConection.getReaderType();
            foreach (DataRow dr in readerTypeTable.Rows)
            {
                readerTypeComboBox.Items.Add(dr["RTName"]);
                readerClassComboBox.Items.Add(dr["RTName"]);
            }
        }
        
        private void exitButtom_Click(object sender, EventArgs e)
        {
            form.Show();
            this.Close();
        }

        private void readerAddButtom_Click(object sender, EventArgs e)
        {
            NewReaderAdd newReaderAdd = new NewReaderAdd(this);
            newReaderAdd.Show();
            this.Hide();
            showReaders();
        }

        private void btnSearchReader_Click(object sender, EventArgs e)
        {
            string readerName = readerNameTextBox.Text.ToString();
            if (readerName == String.Empty)
                MessageBox.Show("读者姓名不能为空", "搜索终止");
            else
            {
                DataTable res = dataBaseConection.seekReaderByName(readerName);
                if (res.Rows.Count == 0)
                    MessageBox.Show("查无此人", "查询结果");
                else
                {
                    usersDGV.DataSource = res;
                    usersDGV.BackgroundColor = Color.White;
                }
                    
            }
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if (SNoText.Text == String.Empty || readerTypeComboBox.Text == String.Empty
                || readerSexComboBox.Text == String.Empty || readerNameText.Text == String.Empty 
                || telephoneText.Text == String.Empty||
                totalReadText.Text == String.Empty || readsText.Text == String.Empty)
            {
                MessageBox.Show("所有项目数据不应该为空", "修改失败");
                return;
            }
            else
            {
                string readerType = readerTypeComboBox.Text.ToString();
                int RTNo=0;
                bool sex = false;
                bool isLost = false;
                foreach(DataRow dr in readerTypeTable.Rows)
                {
                    if(readerType == dr["RTName"].ToString())
                    {
                        RTNo = (int)dr["RTNo"];
                    }
                }
                if (readerSexComboBox.Text.ToString() == "男")
                    sex = true;
                else
                    sex = false;
                if (isLostcomboBox.Text.ToString() == "是")
                    isLost = true;
                else
                    isLost = false;
                DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();

                dtFormat.ShortDatePattern = "yyyy/MM/dd HH:mm:ss";

                DateTime dt = Convert.ToDateTime(registerDateText.Text.ToString(), dtFormat);
                string registerDate = dt.ToString("yyyy-MM-dd HH:mm:ss");
                dt = Convert.ToDateTime(validDateText.Text.ToString(), dtFormat);
                string validDate = dt.ToString("yyyy-MM-dd HH:mm:ss");
                dataBaseConection.readerInfoChange(SNoText.Text.ToString(),readerNameText.Text.ToString(), RTNo,sex,telephoneText.Text.ToString(),
                    registerDate, validDate, readsText.Text.ToString(),totalReadText.Text.ToString(),isLost,RFTimesText.Text.ToString());
                showReaders();
                MessageBox.Show("修改成功", "修改结果");

            }
        }

        private void searchByKindButtom_Click(object sender, EventArgs e)
        {
            string readerType = readerClassComboBox.SelectedItem.ToString();
            if(readerType == string.Empty)
            {
                MessageBox.Show("类型名不能为空", "搜索终止");
            }
            else
            {
                DataTable res = dataBaseConection.seekReaderByType(readerType);
                if (res.Rows.Count == 0)
                    MessageBox.Show("查无此人", "查询结果");
                else
                {
                    usersDGV.DataSource = res;
                    usersDGV.BackgroundColor = Color.White;
                }
            }
            
        }

        private void booksDVG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateInfo();
        }

        private void deleteBook_Click(object sender, EventArgs e)
        {
            string SNo= usersDGV.CurrentRow.Cells[0].Value.ToString();
            dataBaseConection.deleteUser(SNo);
            showReaders();
            MessageBox.Show("读者删除成功", "消息提示");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            showReaders();
        }

        public void updateInfo()
        {
            string SNo = usersDGV.CurrentRow.Cells[0].Value.ToString();
            string[] readerInfos = dataBaseConection.readerInfos(SNo);
            SNoText.Text = readerInfos[0];
            readerNameText.Text = readerInfos[1];
            readerTypeComboBox.Text = readerInfos[2];
            if(bool.Parse(readerInfos[3]))
                readerSexComboBox.Text = "男";
            else
                readerSexComboBox.Text = "女";
            telephoneText.Text = readerInfos[4];
            registerDateText.Text = readerInfos[5];
            validDateText.Text = readerInfos[6];
            readsText.Text = readerInfos[7];
            totalReadText.Text = readerInfos[8];
            if (bool.Parse(readerInfos[9]))
                isLostcomboBox.Text = "是";
            else
                isLostcomboBox.Text = "否";
            RFTimesText.Text = readerInfos[10];
        }

        public void showReaders()
        {
            usersDGV.DataSource = dataBaseConection.showReaderInfo();
        }
    }
}
