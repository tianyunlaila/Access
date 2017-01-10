using AccessTool;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccessModel;
namespace AccessDAL
{
    public class SqlDAL
    {
        private string connectsupport = "provider=microsoft.jet.oledb.4.0;data source=SupportTian.mdb";

        public List<string> OpenFile()
        {
            List<string> list = new List<string>();
            string tubeType = "";
            string fileName = Tool.GetFileName();
            if (fileName == null)
            {
                return null;
            }
            List<string> listTubeType = SqlHelper.GetTableName(fileName);
            MyString.listTube.Clear();
            MyString.listTube.AddRange(listTubeType);
            foreach (string str in listTubeType)
            {
                tubeType += str;
                tubeType += ",";
            }
            list.Add(fileName);
            list.Add(tubeType.Remove(tubeType.LastIndexOf(",")));
            return list;
        }

        public string CreateSqls(string tubeType, string sqlYS)
        {
            string sqls = "";
            string[] arrayTube = tubeType.Split(',');
            List<string> listTube = new List<string>();
            foreach (string str in arrayTube)
            {
                if (str != "")
                    listTube.Add(str);
            }
            foreach (string str in listTube)
            {
                sqls += sqlYS.Replace("ys", str);
                sqls += "\r\n";
            }
            return sqls;
        }

        public int UpdateSqls(string connect, string strSqls)
        {
            List<string> sqls = Tool.GetListFromString(strSqls);
            return SqlHelper.ExecuteNonQuery(connect, sqls.ToArray());
        }

        public int AddGroupNumber(string groupNumber, string connect)
        {
            List<string> list = SqlHelper.GetListFromDB(connectsupport, "批量命令", "添加组号");
            List<string> sqls = Tool.ReplaceList(list, "ZCC26", groupNumber);
            return SqlHelper.ExecuteNonQuery(connect, sqls.ToArray());
        }

        public int UpdateFromDB(string connect, string tableName, string column)
        {
            List<string> list = SqlHelper.GetListFromDB(connectsupport, tableName, column);
            return SqlHelper.ExecuteNonQuery(connect, list.ToArray());
        }

        public int UpdateCLY(string connect)
        {
            DataTable tableSupport = SqlHelper.GetTable(connectsupport, "测量员"); //测量员表
            DataTable tableGL = SqlHelper.GetTable(connectsupport, "类别设置");//管类表
            List<string> GL = SqlHelper.GetListfFromDataTable(tableGL, "子类代码");//获取管类
            List<string> updateCeLiangYuanSqls = new List<string>();//sqs
            foreach (string gl in GL)
            {
                foreach (DataRow dr in tableSupport.Rows)
                {
                    string sql1 = "update " + gl + "_point set 测量员='" + dr["测量员"] + "',检查员='" + dr["检查员"] + "' where 物探点号 like '" + dr["组号"] + "%'";
                    string sql2 = "update " + gl + "_line set 测量员='" + dr["测量员"] + "',检查员='" + dr["检查员"] + "' where 起点号 like '" + dr["组号"] + "%'";
                    updateCeLiangYuanSqls.Add(sql1);
                    updateCeLiangYuanSqls.Add(sql2);
                }
            }
            return SqlHelper.ExecuteNonQuery(connect, updateCeLiangYuanSqls.ToArray());
        }

        public DataTable GetTableBySqls(string connect, string sqls)
        {
            return SqlHelper.GetTableBySql(connect, sqls);
        }

        public void UpdateGridView(string connect, DataTable dt, string sqls)
        {
            SqlHelper.UpdateDataGridViewToDB(connect, dt, sqls);
        }

