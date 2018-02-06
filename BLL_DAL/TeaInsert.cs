using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL_DAL
{
    public class TeaInsert
    {
        public static bool InsTea(string TeaID,string TeaName,string TeaSex,string TeaPhone,string TeaUs,string TeaComes)
        {
            string strSQL = "Insert into TeaInform (TeaID,TeaName,TeaSex,TeaPhone,TeaUs,TeaComes)values('"+TeaID+"','"+TeaName+"','"+TeaSex+"','"+TeaPhone+"','"+TeaUs+"','"+TeaComes+"')";
            try
            {
                bool isInsert=BLLDAL.DBConn.DBCMD(strSQL);
                return isInsert;
            }
            catch
            {
                return false;
            }

        }
           
    }
}
