using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;


namespace 图书管理系统
{
    class DataBaseConection
    {
        string connectionString = "server=localhost;port=3306;user=root;password=121628;database=library_info_db;";

        public DataTable getReaderType()
        {
            DataTable reader_type;
            string getReaderText = "select * from reader_type";

            using (MySqlConnection readerTypeConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(getReaderText, readerTypeConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                reader_type = dataTable;
            }
            return reader_type;
        }

        //登录用户管理员与用户
        public int adminLogin(string telephone,string password)
        {
            Console.WriteLine(telephone + " " + password);
            int MID = -1;
            string sqlStr = string.Format("select * from manager_info where MTelephone='{0}';", telephone);

            using (MySqlConnection libaryConnection = new MySqlConnection(connectionString))
            {
                libaryConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(sqlStr, libaryConnection);
                MySqlDataReader nameReader = mySqlCommand.ExecuteReader();
                if (nameReader.Read())
                {
                    string passwordRead = nameReader.GetString(nameReader.GetOrdinal("MPwd"));
                    MID = nameReader.GetInt32(nameReader.GetOrdinal("MID"));
                    if (password == passwordRead)
                        return MID;
                    else
                        return 0;
                }
                else
                    return 0;
            }
        }
        public int readerRegister(string RName,int RTNo, string SNo, int Sex, string Rtelephone,string RPwd,DateTime now)
        {
            int res = -1;
            DataTable reader_info;
            DateTime validTime;
            if (RTNo == 1)
            {
                validTime = now.AddYears(4);
            }
            else
            {
                validTime = now.AddYears(50);
            }
   
            string now_str = now.ToString("yyyy-MM-dd HH:mm:ss");
            string validTime_str = validTime.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(now_str + " " + validTime_str);
            DataTable reader_type = getReaderType();
            int RAreads = (int)reader_type.Rows[RTNo-1]["RAreads"];
            int RAdays = (int)reader_type.Rows[RTNo-1]["RAdays"];
            string register_str = string.Format("insert into reader_info (RTNo,SNo,RName,Sex,Rtelephone,RDTime,RVDTime,Rreads,RTreads,RPwd) " +
                "values({0},'{1}','{2}',{3},'{4}','{5}','{6}',{7},{8},'{9}');",RTNo,SNo,RName,Sex,Rtelephone,now_str,validTime_str,0,0,RPwd);
            string select_str = string.Format("select *from reader_info where SNo='{0}'", SNo);
            using (MySqlConnection readerRegisterConnection = new MySqlConnection(connectionString))
            {
                readerRegisterConnection.Open();
                MySqlTransaction trans = readerRegisterConnection.BeginTransaction();
                MySqlCommand mySqlCommand = new MySqlCommand(register_str, readerRegisterConnection);
                MySqlCommand selectCommand = new MySqlCommand(select_str, readerRegisterConnection);
                mySqlCommand.Transaction = trans;
                selectCommand.Transaction = trans;
                MySqlDataReader nameReader = selectCommand.ExecuteReader();
                if (nameReader.Read())
                {
                    nameReader.Close();
                    trans.Rollback();
                    res = 2;
                }
                else
                {
                    nameReader.Close();
                    int affectedRows = mySqlCommand.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        trans.Commit();
                        res = 0;
                    }
                    else
                    {
                        trans.Rollback();
                        res = 1;
                    }
                }
                return res;
            }
        }

        public bool readerLogin(string SNo, string password, int readerType)
        {
            bool LoginResult = false;
            string sqlStr = string.Format("select * from reader_info where SNo='{0}'and RTNo='{1}'", SNo, readerType);
                    

            using (MySqlConnection libaryConnection = new MySqlConnection(connectionString))
            {
                libaryConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(sqlStr, libaryConnection);
                MySqlDataReader nameReader = mySqlCommand.ExecuteReader();
                if (nameReader.Read())
                {
                    string passwordRead = nameReader.GetString(nameReader.GetOrdinal("RPwd"));
                    if (password == passwordRead)
                        LoginResult = true;
                    else
                        LoginResult = false;
                }
                else
                    LoginResult = false;
            }

            return LoginResult;
        }

        public DataTable getBookType()
        {
            DataTable bookType;
            string CommandText = "select *from book_typeinfo";
            using (MySqlConnection loanRecordConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(CommandText, connectionString);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                bookType = dataTable;
            }
            return bookType;
        }

