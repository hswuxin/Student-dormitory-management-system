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
    public partial class AddRepair : Form
    {
        public AddRepair()
        {
            InitializeComponent();
        }
        //公共类
        SqlConnection cn = new SqlConnection(Form1.constr);

        private void AddRepair_Load(object sender, EventArgs e)
        {
            string str = "select dormID from dorm";
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

        private void btnaddrepair_Click(object sender, EventArgs e)
        {
            if (txtDormID.Text == "" || txtRepairRemark.Text == "")
            {
                MessageBox.Show("宿舍号或报修情况不能为空！");
            }
            else
            {
                string sql = string.Format("insert into repair(dormID,repairperson,addrepairdate,repairremark) values ('{0}','{1}','{2}','{3}')", txtDormID.Text, txtreportperson.Text, dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"), txtRepairRemark.Text);
                SqlCommand cmd = new SqlCommand(sql, cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("添加成功！");
                txtDormID.Text = "";
                txtRepairRemark.Text = "";
                txtreportperson.Text = "";

            }
        }

        private void txtRepairRemark_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtreportperson_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDormID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
