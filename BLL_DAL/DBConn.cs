using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLLDAL
{
    public class DBConn
    {
        public static bool DBCMD(string strSQL)
        {
            bool ifInsert=OLEDBDBHelper.DBCMD(strSQL);
            return ifInsert;
        }
        public static DataTable getDT(string strSQL)
        {
            DataTable DT = OLEDBDBHelper.getDT(strSQL);
            return DT;
        }
    }
}
