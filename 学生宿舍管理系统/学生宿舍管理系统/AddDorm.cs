using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 学生宿舍管理系统
{
    public partial class AddDorm : Form
    {
        public AddDorm()
        {
            InitializeComponent();
        }
        void clear()
        {
            txtdormbed.Text = "";
            txtdormdesk.Text = "";
            txtdormdirection.Text = "";
            txtdormID.Text = "";
            txtdormMoney.Text = "";
            txtdormremark.Text = "";
            txtdormschair.Text = "";
        }
        SqlConnection cn = new SqlConnection(Form1.constr);
        private void btnadddrom_Click(object sender, EventArgs e)
        {
            if (txtdormID.Text == "" || txtdormbed.Text == "")
            {
                MessageBox.Show("请输入完整信息"); 
            }
            else
            {
                try
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    string sqlstring = string.Format("select * from dorm where dormID='{0}'", txtdormID.Text);
                    SqlCommand cmd = new SqlCommand(sqlstring, cn);
                    if (cmd.ExecuteScalar() == null)
                    {
                        string insertsqlstring = string.Format("insert into dorm values('{0}','{1}',{2},{3},{4},'{5}','{6}')", txtdormID.Text, txtdormMoney.Text, txtdormbed.Text, txtdormschair.Text, txtdormdesk.Text, txtdormdirection.Text, txtdormremark.Text);
                        cmd.CommandText = insertsqlstring;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("添加宿舍成功");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("宿舍号重复");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (cn.State == ConnectionState.Open)
                        cn.Close();
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
