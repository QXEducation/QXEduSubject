using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLLDAL
{
    public class TeaSubject
    {
        public static DataTable getTeaCher(string teaName)
        {
            string strSQL = "select * from TeaInform where TeaName = '" + teaName + "'";
            DataTable DT = DBConn.getDT(strSQL);
            return DT;
        }
        public static DataTable getTeaInform(string TeaID)
        {
            string strSQL = "select * from TeaInform where TeaID='" + TeaID + "'";
            DataTable DT = DBConn.getDT(strSQL);
            return DT;
        }
        public static bool ifInsert(string TeaID, string SubjectID, string SPFT)
        {
            string strSQL = "insert into TeaSubject (TeaID,SubjectID,SubPriForTea) values('" + TeaID + "','" + SubjectID + "','" + SPFT + "')";
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
        public static bool check(string TeaID,string subjectID)
        {
            string strSQL = "select * from TeaSubject where TeaID='" + TeaID + "'and SubjectID='" + subjectID + "'";
            DataTable DT = DBConn.getDT(strSQL);
            if(DT.Rows.Count==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