        public DataTable getPublisher()
        {
            DataTable publisher;
            string CommandText = "select PID as '出版社序号', PName as '出版社名称', PLinkman as '联系人', Ptelephone as '联系电话'," +
                " PProvince as '地址(省)',PCity as '地址(市)',PAddr as '地址（街道地址)'" +
                "from publisher_info";
            using (MySqlConnection getpublisherConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(CommandText, getpublisherConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                publisher = dataTable;
            }
            return publisher;
        }

        public DataTable borrowRecord(string sno)
        {
            DataTable borrowRecord;

            string CommandText = string.Format("select bri.BrNo as '借阅编号',bri.BSNo as '图书馆藏编号'," +
                "bi.BName as '书名',bi.ISBN as 'ISBN',bri.SNo as '读者编号', bri.MID as '管理员编号'," +
                "BrDtime as '借阅时间',BgDTime as '应还时间',BrTimes as '续借次数'," +
                "BrStatus as '办理状态', BrtStatus as '是否归还' from borrow_info bri,book_info bi,book_storeinfo bsi " +
                "where bri.BSNo=bsi.BSNo and bsi.ISBN=bi.ISBN and SNo='{0}' and BrStatus=true", sno);

            using (MySqlConnection loanRecordConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(CommandText,connectionString);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                borrowRecord = dataTable;
            }

            return borrowRecord;
        }

        public DataTable showBookInfo()
        {
            DataTable books;
            string showBookCommandText = "select ISBN, BName as '书名', BWriter as '作者',BTName as '图书类型', BEdition as '版次', " +
                "PName as '出版社', BPDate as '出版日期',BPrice as '价格', BIntro as '简介', BExnum as '现在库数量', BTotal as '库存总量'" +
                "from book_info,book_typeinfo,publisher_info where book_info.BTNo = book_typeinfo.BTNo and book_info.PID = publisher_info.PID";
            
            using (MySqlConnection showBookConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(showBookCommandText,showBookConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                books = dataTable;
            }
            return books;
        }

        public DataTable showBookStoreInfo()
        {
            DataTable bookStore;
            string showBookCommandText = "select BSNo as '馆藏编号', BName as '书名',bs.ISBN as 'ISBN'," +
                "BSDate as '入库时间', BSStatus as '图书状态' from book_storeinfo bs,book_info bi where bs.ISBN=bi.ISBN";

            using (MySqlConnection showBookConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(showBookCommandText, showBookConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                bookStore = dataTable;
            }
            return bookStore;
        }

        public DataTable showReaderInfo()
        {
            DataTable commonUser;

            string CommonUserCommandText = "select SNo as '读者编号', RName as '读者姓名',RTName as '读者类型', Sex as '读者性别'," +
                "Rtelephone as '联系电话',RDTime as '登记日期', RVDTime as '有效期至',Rreads as '现借图书数',RTreads as '累计借书数', " +
                "RLStatus as '是否挂失', RFTimes as '违规次数' from reader_info ri,reader_type rt where ri.RTNo=rt.RTNo";

            using (MySqlConnection commonUserConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(CommonUserCommandText,commonUserConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                commonUser = dataTable;
            }
            return commonUser;

        }

        public bool passwordChange(string name,string password,string newPassword)
        {
            bool IsPasswordChange;

            string passwordChangeCommand = string.Format("update reader_info set RPwd='{0}' where SNo='{1}'" ,newPassword ,name);
            string IsPasswordCommand = "select * from reader_info where SNo='" + name + "'";

            using (MySqlConnection passwordChangeConnection = new MySqlConnection(connectionString))
            {
                passwordChangeConnection.Open();
                MySqlCommand isPassword = new MySqlCommand(IsPasswordCommand, passwordChangeConnection);
                MySqlCommand passwordChange = new MySqlCommand(passwordChangeCommand, passwordChangeConnection);
                using (MySqlDataReader mySqlDataReader = isPassword.ExecuteReader())
                {
                    if (mySqlDataReader.Read())
                    {
                        string passwordRead = mySqlDataReader.GetString(mySqlDataReader.GetOrdinal("RPwd"));
                        if (password == passwordRead)
                        {
                            IsPasswordChange = true;
                        }
                        else
                            IsPasswordChange = false;
                    }
                    else
                        IsPasswordChange = false;
                }
                if (IsPasswordChange)
                    passwordChange.ExecuteNonQuery();
                    
            }
            return IsPasswordChange;
        }

        public DataTable seekBookByName(string bookName)
        {
            
            DataTable dt= showBookInfo();

            DataRow[] foundRows = dt.Select(string.Format("书名 like '%{0}%'",bookName));
            DataTable bookData = dt.Clone();
            foreach (DataRow row in foundRows)
            {
                bookData.ImportRow(row);
            }
            return bookData;
        }

        public DataTable seekBookByType(string bookType)
        {
            DataTable dt = showBookInfo();

            DataRow[] foundRows = dt.Select(string.Format("图书类型 = '{0}'", bookType));
            DataTable bookData = dt.Clone();
            foreach (DataRow row in foundRows)
            {
                bookData.ImportRow(row);
            }
            return bookData;
        }

        public DataTable seekReaderByName(string readerName)
        {

            DataTable dt = showReaderInfo();

            DataRow[] foundRows = dt.Select(string.Format("读者姓名 like '%{0}%'", readerName));
            DataTable readerData = dt.Clone();
            foreach (DataRow row in foundRows)
            {
                readerData.ImportRow(row);
            }
            return readerData;
        }

        public DataTable seekReaderByType(string readerType)
        {
            DataTable dt = showReaderInfo();

            DataRow[] foundRows = dt.Select(string.Format("读者类型 = '{0}'", readerType));
            DataTable readerData = dt.Clone();
            foreach (DataRow row in foundRows)
            {
                readerData.ImportRow(row);
            }
            return readerData;
        }

        public string[] readerInfos(string SNo)
        {

            string readerInfoCommand = string.Format("select SNo as '读者编号', RName as '读者姓名',RTName as '读者类型', " +
                "Sex as '读者性别',Rtelephone as '联系电话',RDTime as '登记日期', RVDTime as '有效期至',Rreads as '现借图书数'" +
                ",RTreads as '累计借书数', RLStatus as '是否挂失', RFTimes as '违规次数' " +
                "from reader_info ri,reader_type rt where ri.RTNo=rt.RTNo and SNo = '{0}'",SNo);
            string[] readerInfos = new string[11];

            using (MySqlConnection readerInfoConnection = new MySqlConnection(connectionString))
            {
                readerInfoConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(readerInfoCommand, readerInfoConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    readerInfos[0] = mySqlDataReader["读者编号"].ToString();
                    readerInfos[1] = mySqlDataReader["读者姓名"].ToString();
                    readerInfos[2] = mySqlDataReader["读者类型"].ToString();
                    readerInfos[3] = mySqlDataReader["读者性别"].ToString();
                    readerInfos[4] = mySqlDataReader["联系电话"].ToString();
                    readerInfos[5] = mySqlDataReader["登记日期"].ToString();
                    readerInfos[6] = mySqlDataReader["有效期至"].ToString();
                    readerInfos[7] = mySqlDataReader["现借图书数"].ToString();
                    readerInfos[8] = mySqlDataReader["累计借书数"].ToString();
                    readerInfos[9] = mySqlDataReader["是否挂失"].ToString();
                    readerInfos[10] = mySqlDataReader["违规次数"].ToString();
                }
            }
            return readerInfos;
        }

        public string[] bookStoreInfos(int BSNo,string ISBN)
        {

            string bookDigestCommand = string.Format("select * from book_info bi,book_storeinfo where BSNo={0} and bi.ISBN='{1}'",BSNo,ISBN);
            string[] bookstoreinfos = new string[5];

            using (MySqlConnection bookDigestConnection = new MySqlConnection(connectionString))
            {
                bookDigestConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(bookDigestCommand, bookDigestConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    bookstoreinfos[0] = mySqlDataReader["BSNo"].ToString();
                    bookstoreinfos[1] = mySqlDataReader["BName"].ToString();
                    bookstoreinfos[2] = mySqlDataReader["ISBN"].ToString();
                    bookstoreinfos[3] = mySqlDataReader["BSDate"].ToString();
                    bookstoreinfos[4] = mySqlDataReader["BSStatus"].ToString();
                }
            }
            return bookstoreinfos;
        }

        public string[]  bookinfos(string ISBN)
        {

            string bookDigestCommand = "select * from book_info bi,publisher_info pi,book_typeinfo bt where bi.PID=pi.PID and bi.BTNo=bt.BTNo and bi.ISBN='" + ISBN + "'";
            string[] bookinfos= new string[9];

            using (MySqlConnection bookDigestConnection = new MySqlConnection(connectionString))
            {
                bookDigestConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(bookDigestCommand, bookDigestConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    bookinfos[0] = mySqlDataReader["BIntro"].ToString();
                    bookinfos[1] = mySqlDataReader["BName"].ToString();
                    bookinfos[2] = mySqlDataReader["BTName"].ToString();
                    bookinfos[3] = mySqlDataReader["PName"].ToString();
                    bookinfos[4] = mySqlDataReader["BWriter"].ToString();
                    bookinfos[5] = mySqlDataReader["BPDate"].ToString();
                    bookinfos[6] = mySqlDataReader["ISBN"].ToString();
                    bookinfos[7] = mySqlDataReader["BPrice"].ToString();
                    bookinfos[8] = mySqlDataReader["BEdition"].ToString();
                }
            }
            return bookinfos;
        }

        public bool confirmBorrow(int MID, int brno,int bsno)
        {
            string foreign_key_checks_false = "SET foreign_key_checks = 0;";
            string foreign_key_checks = "SET foreign_key_checks = 1;";
            string confirmStr = string.Format("update borrow_info set MID={0}, BrStatus=true where BrNo={1}", MID, brno);
            using (MySqlConnection borrowBookConnection = new MySqlConnection(connectionString))
            {
                borrowBookConnection.Open();
                MySqlCommand foreign_key_checks_falseCommand = new MySqlCommand(foreign_key_checks_false, borrowBookConnection);
                MySqlCommand foreign_key_checksCommand = new MySqlCommand(foreign_key_checks, borrowBookConnection);
                MySqlCommand mySqlCommand = new MySqlCommand(confirmStr, borrowBookConnection);
                foreign_key_checks_falseCommand.ExecuteNonQuery();
                int r1 = mySqlCommand.ExecuteNonQuery();
                foreign_key_checksCommand.ExecuteNonQuery();
                if (r1 > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool returnBook(int BrNo,string SNo,string RtDTime,int RtOverdue,int OverdueDays)
        {
            string updateStr = string.Format("update borrow_info set BrtStatus = true where BrNo = {0}",BrNo);
            string returnStr = string.Format("insert into return_info (BrNo,SNo,RtDTime,RtOverdue,OverdueDays) " +
                "values({0},'{1}','{2}',{3},{4})", BrNo,SNo,RtDTime,RtOverdue, OverdueDays);           
            string updateStr2 = string.Format("update reader_info set Rreads = Rreads-1 where SNo = '{0}'", SNo);
            using (MySqlConnection returnBookConnection = new MySqlConnection(connectionString))
            {
                returnBookConnection.Open();
                MySqlTransaction trans = returnBookConnection.BeginTransaction();
                MySqlCommand updateCommand = new MySqlCommand(updateStr, returnBookConnection);
                MySqlCommand update2Command = new MySqlCommand(updateStr2, returnBookConnection);
                MySqlCommand returnCommand = new MySqlCommand(returnStr, returnBookConnection);
                updateCommand.Transaction = trans;
                update2Command.Transaction = trans;
                returnCommand.Transaction = trans;
                try
                {
                    int r1 = updateCommand.ExecuteNonQuery();
                    int r3 = update2Command.ExecuteNonQuery();
                    int r2 = returnCommand.ExecuteNonQuery();
                    if (r1 > 0 && r2 > 0&&r3>0)
                    {
                        trans.Commit();
                        return true;
                    }
                    else
                    {
                        trans.Rollback();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    return false;
                }
                
            }
        }

        public bool confirmReturn(string ISBN,string SNo,int MID, int rtno, int BSNo,float fines,bool overdue, bool damaged, bool lost)
        {
            string foreign_key_checks_false = "SET foreign_key_checks = 0;";
            string foreign_key_checks = "SET foreign_key_checks = 1;";
            string confirmStr;
            string insertStr;
            bool isInsert = false;
            bool isReturn = false;
            bool res = true;
            string updateStr1 = string.Format("update reader_info set RFTimes=RFTimes+1 where SNo ='{0}'",SNo);
            string updateStr2;
            string updateStr3;
            string fineDTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (overdue)
            {
                isInsert = true;
                isReturn = true;
                confirmStr = string.Format("update return_info set MID={0}, BtStatus=true, RtOverdue = true where RtNo={1}", MID, rtno);
                insertStr = string.Format("insert into overdue_info (RtNo,MID,OFines,OFDTime,OFStatus) values({0},{1},{2},'{3}',true)",rtno,MID,fines,fineDTime);
                updateStr2 = string.Format("update book_storeinfo set BSStatus=0 where BSNo = {0}", BSNo);
                updateStr3 = string.Format("update book_info set BExnum=BExnum+1 where ISBN = '{0}'", ISBN);
            }
            else if (damaged)
            {
                isInsert = true;
                isReturn = true;
                confirmStr = string.Format("update return_info set MID={0}, BtStatus=true, RtDamaged = true where RtNo={1}", MID, rtno);
                insertStr = string.Format("insert into damaged_info (RtNo,MID,DFines,DFDTime,DFStatus) values({0},{1},{2},'{3}',true)", rtno, MID, fines, fineDTime);
                updateStr2 = string.Format("update book_storeinfo set BSStatus=3 where BSNo = {0}",BSNo);
                updateStr3 = string.Format("update book_info set BExnum=BExnum+1 where ISBN = '{0}'", ISBN);
            }
            else if (lost)
            {
                isInsert = true;
                isReturn = false;
                updateStr3 = "";
                confirmStr = string.Format("update return_info set MID={0}, BtStatus=true, RtLost = true where RtNo={1}", MID, rtno);
                insertStr = string.Format("insert into lost_info (RtNo,MID,LFines,LFDTime,LFStatus) values({0},{1},{2},'{3}',true)", rtno, MID, fines, fineDTime);
                updateStr2 = string.Format("update book_storeinfo set BSStatus=2 where BSNo = {0}", BSNo);
            }
            else
            {
                isInsert = false;
                isReturn = true;
                insertStr = "";
                confirmStr = string.Format("update return_info set MID={0}, BtStatus=true where RtNo={1}", MID, rtno);
                updateStr2 = string.Format("update book_storeinfo set BSStatus=0 where BSNo = {0}", BSNo);
                updateStr3 = string.Format("update book_info set BExnum=BExnum+1 where ISBN = '{0}'", ISBN);
            }
            
            using (MySqlConnection returnBookConnection = new MySqlConnection(connectionString))
            {
                returnBookConnection.Open();
                MySqlTransaction trans = returnBookConnection.BeginTransaction();
                MySqlCommand foreign_key_checks_falseCommand = new MySqlCommand(foreign_key_checks_false, returnBookConnection);
                MySqlCommand foreign_key_checksCommand = new MySqlCommand(foreign_key_checks, returnBookConnection);
                MySqlCommand confirmCommand = new MySqlCommand(confirmStr, returnBookConnection);
                MySqlCommand updateCommand = new MySqlCommand(updateStr1, returnBookConnection);
                MySqlCommand update2Command = new MySqlCommand(updateStr2, returnBookConnection);

                confirmCommand.Transaction = trans;
                updateCommand.Transaction = trans;
                update2Command.Transaction = trans;
                foreign_key_checks_falseCommand.Transaction = trans;
                foreign_key_checksCommand.Transaction = trans;
                foreign_key_checks_falseCommand.ExecuteNonQuery();
                int r1 = confirmCommand.ExecuteNonQuery();
                int r2 = 0;
                int r3 = 0;
                int r5 = 0;
                if (isInsert)
                {
                    MySqlCommand insertCommand = new MySqlCommand(insertStr, returnBookConnection);
                    insertCommand.Transaction = trans;
                    r2 = insertCommand.ExecuteNonQuery();
                    r3 = updateCommand.ExecuteNonQuery();
                    if (r2 < 0 && r3 < 0)
                        res = false;
                }
                if (isReturn)
                {
                    MySqlCommand update3Command = new MySqlCommand(updateStr3, returnBookConnection);
                    update3Command.Transaction = trans;
                    r5 = update3Command.ExecuteNonQuery();
                    if(r5<0)
                        res = false;
                }
                
                int r4 = update2Command.ExecuteNonQuery();
                foreign_key_checksCommand.ExecuteNonQuery();
                if (r1 > 0&&r4>0&&res)
                {
                    trans.Commit();
                    return true; 
                }
                else
                {
                    trans.Rollback();
                    return false;
                }
            }
        }

        public int addUser(string SNo,string readerName,int RTNo,string telephone,bool sex,string RDTime,string RVDTime)
        {          
            string addUserStr = string.Format("insert into reader_info (SNo,RName,RTNo,Rtelephone,Sex,RDTime,RVDTime)" +
                "values('{0}','{1}',{2},'{3}',{4},'{5}','{6}')",SNo,readerName,RTNo,telephone,sex,RDTime,RVDTime);
            string selectStr = string.Format("select *from reader_info where SNo = '{0}'",SNo);
            using (MySqlConnection addUserConnection = new MySqlConnection(connectionString))
            {
                addUserConnection.Open();
                MySqlTransaction trans = addUserConnection.BeginTransaction();
                MySqlCommand insertCommand = new MySqlCommand(addUserStr, addUserConnection);
                MySqlCommand selectCommand = new MySqlCommand(selectStr, addUserConnection);
                insertCommand.Transaction = trans;
                selectCommand.Transaction = trans;
                using (MySqlDataReader selectReader = selectCommand.ExecuteReader())
                {
                    if (selectReader.HasRows)
                    {
                        selectReader.Close();
                        trans.Rollback();
                        return -1;
                    }
                    else
                    {
                        selectReader.Close();
                        int r = insertCommand.ExecuteNonQuery();
                        if (r > 0)
                        {
                            trans.Commit();
                            return 0;
                        }
                        else
                        {
                            trans.Rollback();
                            return 1;
                        }
                    }
                }
            }
        }

        public void deleteUser(string SNo)
        {
            string deleteUserCommand="delete from reader_info where SNo='"+SNo+"'";
            using (MySqlConnection deletUserConnection = new MySqlConnection(connectionString))
            {
                deletUserConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(deleteUserCommand, deletUserConnection);
                mySqlCommand.ExecuteNonQuery();

            }
        }

        public void readerInfoChange(string SNo, string readerName, int RTNo,
            bool sex, string telephone, string registerDate, string validDate, string reads,
            string TotalReads, bool isLost,string RFTimes)
        {
            string updateCommand = string.Format("update reader_info set RName ='{0}',Sex = {1},RTNo = {2}," +
                "Rtelephone = '{3}', RDTime = '{4}',RVDTime = '{5}'," +
                "Rreads = {6}, RTreads = {7},RLStatus = {8}, RFTimes ={9} where SNo='{10}'",readerName,sex,RTNo,telephone,
                registerDate,validDate,reads,TotalReads,isLost,RFTimes,SNo);
            using (MySqlConnection updateReaderConnection = new MySqlConnection(connectionString))
            {
                updateReaderConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(updateCommand, updateReaderConnection);
                mySqlCommand.ExecuteNonQuery();
            }
        }

        public int bookInfoChange(string ISBN,string bookName,string bookType,
            string press,string author,string edition,string publishTime,string price_str)
        {
            int PID = -1;
            DataTable publisherTable = getPublisher();
            foreach (DataRow dr in publisherTable.Rows)
            {
                if (dr["出版社名称"].ToString() == press)
                {
                    PID = (int)dr["出版社序号"];
                }
            }

            int BTNo = -1;
            DataTable bookTypeTable = getBookType();
            foreach (DataRow dr in bookTypeTable.Rows)
            {
                if (dr["BTName"].ToString() == bookType)
                {
                    BTNo = (int)dr["BTNo"];
                }
            }
            if (PID == -1 || BTNo == -1)
                return -1;

            float price = float.Parse(price_str);

            string bookInfoChangeCommandText=string.Format("update book_info set BName='{0}',BTNo={1},PID={2}," +
                "BWriter='{3}',BEdition='{4}',BPdate='{5}',BPrice={6} " +
                "where ISBN = '{7}'",bookName,BTNo,PID,author,edition,publishTime,price,ISBN);

            using (MySqlConnection bookInfoChangeConnection = new MySqlConnection(connectionString))
            {
                bookInfoChangeConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(bookInfoChangeCommandText, bookInfoChangeConnection);
                int r = mySqlCommand.ExecuteNonQuery();
                if (r > 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        public void bookStoreInfoChange(int BSNo,string ISBN, string BSDate,
            int BSStatus)
        {
           string bookInfoChangeCommandText = string.Format("update book_storeinfo set ISBN='{0}',BSDate='{1}',BSStatus={2} where BSNo={3}",ISBN,BSDate,BSStatus,BSNo);

            using (MySqlConnection bookInfoChangeConnection = new MySqlConnection(connectionString))
            {
                bookInfoChangeConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(bookInfoChangeCommandText, bookInfoChangeConnection);
                mySqlCommand.ExecuteNonQuery();
            }
        }
        public bool bookDelete(string ISBN)
        {
            string deleteStr= "delete from book_info where ISBN='" + ISBN + "'";
            string bookStoreDeleteStr = "delete from book_storeinfo where ISBN='" + ISBN + "'";
            string foreign_key_checks_false = "SET foreign_key_checks = 0;";
            string foreign_key_checks = "SET foreign_key_checks = 1;";
            using (MySqlConnection bookDeleteConnection = new MySqlConnection(connectionString))
            {
                bookDeleteConnection.Open();
                MySqlTransaction trans = bookDeleteConnection.BeginTransaction();
                MySqlCommand deleteCommand = new MySqlCommand(deleteStr, bookDeleteConnection);
                MySqlCommand foreign_key_checks_falseCommand = new MySqlCommand(foreign_key_checks_false, bookDeleteConnection);
                MySqlCommand foreign_key_checksCommand = new MySqlCommand(foreign_key_checks, bookDeleteConnection);
                MySqlCommand deleteBookStoreCommand = new MySqlCommand(bookStoreDeleteStr, bookDeleteConnection);
                foreign_key_checks_falseCommand.Transaction = trans;
                foreign_key_checksCommand.Transaction = trans;
                deleteCommand.Transaction = trans;
                deleteBookStoreCommand.Transaction = trans;
                foreign_key_checks_falseCommand.ExecuteNonQuery();
                int r1 = deleteCommand.ExecuteNonQuery();
                int r2 = deleteBookStoreCommand.ExecuteNonQuery();
                foreign_key_checksCommand.ExecuteNonQuery();

                if (r1 > 0 && r2 > 0)
                {
                    trans.Commit();
                    bookDeleteConnection.Close();
                    return true;
                }
                else
                {
                    trans.Rollback();
                    bookDeleteConnection.Close();
                    return false;
                }

            }
        }

        public bool bookStoreDelete(int BSNo,string ISBN)
        {
            bool isDeleteBookInfo = false;
            string bookStoreDeleteStr = "delete from book_storeinfo where BSNo='" + BSNo + "'";
            string bookDeleteStr = "delete from book_info where ISBN='" + ISBN + "'";
            string selectStr = "select BTotal from book_info where ISBN='" + ISBN + "'";
            string updateStr = "update book_info set BExnum=BExnum-1,BTotal=BTotal-1 where ISBN='" + ISBN + "'";
            string foreign_key_checks_false = "SET foreign_key_checks = 0;";
            string foreign_key_checks = "SET foreign_key_checks = 1;";
            using (MySqlConnection bookDeleteConnection = new MySqlConnection(connectionString))
            {
                bookDeleteConnection.Open();
                MySqlTransaction trans = bookDeleteConnection.BeginTransaction();              
                MySqlCommand foreign_key_checks_falseCommand = new MySqlCommand(foreign_key_checks_false, bookDeleteConnection);
                MySqlCommand foreign_key_checksCommand = new MySqlCommand(foreign_key_checks, bookDeleteConnection);
                MySqlCommand deleteBookStoreCommand = new MySqlCommand(bookStoreDeleteStr, bookDeleteConnection);
                MySqlCommand deleteBookInfoCommand = new MySqlCommand(bookDeleteStr, bookDeleteConnection);
                MySqlCommand selectCommand = new MySqlCommand(selectStr, bookDeleteConnection);
                MySqlCommand updateCommand = new MySqlCommand(updateStr, bookDeleteConnection);
                foreign_key_checks_falseCommand.Transaction = trans;
                foreign_key_checksCommand.Transaction = trans;
                deleteBookStoreCommand.Transaction = trans;
                deleteBookInfoCommand.Transaction = trans;
                selectCommand.Transaction = trans;
                updateCommand.Transaction = trans;
                using (MySqlDataReader myReader = selectCommand.ExecuteReader())
                {
                    if (myReader.Read())
                    {
                        int BTotal = (int)myReader["BTotal"];
                        if (BTotal-1 == 0)
                            isDeleteBookInfo = true;
                    }
                }
                foreign_key_checks_falseCommand.ExecuteNonQuery();
                int r1 = deleteBookStoreCommand.ExecuteNonQuery();
                int r2 = updateCommand.ExecuteNonQuery();
                if (isDeleteBookInfo)
                {
                    int r3 = deleteBookInfoCommand.ExecuteNonQuery();
                    if(r3<0)
                    {
                        trans.Rollback();
                        return false;
                    }
                }              
                foreign_key_checksCommand.ExecuteNonQuery();
                
                if (r1 > 0 && r2>0)
                {
                    trans.Commit();
                    bookDeleteConnection.Close();
                    return true;
                }
                else
                {
                    trans.Rollback();
                    bookDeleteConnection.Close();
                    return false;
                }
                
            }
        }
        public DataTable seekBookStoreByName(string bookName)
        {
            DataTable dt = showBookStoreInfo();

            DataRow[] foundRows = dt.Select(string.Format("书名 like '%{0}%'", bookName));
            DataTable bookstoreData = dt.Clone();
            foreach (DataRow row in foundRows)
            {
                bookstoreData.ImportRow(row);
            }
            return bookstoreData;
        }
        public DataTable seekBookStoreByBSStatus(int BSStatus)
        {
            DataTable dt = showBookStoreInfo();

            DataRow[] foundRows = dt.Select(string.Format("图书状态 = {0}", BSStatus));
            DataTable bookstoreData = dt.Clone();
            foreach (DataRow row in foundRows)
            {
                bookstoreData.ImportRow(row);
            }
            return bookstoreData;
        }
        public int addNewBook(bool isExist,string bookName, string bookType, string writer, string publisher,
                   string bpdate, string edition,string ISBN, string Content, float price)
        {
            int res = 0;
            int PID = -1;
            if (!isExist)
            {
                DataTable publisherTable = getPublisher();
                foreach (DataRow dr in publisherTable.Rows)
                {
                    if (dr["出版社名称"].ToString() == publisher)
                    {
                        PID = (int)dr["出版社序号"];
                    }
                }

                int BTNo = -1;
                DataTable bookTypeTable = getBookType();
                foreach (DataRow dr in bookTypeTable.Rows)
                {
                    if (dr["BTName"].ToString() == bookType)
                    {
                        BTNo = (int)dr["BTNo"];
                    }
                }
                if (PID == -1 || BTNo == -1)
                    return -1;
                string IsBookEixstedCommandText = "select * from book_info where ISBN ='" + ISBN + "'";

                using (MySqlConnection addNewBookConnection = new MySqlConnection(connectionString))
                {
                    addNewBookConnection.Open();
                    MySqlTransaction trans = addNewBookConnection.BeginTransaction();
                    try
                    {
                        MySqlCommand IsExistedCommand = new MySqlCommand(IsBookEixstedCommandText, addNewBookConnection);
                        IsExistedCommand.Transaction = trans;
                        using (MySqlDataReader IsExistedReader = IsExistedCommand.ExecuteReader())
                        {
                            if (IsExistedReader.HasRows)
                            {
                                IsExistedReader.Close();
                                string updateStr = string.Format("update book_info set BExnum=BExnum+1,BTotal=BTotal+1 where ISBN='{0}'", ISBN);
                                using (MySqlCommand updateCommand = new MySqlCommand(updateStr, addNewBookConnection))
                                {
                                    updateCommand.Transaction = trans;
                                    int r = updateCommand.ExecuteNonQuery();
                                    if (r < 0)
                                    {
                                        res = 1;
                                    }
                                }
                                string addDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                string addBookStorageStr = string.Format("insert into book_storeinfo (ISBN,BSDate) values('{0}','{1}')", ISBN, addDate);
                                using (MySqlCommand addBookStorageCommand = new MySqlCommand(addBookStorageStr, addNewBookConnection))
                                {
                                    addBookStorageCommand.Transaction = trans;
                                    int r1 = addBookStorageCommand.ExecuteNonQuery();
                                    if (r1 < 0)
                                    {
                                        return 1;
                                    }
                                }
                            }
                            else
                            {
                                IsExistedReader.Close();
                                string addNewBookStr = string.Format("insert into book_info (ISBN,BTNo,PID,BName,BWriter,BEdition,BPDate,BPrice,BExnum,BIntro,BTotal)" +
                                        "values('{0}',{1},{2},'{3}','{4}','{5}','{6}',{7},1,'{8}',1)", ISBN, BTNo, PID, bookName, writer, edition, bpdate, price, Content);
                                using (MySqlCommand AddCommand = new MySqlCommand(addNewBookStr, addNewBookConnection))
                                {
                                    AddCommand.Transaction = trans;
                                    int r = AddCommand.ExecuteNonQuery();
                                    if (r < 0)
                                    {
                                        res = 1;
                                    }
                                }
                                string addDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                string addBookStorageStr = string.Format("insert into book_storeinfo (ISBN,BSDate) values('{0}','{1}')", ISBN, addDate);
                                using (MySqlCommand addBookStorageCommand = new MySqlCommand(addBookStorageStr, addNewBookConnection))
                                {
                                    addBookStorageCommand.Transaction = trans;
                                    int r1 = addBookStorageCommand.ExecuteNonQuery();
                                    if (r1 < 0)
                                    {
                                        return 1;
                                    }
                                }

                            }

                        }
                        if (res == 0)
                        {
                            trans.Commit();
                            return 0;
                        }
                        else
                        {
                            trans.Rollback();
                            return 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        return 1;
                    }
                }
            }
            else
            {
                using (MySqlConnection addNewBookConnection = new MySqlConnection(connectionString))
                {
                    addNewBookConnection.Open();
                    MySqlTransaction trans = addNewBookConnection.BeginTransaction();
                    string updateStr = string.Format("update book_info set BExnum=BExnum+1,BTotal=BTotal+1 where ISBN='{0}'", ISBN);
                    using (MySqlCommand updateCommand = new MySqlCommand(updateStr, addNewBookConnection))
                    {
                        updateCommand.Transaction = trans;
                        int r = updateCommand.ExecuteNonQuery();
                        if (r < 0)
                        {
                            trans.Rollback() ;
                            res = 1;
                        }
                    }
                    string addDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string addBookStorageStr = string.Format("insert into book_storeinfo (ISBN,BSDate) values('{0}','{1}')", ISBN, addDate);
                    using (MySqlCommand addBookStorageCommand = new MySqlCommand(addBookStorageStr, addNewBookConnection))
                    {
                        int r1 = addBookStorageCommand.ExecuteNonQuery();
                        if (r1 < 0)
                        {
                            trans.Rollback();
                            res = 1;
                        }
                    }
                    if (res == 0)
                        trans.Commit();
                    return res;
                }
            }
            
    }

        
        public DataTable showborrow()
        {
            DataTable borrowRecords;
            string showBookCommandText = "select BrNo as '借书序号', bri.MID as '管理员工号',MName as '管理员姓名', " +
                "bri.BSNo as '馆藏图书编号',bi.BName as '书名', bi.ISBN as 'ISBN',SNo as '读者编号', " +
                "BrDtime as '借阅时间',BgDTime as '应还时间',BrTimes as '续借次数', BrStatus as '办理状态' " +
                "from borrow_info bri,book_storeinfo bs,book_info bi,manager_info mi where bs.ISBN=bi.ISBN and bs.BSNo=bri.BSNo and mi.MID=bri.MID";

            using (MySqlConnection showborrowConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(showBookCommandText, showborrowConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                borrowRecords = dataTable;
            }
            return borrowRecords;
        }
        public DataTable seekBorrowRecordByBookName(string bookName)
        {
            DataTable dt = showborrow();

            DataRow[] foundRows = dt.Select(string.Format("书名 like '%{0}%'", bookName));
            DataTable borrowData = dt.Clone();
            foreach (DataRow row in foundRows)
            {
                borrowData.ImportRow(row);
            }
            return borrowData;
        }
        public DataTable seekBorrowRecordByUserName(string SNo)
        {
            DataTable dt = showborrow();

            DataRow[] foundRows = dt.Select(string.Format("读者编号 = '{0}'", SNo));
            DataTable borrowData = dt.Clone();
            foreach (DataRow row in foundRows)
            {
                borrowData.ImportRow(row);
            }
            return borrowData;
        }
        public DataTable seekBorrowRecordByBrNo(string BrNo)
        {
            DataTable dt = showborrow();
            DataRow[] foundRows = dt.Select(string.Format("借书序号 = {0}", BrNo));
            DataTable borrowData = dt.Clone();
            foreach (DataRow row in foundRows)
            {
                borrowData.ImportRow(row);
            }
            return borrowData;
        }


        public int borrowAdd(string BName, string SNo, string ISBN)
        {
            bool IsborrowAdd=false;
            int BSNo=0;
            int RTNo = 0;
            int RAdays=0;
            int RAreads=0;
            int Rreads=0;

            string seekInfoStr = string.Format("select BSNo,ri.RTNo,RAdays,RAreads,Rreads from book_storeinfo bs,reader_info ri,reader_type rt " +
                "where ri.SNo='{0}' and rt.RTNo=ri.RTNo and (BSStatus=0 or BSStatus=3) and ISBN='{1}'", SNo,ISBN);

            using (MySqlConnection userAddConnection = new MySqlConnection(connectionString))
            {
                userAddConnection.Open();
                MySqlTransaction trans = userAddConnection.BeginTransaction();
                MySqlCommand seekInfoCommand = new MySqlCommand(seekInfoStr, userAddConnection);
                seekInfoCommand.Transaction = trans;
                try
                {
                    using (MySqlDataReader mySqlDataReader = seekInfoCommand.ExecuteReader())
                    {

                        if (mySqlDataReader.Read())
                        {
                            BSNo = (int)mySqlDataReader.GetValue(0);
                            RTNo = (int)mySqlDataReader.GetValue(1);
                            RAdays = (int)mySqlDataReader.GetValue(2);
                            RAreads = (int)mySqlDataReader.GetValue(3);
                            Rreads = (int)mySqlDataReader.GetValue(4);
                        }
                        else
                            return 2;
                    }
                    if (Rreads > RAreads)
                        return 1;
                    string BrDTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string BgDTime = DateTime.Now.AddDays(RAdays).ToString("yyyy-MM-dd HH:mm:ss");
                    string borrowBookStr = string.Format("insert into borrow_info (BSNo,SNo,MID,BrDtime,BgDTime) values({0},'{1}',1,'{2}','{3}')", BSNo, SNo, BrDTime, BgDTime);
                    MySqlCommand AddCommand = new MySqlCommand(borrowBookStr, userAddConnection);
                    AddCommand.Transaction = trans;
                    int r1 = AddCommand.ExecuteNonQuery();

                    string updateBookStoreStr = string.Format("update book_storeinfo set BSStatus=1 where BSNo={0}",BSNo);
                    MySqlCommand updateBookStoreCommand = new MySqlCommand(updateBookStoreStr, userAddConnection);
                    updateBookStoreCommand.Transaction = trans;

                    string updateBookInfoStr = string.Format("update book_info set BExnum=BExnum-1 where ISBN='{0}'",ISBN);
                    MySqlCommand updateBookInfoCommand = new MySqlCommand(updateBookInfoStr, userAddConnection);
                    updateBookInfoCommand.Transaction = trans;

                    string updateReaderInfoStr = string.Format("update reader_info set Rreads=Rreads+1,RTreads=RTreads+1 where SNo='{0}'", SNo);
                    MySqlCommand updateReaderInfoCommand = new MySqlCommand(updateReaderInfoStr, userAddConnection);
                    updateReaderInfoCommand.Transaction = trans;

                    int r2 = updateBookStoreCommand.ExecuteNonQuery();
                    int r3 = updateBookInfoCommand.ExecuteNonQuery();
                    int r4 = updateReaderInfoCommand.ExecuteNonQuery();
                    if (r1 > 0 && r2 > 0 &&r3>0 &&r4>0)
                    {
                        trans.Commit();
                        return 0;
                    }
                    else
                    {
                        trans.Rollback();
                        return 3;
                    }

                }
                catch(Exception ex)
                {
                    trans.Rollback();
                    return 3;
                }

            }
        }

        public DataTable showReturn()
        {
            DataTable returnRecords;
            //TODO 
            string showBookCommandText = "select RtNo as '还书序号',bri.BrNo as '借阅编号',bi.BName as '书名',bri.SNo as '读者编号',ri.MID as '管理员工号',MName as '管理员姓名'," +
                "RtDTime as '归还时间',BtStatus as '办理状态',OverdueDays as '超期时间',RtOverdue as '是否超期',BPrice as '价格',RtDamaged as '是否损坏', RtLost as '是否丢失' " +
                "from return_info ri,borrow_info bri,manager_info mi,book_storeinfo bsi,book_info bi where ri.MID=mi.MID and ri.BrNo=bri.BrNo and bsi.BSNo = bri.BSNo and bsi.ISBN=bi.ISBN";

            using (MySqlConnection showborrowConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(showBookCommandText, showborrowConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                returnRecords = dataTable;
            }
            return returnRecords;
        }
        public DataTable seekReturnRecordByBookName(string bookName)
        {
            DataTable dt = showReturn();

            DataRow[] foundRows = dt.Select(string.Format("书名 like '%{0}%'", bookName));
            DataTable returnData = dt.Clone();
            foreach (DataRow row in foundRows)
            {
                returnData.ImportRow(row);
            }
            return returnData;
        }
        public DataTable seekReturnRecordBySNo(string SNo)
        {
            DataTable dt = showReturn();

            DataRow[] foundRows = dt.Select(string.Format("读者编号 = '{0}'", SNo));
            DataTable returnData = dt.Clone();
            foreach (DataRow row in foundRows)
            {
                returnData.ImportRow(row);
            }
            return returnData;
        }

        public DataTable showFine_Overdue()
        {
            DataTable FineRecords;
            string showBookCommandText = "select ONo as '罚款序号', RtNo as '归还编号',oi.MID as '管理员工号',OFines as '罚款金额', OFStatus as '是否交款',ONotion as '备注'"+
                "from overdue_info oi,manager_info mi where oi.MID=mi.MID";

            using (MySqlConnection showborrowConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(showBookCommandText, showborrowConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                FineRecords = dataTable;
            }
            return FineRecords;
        }
        public DataTable showFine_Lost()
        {
            DataTable FineRecords;
            string showBookCommandText = "select LNo as '罚款序号', RtNo as '归还编号',li.MID as '管理员工号',LFines as '罚款金额', LFStatus as '是否交款',LNotion as '备注'" +
                "from lost_info li,manager_info mi where li.MID=mi.MID";

            using (MySqlConnection showborrowConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(showBookCommandText, showborrowConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                FineRecords = dataTable;
            }
            return FineRecords;
        }
        public DataTable showFine_Damaged()
        {
            DataTable FineRecords;
            string showBookCommandText = "select DNo as '罚款序号', RtNo as '归还编号',di.MID as '管理员工号',DFines as '罚款金额', DFStatus as '是否交款',DNotion as '备注'" +
                "from damaged_info di,manager_info mi where di.MID=mi.MID";

            using (MySqlConnection showborrowConnection = new MySqlConnection(connectionString))
            {
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(showBookCommandText, showborrowConnection);
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                FineRecords = dataTable;
            }
            return FineRecords;
        }

        public int addPublisher(string pressName,string human,string telephone,string province,string city,string addr)
        {
            string selectStr = string.Format("select *from publisher_info where PName = '{0}'",pressName);
            string addStr = string.Format("insert into publisher_info (PName,PLinkman,Ptelephone,PProvince,PCity,PAddr) " +
                "values('{0}','{1}','{2}','{3}','{4}','{5}')", pressName, human, telephone, province, city, addr);
            using (MySqlConnection addPublisherConnection = new MySqlConnection(connectionString))
            {
                addPublisherConnection.Open();
                MySqlTransaction trans = addPublisherConnection.BeginTransaction();
                MySqlCommand selectCommand = new MySqlCommand(selectStr, addPublisherConnection);
                selectCommand.Transaction = trans;
                MySqlDataReader myReader = selectCommand.ExecuteReader();
                if (myReader.HasRows){
                    myReader.Close();
                    trans.Rollback();
                    return 1;
                }
                else
                {
                    myReader.Close();
                    MySqlCommand addPublisherCommand = new MySqlCommand(addStr, addPublisherConnection);
                    addPublisherCommand.Transaction = trans;
                    int r = addPublisherCommand.ExecuteNonQuery();
                    if (r > 0)
                    {
                        trans.Commit();
                        return 0;
                    }
                    else
                    {
                        trans.Rollback();
                        return 2;
                    }
                        
                }
                

            }
        }
        public bool deletePublisher(int PID)
        {
            string publisherDeleteStr = "delete from publisher_info where PID='" + PID + "'";
            string foreign_key_checks_false = "SET foreign_key_checks = 0;";
            string foreign_key_checks = "SET foreign_key_checks = 1;";
            using (MySqlConnection publisherDeleteConnection = new MySqlConnection(connectionString))
            {
                publisherDeleteConnection.Open();
                MySqlTransaction trans = publisherDeleteConnection.BeginTransaction();
                MySqlCommand foreign_key_checks_falseCommand = new MySqlCommand(foreign_key_checks_false, publisherDeleteConnection);
                MySqlCommand foreign_key_checksCommand = new MySqlCommand(foreign_key_checks, publisherDeleteConnection);
                MySqlCommand deletePublisherCommand = new MySqlCommand(publisherDeleteStr, publisherDeleteConnection);
                foreign_key_checks_falseCommand.Transaction = trans;
                foreign_key_checksCommand.Transaction = trans;
                deletePublisherCommand.Transaction = trans;
                foreign_key_checks_falseCommand.ExecuteNonQuery();
                int r1 = deletePublisherCommand.ExecuteNonQuery();
                foreign_key_checksCommand.ExecuteNonQuery();

                if (r1 > 0)
                {
                    trans.Commit();
                    publisherDeleteConnection.Close();
                    return true;
                }
                else
                {
                    trans.Rollback();
                    publisherDeleteConnection.Close();
                    return false;
                }

            }
        }
        public DataTable seekPublisherByName(string pressName)
        {
            DataTable dt = getPublisher();

            DataRow[] foundRows = dt.Select(string.Format("出版社名称 like '%{0}%'", pressName));
            DataTable publisherData = dt.Clone();
            foreach (DataRow row in foundRows)
            {
                publisherData.ImportRow(row);
            }
            return publisherData;
        }
        public void PublisherInfoChange(int PID, string PName, string Plinkman,string Ptelephone,string PProvince,string PCity,string PAddr)
        {
            string bookInfoChangeCommandText = string.Format("update publisher_info set PName='{0}',PLinkman='{1}',Ptelephone='{2}',PProvince='{3}',PCity='{4}',PAddr='{5}' where PID={6}",
                PName, Plinkman, Ptelephone, PProvince, PCity, PAddr, PID);

            using (MySqlConnection bookInfoChangeConnection = new MySqlConnection(connectionString))
            {
                bookInfoChangeConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(bookInfoChangeCommandText, bookInfoChangeConnection);
                mySqlCommand.ExecuteNonQuery();
            }
        }
        public string[] PublisherInfos(int PID)
        {

            string publisherCommand = "select * from publisher_info where PID = '" + PID + "'";
            string[] publisherinfos = new string[7];

            using (MySqlConnection publisherConnection = new MySqlConnection(connectionString))
            {
                publisherConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(publisherCommand, publisherConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                while (mySqlDataReader.Read())
                {
                    publisherinfos[0] = mySqlDataReader["PID"].ToString();
                    publisherinfos[1] = mySqlDataReader["PName"].ToString();
                    publisherinfos[2] = mySqlDataReader["PLinkman"].ToString();
                    publisherinfos[3] = mySqlDataReader["PTelephone"].ToString();
                    publisherinfos[4] = mySqlDataReader["PProvince"].ToString();
                    publisherinfos[5] = mySqlDataReader["PCity"].ToString();
                    publisherinfos[6] = mySqlDataReader["PAddr"].ToString();
                }
            }
            return publisherinfos;
        }
    }
}
