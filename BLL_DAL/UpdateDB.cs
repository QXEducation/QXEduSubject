using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLLDAL
{
    public class UpdateDB
    {
        public static bool UpdateStuDB(string StuID,string StuName,string StuSex,string StuSchool,string StuPhone)
        {
            string strSQL = "Update StuReg set StuName='" + StuName + "',StuSex='" + StuSex + "',StuSchool='" + StuSchool + "',StuPhone='" + StuPhone + "' where StuID='" + StuID + "'";
            try
            {
                bool isUpd = DBConn.DBCMD(strSQL);
                return isUpd;
            }
            catch
            {
                return false;
            }
        }
        public static bool UpdateChaDB(string StuID,string StuCharact,string TeaInform)
        {
            string strSQL = "Update StuCharact set StuCharact='" + StuCharact + "',TeaInform='" + TeaInform + "' where StuID='" + StuID + "'";
            try
            {
                bool isUpd = DBConn.DBCMD(strSQL);
                return isUpd;
            }
            catch
            {
                return false;
            }
        }
        public static DataTable getSelectTeacherCome(string TeaComes)
        {
            string strSQL = "select * from TeaInform where TeaComes='" + TeaComes + "'";
            DataTable getDt = DBConn.getDT(strSQL);
            return getDt;
        }
        public static DataTable getSelectTeacherName(string TeaName)
        {
            string strSQL = "select * from TeaInform where TeaName='" + TeaName + "'";
            DataTable getDt = DBConn.getDT(strSQL);
            return getDt;
        }
        public static DataTable getSelectALL()
        {
            string strSQL = "select * from TeaInform";
            DataTable getDT = DBConn.getDT(strSQL);
            return getDT;
        }
        public static DataTable getStuReg(string StuID)
        {
            string strSQL = "select * from StudentregList where StuID='"+StuID+"'";
            DataTable DT = DBConn.getDT(strSQL);
            return DT;
        }
    }
}
