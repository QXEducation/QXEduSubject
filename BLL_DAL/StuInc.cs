using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLLDAL
{
    public static class StuInc
    {
        public static bool ifInsert(string IncID,string stuName,string StuSex,string StuSchool,string StuPhone,string StuInc)
        {
            try
            {
                string strSQL = "Insert into StuInclination (IncId,StuName,StuSex,StuSchool,StuPhone,StuInc) values ('" + IncID + "','" + stuName + "','" + StuSex + "','" + StuSchool + "','" + StuPhone + "','" + StuInc + "')";
                bool isInsert = BLLDAL.DBConn.DBCMD(strSQL);
                return isInsert;
            }
            catch
            {
                return false;
            }
        }
    }
}
