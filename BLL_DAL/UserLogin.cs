using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLLDAL
{
    public class UserLogin
    {
        public static int ifLogin(String UserID, String UserPWD)
        {
            string strSQL = "select * from UserLogin where UserName = '" + UserID + "'";
            DataTable DT = DBConn.getDT(strSQL);
            if (DT == null)
                return 3;
            if (DT.Rows.Count == 0)
                return 2;
            else if (DT.Rows[0]["UserPWD"].ToString() != UserPWD)
                return 0;
            else 
                return 1;
        }
    }
}
