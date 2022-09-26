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
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(Form1.constr);
        private void btnadd_Click(object sender, EventArgs e)
        {
            string insetrstr = string.Format("insert into userinformation values('{0}','1')", txtusername.Text, txtpassword2.Text);
            if (txtpassword.Text != txtpassword2.Text)
            {
                MessageBox.Show("两次输入的结果不一致");
            }
            else
            {
                SqlCommand cmd = new SqlCommand(insetrstr, cn);
                try
                {
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("插入成功");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
        }
    }
}