        public void WellDepth()
        {
            test testform = new test();
            testform.Show();
            string sqlPoint = @"select 物探点号,井深 from ys_point where 附属物 is not null and 附属物 not in ('闸阀','蝶阀','消防栓','水表','排气阀','发射塔','接线箱','线杆','环网柜','控制柜','信号灯','路灯','阀门','阴极测试桩','真空表','变压器','监控器','配电房','接(分)线箱')";
            string sqlLine = @"select 起点号,终点号,起点埋深,终点埋深 from ys_line";
            string sqlUpdate = @"update ys_point set 井深='@井深' where 物探点号='@物探点号'";
            foreach (string tube in MyString.listTube)
            {
                string sqlPointTube = sqlPoint.Replace("ys", tube);
                string sqlLineTube = sqlLine.Replace("ys", tube);
                DataTable pointTable = SqlHelper.GetTableBySql(MyString.connectString, sqlPointTube);
                DataTable lineTable = SqlHelper.GetTableBySql(MyString.connectString, sqlLineTube);
                foreach (DataRow pointRow in pointTable.Rows)
                {
                    StringBuilder pointNumberStringBuilder = new StringBuilder(pointRow["物探点号"].ToString());
                    StringBuilder pointDepthStringBuilder = new StringBuilder(pointRow["井深"].ToString());
                    if (pointDepthStringBuilder.ToString() == "")
                    {
                        pointDepthStringBuilder = new StringBuilder("0");
                    }
                    double depth = 0;
                    foreach (DataRow lineRow in lineTable.Rows)
                    {
                        if (pointNumberStringBuilder.ToString() != lineRow["起点号"].ToString())
                        {
                            continue;
                        }
                        if (Convert.ToDouble(pointDepthStringBuilder.ToString()) < Convert.ToDouble(lineRow["起点埋深"]) && depth < Convert.ToDouble(lineRow["起点埋深"]))
                        {
                            depth = Convert.ToDouble(lineRow["起点埋深"]);
                        }
                    }
                    foreach (DataRow lineRow in lineTable.Rows)
                    {
                        if (pointNumberStringBuilder.ToString() != lineRow["终点号"].ToString())
                        {
                            continue;
                        }
                        if (Convert.ToDouble(pointDepthStringBuilder.ToString()) < Convert.ToDouble(lineRow["终点埋深"]) && depth < Convert.ToDouble(lineRow["终点埋深"]))
                        {
                            depth = Convert.ToDouble(lineRow["终点埋深"]);
                        }
                    }
                    if (depth != 0)
                    {
                        string sqlUpdate1 = sqlUpdate.Replace("ys", tube).Replace("@井深", (depth + 0.02).ToString()).Replace("@物探点号", pointNumberStringBuilder.ToString());
                        SqlHelper.ExecuteNonQuery(MyString.connectString, sqlUpdate1);
                        MyString.count++;
                        testform.label1.Text = MyString.count.ToString();
                        testform.Refresh();
                    }
                }
            }
        }

        public int GXSJ()
        {
            int count = 0;
            List<string> sqList = new List<string>();
            sqList.Add(@"update YSPOINT set GXSJ='2015年11月'");
            sqList.Add(@"update YSLINE set GXSJ='2015年11月'");
            foreach (string tube in MyString.listTube)
            {
                count += SqlHelper.ExecuteNonQuery(MyString.connectString, sqList[0].Replace("YS", tube));
                count += SqlHelper.ExecuteNonQuery(MyString.connectString, sqList[1].Replace("YS", tube));
            }
            return count;
        }

        public void GroupNumber(string groupNumber)
        {
            FileInfo fileNameInfo = new FileInfo(MyString.fileName);
            string newFileName = string.Format("{0}\\{1}.mdb", fileNameInfo.DirectoryName, groupNumber);
            File.Copy(MyString.fileName, newFileName);
            string conn = "provider=microsoft.jet.oledb.4.0;data source=" + newFileName;
            int length = groupNumber.Length;
            List<string> msqList = new List<string>();
            foreach (string tube in MyString.listTube)
            {
                msqList.Clear();
                string sqlPoint = string.Format(@"delete * from {0}_point where 物探点号 not like '{1}{2}%'", tube, groupNumber, tube.ToUpper());
                string sqlLine1 = string.Format(@"delete * from {0}_line where 起点点号 not like '{1}{2}%'", tube, groupNumber, tube.ToUpper());
                string sqlLine2 = string.Format(@"delete * from {0}_line where 链接方向 not like '{1}{2}%'", tube, groupNumber, tube.ToUpper());
                msqList.Add(sqlPoint);
                msqList.Add(sqlLine1);
                msqList.Add(sqlLine2);
                SqlHelper.ExecuteNonQuery(conn, msqList.ToArray());
            }
        }
        public void UpdateGroupNumber()
        {
            List<string> msqList = new List<string>();
            foreach (string tube in MyString.listTube)
            {
                msqList.Clear();
                string sqlPoint1 = string.Format(@"update {0}_point set 物探点号=(mid(物探点号,1,3)+'0'+mid(物探点号,4,20)) where mid(物探点号,5,1) not in ('0','1','2','3','4','5','6','7','8','9')", tube);
                string sqlPoint2 = string.Format(@"update {0}_point set 偏心点号=(mid(偏心点号,1,3)+'0'+mid(偏心点号,4,20)) where 偏心点号 is not null and mid(偏心点号,5,1) not in ('0','1','2','3','4','5','6','7','8','9')", tube);
                string sqlLine1 = string.Format(@"update {0}_line set 起点号=(mid(起点号,1,3)+'0'+mid(起点号,4,20)) where mid(起点号,5,1) not in ('0','1','2','3','4','5','6','7','8','9')", tube);
                string sqlLine2 = string.Format(@"update {0}_line set 终点号=(mid(终点号,1,3)+'0'+mid(终点号,4,20)) where mid(终点号,5,1) not in ('0','1','2','3','4','5','6','7','8','9')", tube);
                msqList.Add(sqlPoint1);
                msqList.Add(sqlPoint2);
                msqList.Add(sqlLine1);
                msqList.Add(sqlLine2);
                SqlHelper.ExecuteNonQuery(MyString.connectString, msqList.ToArray());

            }
            MessageBox.Show("已成功把一位组号编程两位");
        }
    }
}