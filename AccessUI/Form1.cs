using AccessBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccessModel;

namespace AccessUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlBLL sb = new SqlBLL();
        private string connect = null;
        public DataTable dt = new DataTable();

        private void btnOpenDBFile_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void Open()
        {
            try
            {
                List<string> str = sb.OpenFile();
                if (str == null)
                {
                    return;
                }
                lblFileName.Text = str[0];
                lblFileName2.Text = str[0];
                MyString.fileName = lblFileName.Text;
                txtTubeType.Text = str[1];
            }
            catch
            {
            }
            
            connect = "provider=microsoft.jet.oledb.4.0;data source=" + lblFileName.Text;
            MyString.connectString = connect;
        }

        private void btnCreatSqls_Click(object sender, EventArgs e)
        {
            txtSqls.Text = sb.CreateSqls(txtTubeType.Text, txtSqlYS.Text);
        }

        private void btnUpdateBySqls_Click(object sender, EventArgs e)
        {
            if (connect == null)
            {
                return;
            }
            int success = sb.UpdateSqls(connect, txtSqls.Text);
            MessageBox.Show("更改了" + success + "条数据！");
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            txtSqls.SelectAll();
            txtSqls.Copy();
        }

        private void btnOpenFile2_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void btnAddGroupNumber_Click(object sender, EventArgs e)
        {
            int success = sb.AddGroupNumber(txtGroupNumber.Text, connect);
            MessageBox.Show("更改了" + success + "条数据！");
        }

        private void btnBatchUpdate_Click(object sender, EventArgs e)
        {
            if (chkQuanShu.Checked == true)
            {
                int i = sb.UpdateFromDB(connect, "批量命令", "权属单位");
                lbl1.Text = i.ToString();
            }
            if (chkDate.Checked == true)
            {
                int i = sb.UpdateFromDB(connect, "批量命令", "日期");
                lbl2.Text = i.ToString();
            }
            if (chkDelete.Checked == true)
            {
                int i = sb.UpdateFromDB(connect, "批量命令", "删除");
                lbl3.Text = i.ToString();
            }
            if (chkKCDW.Checked == true)
            {
                int i = sb.UpdateFromDB(connect, "批量命令", "勘测单位");
                lbl4.Text = i.ToString();
            }
            if (chkYSBM.Checked == true)
            {
                int i = sb.UpdateFromDB(connect, "批量命令", "要素编码");
                lbl5.Text = i.ToString();
            }
            if (chkTCFS.Checked == true)
            {
                int i = sb.UpdateFromDB(connect, "批量命令", "探测方式");
                lbl6.Text = i.ToString();
            }
            if (chkRoad.Checked == true)
            {
                int i = sb.UpdateFromDB(connect, "批量命令", "道路一致");
                lbl7.Text = i.ToString();
            }
            if (chkCLY.Checked == true)
            {
                sb.UpdateFromDB(connect, "批量命令", "检查员");
                int i = sb.UpdateCLY(connect);
                lbl8.Text = i.ToString();
            }
            if (chkGXLX.Checked == true)
            {
                int i = sb.UpdateFromDB(connect, "批量命令", "管线类型");
                lbl9.Text = i.ToString();
            }
            if (chkZX.Checked == true)
            {
                int i = sb.UpdateFromDB(connect, "a", "sql");
                lbl10.Text = i.ToString();
            }
            MessageBox.Show("执行完毕");
        }

        private void btnShowAllTubeType_Click(object sender, EventArgs e)
        {
            txtTubeType.Text = "JS,ZS,YS,WS,HS,GD,LD,XH,DX,LT,YD,TT,DT,JK,JY,TV,GT,MQ,TQ,ZQ,RS,SY,DQ,YG,KQ,RF,YQ,CT,BM,WT,JT";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                txtSqls.Text = txtSqls.Text.Remove(txtSqls.Text.LastIndexOf(" union"));
            }
            catch 
            {}
            dt = sb.GetTableBySqls(connect, txtSqls.Text);
            dgvSelect.DataSource = dt;
        }

        private void btnUpdateSelect_Click(object sender, EventArgs e)
        {
            //DataTable newTable = (DataTable) dgvSelect.DataSource;
            //DataTable originTable = sb.GetTableBySqls(connect, txtSqls.Text);
            //originTable.Rows.Clear();
            //foreach (DataRow row in newTable.Rows)
            //{
            //    originTable.ImportRow(row);
            //}
            //sb.UpdateGridView(connect, originTable, txtSqls.Text);
            sb.UpdateGridView(connect, dt, txtSqls.Text);
        }

        private void btnWellDepth_Click(object sender, EventArgs e)
        {
            //Thread th = new Thread(test);
            //th.IsBackground = true;
            //th.Start();
            sb.WellDepth(MyString.connectString);
            MessageBox.Show("OK");
        }

        void test()
        {
            ProgressBar prgBar = new ProgressBar();
            prgBar.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.toolStripStatusLabel1.Text = MyString.count.ToString();
        }

        private void btnGXSJ_Click(object sender, EventArgs e)
        {
            int i = sb.GXSJ();
            MessageBox.Show(i.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            筛选组号 form筛选组号 = new 筛选组号();
            form筛选组号.Show();
        }

        private void 打开SQL文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start("SQL");
        }
        private void start(string fileName)
        {  
            ProcessStartInfo startInfo = new ProcessStartInfo(string.Format(@".\{0}.txt",fileName));
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();
        }

        private void 打开Error文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start("Error");
        }

        private void 清空Error文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (File.Create(@".\Error.txt"))
            {           
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void btnUpdateGroupNumber_Click(object sender, EventArgs e)
        {
            sb.UpdateGroupNumber();
        }
    }
}