using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;



namespace BLLDAL
{
    class OLEDBDBHelper
        //备注 链接地址 尝试用文件链接
        //     转移时修改路径
    {
        public static DataTable getDT(string strSQL)
        {
             string strConn=@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\QXEDUProject-offline\QXEDU-Offline\QXEDU-Offine.accdb;Persist Security Info=False;";
            //string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\54433\Desktop\QXEDUProject-offline\QXEDU-Offline\QXEDU-Offine.accdb;Persist Security Info=False;";
            //string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data source = "& Application.StartPath& "\\QXEDU-Offine.accdb & ""
            //string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:\QXEDUProject-offline\QXEDU-Offline\QXEDU-Offine.accdb;Persist Security Info=False;";
            OleDbConnection Conn = new OleDbConnection(strConn);
            Conn.Open();

            OleDbDataAdapter DA = new OleDbDataAdapter(strSQL, Conn);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            return DT;
        }
        public static bool DBCMD(string strSQL)
        {
            string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\QXEDUProject-offline\QXEDU-Offline\QXEDU-Offine.accdb;Persist Security Info=False;";
            // string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\54433\Desktop\QXEDUProject-offline\QXEDU-Offline\QXEDU-Offine.accdb;Persist Security Info=False;";
            // string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:\QXEDUProject-offline\QXEDU-Offline\QXEDU-Offine.accdb;Persist Security Info=False;";
            OleDbConnection Conn = new OleDbConnection(strConn);
            Conn.Open();
            try
            {
                OleDbCommand cmd = new OleDbCommand(strSQL, Conn);
                cmd.ExecuteNonQuery();
                Conn.Close();
                return true;
            }
            catch
            {
                Conn.Close();
                return false;
            }
        }
    }
}
