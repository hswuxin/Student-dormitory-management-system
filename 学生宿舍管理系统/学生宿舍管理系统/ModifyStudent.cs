using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace 学生宿舍管理系统
{
    public partial class ModifyStudent : Form
    {
        public ModifyStudent()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(Form1.constr);
        private void ModifyStudent_Load(object sender, EventArgs e)
        {
            //combobox 中只显示有剩余床位的宿舍号,通过视图实现
            string sql = "select * from numberofbed";
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = sql;
            cmd1.Connection = cn;
            cn.Open();
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                if (Convert.ToInt16(dr[1]) != 0)
                    txtDormID.Items.Add(dr[0].ToString());
            }
            cn.Close();
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            if (txtsname.Text == "" || txtDormID.Text == "" || txtsno.Text == "")
                MessageBox.Show("请输人完整信息");
            else
            {
                cn.Open();
                string sql = "select * from dorm where dormID= '" + txtDormID.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql, cn);
                if (cmd.ExecuteScalar() == null)
                    MessageBox.Show("没有该宿舍号", "提示");
                else
                {
                    sql = string.Format("update student set dormID='{0}',ssex='{1}',sname='{2}',sdept='{3}',sclass = '{4}' where sno='{5}'", txtDormID.Text, txtssex.Text, txtsname.Text, txtsdept.Text, txtclass.Text, txtsno.Text);
                    cmd.CommandText = sql;
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("修改成功", "提示");
                    this.Close();
                }
                cn.Close();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDormID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtssex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtsno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsdept_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtclass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
