using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace AccessTool
{
    public static class SqlHelper
    {
        //执行sql   返回执行条数
        //执行select 返回table       public static DataTable GetTable(string connectionString, string Table)
        //执行ExecuteScalar 返回第一行第一列
        //执行ExecuteReader 返回第一行，可以继续往下读
        //更新GridView数据

        //准备cmd
        private static void PrepareCommand(OleDbCommand cmd, OleDbConnection conn, string cmdText, params OleDbParameter[] cmdParms)
        {
            //判断数据库连接状态
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (cmdParms != null)
            {
                foreach (OleDbParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }

        // 单个执行
        public static int ExecuteNonQuery(string connectionString, string sql, params OleDbParameter[] commandParameters)
        {
            OleDbCommand cmd = new OleDbCommand();
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                PrepareCommand(cmd, con, sql, commandParameters);
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                    return i;
                }
                catch { return 0; }
            }
        }

        //批量执行
        public static int ExecuteNonQuery(string connectionString, params string[] sqls)
        {
            OleDbCommand cmd = new OleDbCommand();
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                int count = 0;
                foreach (string sql in sqls)
                {
                    PrepareCommand(cmd, con, sql, null);
                    try
                    {
                        count += cmd.ExecuteNonQuery();
                        Tool.WriteFile("SQL", sql + "\t" + DateTime.Now);
                    }
                    catch (Exception e)
                    {
                        Tool.WriteFile("Error",sql+"\t" + e.Message.ToString() + "\t" + DateTime.Now);
                    }
                }
                return count;
            }
        }

        //获取表格
        public static DataTable GetTable(string connectionString, string Table)
        {
            string sql = "select * from " + Table;
            return GetTableBySql(connectionString, sql);
        }

        public static DataTable GetTableBySql(string connectionString, string sql)
        {
            DataSet dataset = new DataSet();
            OleDbCommand cmd = new OleDbCommand();
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                PrepareCommand(cmd, con, sql, null);
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                adapter.Fill(dataset);
            }
            return dataset.Tables[0];
        }

        //返回第一行第一列
        public static object ExecuteScalar(string connectionString, string sql)
        {
            OleDbCommand cmd = new OleDbCommand();
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                PrepareCommand(cmd, con, sql, null);
                return (cmd.ExecuteScalar());
            }
        }

        public static OleDbDataReader ExecuteReader(string constr, string sql, params OleDbParameter[] SqlParameters)
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbConnection conn = new OleDbConnection(constr);
            PrepareCommand(cmd, conn, sql, SqlParameters);
            return (cmd.ExecuteReader(CommandBehavior.CloseConnection));
        }

        public static void UpdateDataGridViewToDB(string connect, DataTable dt, string sql)
        {
            OleDbDataAdapter ad = new OleDbDataAdapter();
            using (OleDbConnection con = new OleDbConnection(connect))
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand(sql, con);
                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                OleDbCommandBuilder sb = new OleDbCommandBuilder(adapter);
                adapter.Update(dt);
            }
        }

        public static List<string> GetListfFromDataTable(DataTable table, string Name)
        {
            List<string> list = new List<string>();
            foreach (DataRow row in table.Rows)
            {
                if (row[Name].ToString() != "")
                    list.Add(row[Name].ToString());
            }
            return list;
        }

        public static List<string> GetListFromDB(string connectionString, string table, string columnName)
        {
            DataTable tb = GetTable(connectionString, table);
            return GetListfFromDataTable(tb, columnName);
        }

        public static List<string> GetTableName(string fileName)
        {
            List<string> liststringall = new List<string>();
            List<string> liststring = new List<string>();
            string ConnectionString = "provider=microsoft.jet.oledb.4.0;data source=" + fileName;
            OleDbConnection Conn = new OleDbConnection(ConnectionString);
            Conn.Open();
            DataTable shemaTable = Conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            foreach (DataRow dr in shemaTable.Rows)
            {
                string Name = dr["TABLE_NAME"].ToString();
                if (Name.ToLower().Contains("point"))
                    liststringall.Add(Name);
            }
            foreach (string str in liststringall)
            {
                string temp = str.Substring(0, 2);
                if (liststring.IndexOf(temp) == -1)
                {
                    liststring.Add(temp);
                }
            }
            Conn.Close();
            return liststring;
        }
        public static List<string> GetColumns(string fileName,string tableName)
        {
            List<string> liststring = new List<string>();
            string ConnectionString = "provider=microsoft.jet.oledb.4.0;data source=" + fileName;
            OleDbConnection Conn = new OleDbConnection(ConnectionString);
            Conn.Open();
            DataTable columnTable = Conn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, null, tableName, null });
            foreach (DataRow dr2 in columnTable.Rows)
            {
                liststring.Add(dr2["COLUMN_NAME"].ToString());
            }
            Conn.Close();
            return liststring;
        }

    }
}