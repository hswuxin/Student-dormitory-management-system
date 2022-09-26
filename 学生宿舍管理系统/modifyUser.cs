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
    public partial class modifyUser : Form
    {
        public modifyUser()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(Form1.constr);
        private void btnmoddify_Click(object sender, EventArgs e)
        {
            string updatestring = string.Format("update userinformation set userpassword='{0}' where userinformation.usernarne='{1}'", txtnewpassword2.Text, txtusername.Text);
            string selestring = string.Format("select * from userinformation where usernarne='{0}' and userpassword='{1}'", txtusername.Text, txtpassword.Text);
            SqlCommand cmd = new SqlCommand(selestring, cn);
            if (txtusername.Text == "")
            {
                MessageBox.Show("用户名为空");
                txtusername.Focus();
            }
            if (txtpassword.Text == "")
            {
                MessageBox.Show("请输入密码");
                txtpassword.Focus();
            }
            if (txtnewpassword.Text != txtnewpassword2.Text)
            {
                MessageBox.Show("两次输入的密码不一样");
                txtnewpassword2.Focus();
                txtnewpassword2.SelectAll();
            }
            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    DBAccess.EXE_update(updatestring);
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
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

        private void modifyUser_Load(object sender, EventArgs e)
        {
            txtusername.Text = Form1.username;
            txtusername.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
