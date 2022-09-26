using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace 学生宿舍管理系统
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public static string username;
        public static string constr = ConfigurationManager. ConnectionStrings ["myDBconnection"].ConnectionString.ToString();
        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["myDBconnection"].ConnectionString;
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            string str = string.Format("select * from userinformation where usernarne='{0}' and userpassword='{1}'", txtusername.Text, txtpassword.Text);
            SqlConnection cn = new SqlConnection(GetConnectionString());
            SqlCommand cmd = new SqlCommand(str, cn);
            if (txtusername.Text == "")
            {
                MessageBox.Show("用户名不能为空");
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("密码不能为空");
            }
            else
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("登录成功");
                    this.Hide();
                    username = txtusername.Text;
                    MainForm frm = new MainForm();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("登陆失败");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
