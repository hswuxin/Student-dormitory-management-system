using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace 学生宿舍管理系统
{
    public partial class addStudent : Form
    {
        SqlConnection cn = new SqlConnection(Form1.constr);
        public addStudent()
        {
            InitializeComponent();
        }

        private void addStudent_Load(object sender, EventArgs e)
        {
            String str = "select dormID from dorm";
            SqlCommand cmd = new SqlCommand(str, cn);
            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtDormID.Items.Add(dr[0].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnaddstudent_Click(object sender, EventArgs e)
        {
            string sql;
            //安排住宿时先判断该宿舍是否已经住满
            sql = "select dormBed-(select count (*) from student where dormID='" + txtDormID.Text.Trim() + "') from dorm where dormID='" + txtDormID.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = cn;
            cn.Open();
            if (Convert.ToInt16(cmd.ExecuteScalar().ToString().Trim()) <= 0)
                MessageBox.Show("该房间己满", "提示");
            else
            {
                sql = "select * from student where sno= '" + txtsno.Text.Trim() + "'";
                cmd.CommandText = sql;
                if (cmd.ExecuteScalar() != null)
                    MessageBox.Show("学号重复", "提示");
                else
                {
                    sql = string.Format("insert into student(sno,sname,ssex,sdept,sclass,dormID) values ('{0}','{1}','{2}','{3}','{4}','{5}')", txtsno.Text, txtsname.Text, txtssex.Text, txtsdept.Text, txtclass.Text, txtDormID.Text);
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("添加成功", "提示");
                    txtclass.Text = "";
                    txtDormID.Text = "";
                    txtsdept.Text = "";
                    txtsname.Text = "";
                    txtsno.Text = "";
                    txtssex.Text = "";
                    cn.Close(); ;
                }
            }
            cn.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
