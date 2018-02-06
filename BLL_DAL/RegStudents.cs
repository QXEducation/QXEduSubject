using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLLDAL
{
    public class RegStudents
    {
        public static int /*DataTable*/ getRegIDDT()
        {
            string strSQL = "select count(*) from StudentRegList";
            try
            {
                DataTable DT = DBConn.getDT(strSQL);
                int count = (int)DT.Rows[0][0];
                return count;
            }
            catch
            {
                return -1;
            }
        }
        public static DataTable getStuID(string StuName)
        {
            string strSQL = "select * from StuReg where StuName ='" + StuName + "'";
            DataTable DT = DBConn.getDT(strSQL);
            return DT;
        }
        public static DataTable getSubID(string Gread)
        {
            string strSQL = "select * from SubjectList where SubjectGread = '"+Gread+"'";
            DataTable DT = DBConn.getDT(strSQL);
            return DT;
        }
        public static DataTable getSubject(string SubID)
        {
            string strSQL = "select * from SubjectList where SubjectID='" + SubID + "'";
            DataTable DT = DBConn.getDT(strSQL);
            return DT;
        }
        public static DataTable getStudent(string stuID)
        {
            string strSQL = "select * from StuReg where stuID='" + stuID + "'";
            DataTable DT = DBConn.getDT(strSQL);
            return DT;
        }
        public static bool Insert(string RegID,string StuID,string StuRegGread,string SubjectID,string Price,string PayFor)
        {
            string strSQL = "Insert into StudentRegList (RegID,StuID,StuRegGread,SubjectID,Price,PayFor)values('" + RegID + "','" + StuID + "','" + StuRegGread + "','" + SubjectID + "','" + Price + "','" + PayFor + "')";
            try
            {
                bool Insert = DBConn.DBCMD(strSQL);
                return Insert;
            }
            catch
            {
                return false;
            }
        }
        public static bool ReInsert(string StuID,string StuName,string StuSex,string StuSchool,string StuPhone, string RegID, string StuRegGread, string SubjectID, string Price, string PayFor)
        {
            bool ifreInsert=RegStu.ifRegStu(StuID, StuName, StuSex, StuSchool, StuPhone, null);
            bool Insert = RegStudents.Insert(RegID, StuID, StuRegGread, SubjectID, Price, PayFor);
            if(ifreInsert&&Insert)
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
