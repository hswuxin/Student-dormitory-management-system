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
    public partial class ModifyDorm : Form
    {
        public ModifyDorm()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(Form1.constr);
        private void btnadddrom_Click(object sender, EventArgs e)
        {
            if (txtdormID.Text == "" || txtdormbed.Text == "" || txtdormdirection.Text == "" || txtdormMoney.Text == "" || txtdormremark.Text == "" || txtdormschair.Text == "")
            {
                MessageBox.Show("请输入数据");
            }
            else
            {
                try
                {
                    cn.Open();
                    string strsql = string.Format("update dorm set dormMoney='{0}',dormbed={1},dormchair={2},dormndesk={3},dormdirection='{4}',dormremark='{5}' where dormID='{6}'", 
                        txtdormMoney.Text, txtdormbed.Text, txtdormschair.Text, txtdormdesk.Text, txtdormdirection.Text, txtdormremark.Text, txtdormID.Text);
                    SqlCommand cmd = new SqlCommand(strsql,cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void ModifyDorm_Load(object sender, EventArgs e)
        {

        }
    }
}
