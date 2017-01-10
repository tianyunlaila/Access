using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccessTool
{
    public class Tool
    {
        //获取文件名
        public static string GetFileName()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "./";
            ofd.Filter = "数据库文件|*.mdb";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }
            else return null;
        }

        //写入文件
        public static void WriteFile(string fileName, string str)
        {
            string fName = "./" + fileName + ".txt";
            StreamWriter sw = new StreamWriter(fName, true, Encoding.Default);
            sw.Write(str);
            sw.Write("\r\n");
            sw.Close();
        }

        public static List<string> ReplaceList(List<string> liststring, string oldStr, string newStr)
        {
            List<string> list = new List<string>();
            foreach (string s in liststring)
            {
                list.Add(s.Replace(oldStr, newStr));
            }
            return list;
        }

        public static List<string> GetListFromString(string str)
        {
            List<string> sqls = new List<string>();
            string[] strTemp = str.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in strTemp)
            {
                if (s != "")
                    sqls.Add(s);
            }
            return sqls;
        }
    }
}