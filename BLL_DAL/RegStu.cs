using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLLDAL
{
    public class RegStu
    {
        public static bool ifRegStu(string StuID,string StuName,string StuSex,string StuSchool,string StuPhone,string IncID)
        {
            string strSQL = "Insert into StuReg (StuID,StuName,StuSex,StuSchool,StuPhone,IncID) values ('" + StuID + "','" + StuName + "','" + StuSex + "','" + StuSchool + "','" + StuPhone + "','" + IncID + "')";
            try
            {
                bool IfREG = DBConn.DBCMD(strSQL);
                return IfREG;
            }
            catch
            {
                return false;
            }
        }
    }
}
