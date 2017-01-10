using AccessDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModel;

namespace AccessBLL
{
    public class SqlBLL
    {
        private SqlDAL sd = new SqlDAL();

        public List<string> OpenFile()
        {
            return sd.OpenFile();
        }

        public string CreateSqls(string tubeType, string sqlYS)
        {
            return sd.CreateSqls(tubeType, sqlYS);
        }

        public int UpdateSqls(string connect, string sqls)
        {
            return sd.UpdateSqls(connect, sqls);
        }

        public int AddGroupNumber(string groupNumber, string connect)
        {
            return sd.AddGroupNumber(groupNumber, connect);
        }

        public int UpdateFromDB(string connect, string tableName, string column)
        {
            return sd.UpdateFromDB(connect, tableName, column);
        }

        public int UpdateCLY(string connect)
        {
            return sd.UpdateCLY(connect);
        }

        public DataTable GetTableBySqls(string connect, string sqls)
        {
            return sd.GetTableBySqls(connect, sqls);
        }

        public void UpdateGridView(string connect, DataTable dt, string sqls)
        {
            sd.UpdateGridView(connect, dt, sqls);
        }

        public void WellDepth(string connect)
        {
            if (connect == "")
            {
                return;
            }
            sd.WellDepth();
        }

        public int GXSJ()
        {
            if (MyString.connectString == "")
            {
                return 0;
            }
            return  sd.GXSJ();
        }

        public void GroupNumber(string str)
        {
            if (str == "")
            {
                return;
            }
            sd.GroupNumber(str);
        }

        public void UpdateGroupNumber()
        {
            if (MyString.connectString == null)
            {
                return;
            }
            sd.UpdateGroupNumber();
        }
    }
}