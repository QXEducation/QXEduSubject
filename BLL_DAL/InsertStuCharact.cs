using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLLDAL
{
    public class InsertStuCharact
    {
        public static DataTable getComDT(string stuName)
        {
            string strSQL = "select * from StuReg where StuName='" + stuName + "'";
            DataTable IDdt = DBConn.getDT(strSQL);
            return IDdt;
        }
        public static DataTable getChaDT(string stuID)
        {
            string strSQL = "select * from StuCharact where StuID='" + stuID + "'";
            DataTable getChaDT = DBConn.getDT(strSQL);
            return getChaDT;
        }
        public static bool ifInsert(string stuID, string StuCharact, string TeaInform)
        {
            string strSQL = "Insert into StuCharact (StuID,StuCharact,TeaInform)values('" + stuID + "','" + StuCharact + "','" + TeaInform + "')";
            try
            {
                bool ifInsert = DBConn.DBCMD(strSQL);
                return ifInsert;
            }
            catch
            {
                return false;
            }
        }
    }
}
