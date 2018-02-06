using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLLDAL
{
    public static class GetGreadFromDB
    {
        public static DataTable getClassesDB()
        {
            string strSQL = "select distinct(Classes) from GreadSearch";
            DataTable DT= BLLDAL.DBConn.getDT(strSQL);
            return DT;
        }
        public static DataTable getGreadDB(string Classes)
        {
            string strSQL = "select distinct(Gread) from GreadSearch where Classes like '"+Classes+"'";
            DataTable DT = DBConn.getDT(strSQL);
            return DT;
        }
        public static DataTable getTeaComes()
        {
            string strSQL = "select distinct(TeaComes) from TeaInform";
            DataTable DT = DBConn.getDT(strSQL);
            return DT;
        }
    }
}
