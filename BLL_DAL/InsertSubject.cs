using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLLDAL
{
    public class InsertSubject
    {
        public static bool InsSub(string SubID, string SubName, string SubGread1, string SubGread2, string SubTime, string SubPrice, string IfPacked, string SubText)
        {
            string SubjectGread = SubGread1 + SubGread2;
            string strSQL = "Insert into SubjectList (SubjectID,SubjectGread,SubjectName,SubjectText,SubjectPrice,SubjectTime,IfPacket)values('" + SubID + "','" + SubjectGread + "','"+SubName+"','"+SubText+"','"+SubPrice+"','"+SubTime+"','"+IfPacked+"')";
            try
            {
                bool ifReturn=DBConn.DBCMD(strSQL);
                return ifReturn;
            }
            catch
            {
                return false;
            }
        }

    }
}
