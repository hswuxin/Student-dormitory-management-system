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
    public partial class AddCheck2 : Form
    {
        public AddCheck2()
        {
            InitializeComponent();
        }

        //公有类
        SqlConnection cn = new SqlConnection(Form1.constr);
        DataSet ds = new DataSet();
        //SqlDataAdapter adper;

        private void AddCheck_Load(object sender, EventArgs e)
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

        private void btnaddcheck_Click(object sender, EventArgs e)
        {
            if (txtDormID.Text == "")
            {
                MessageBox.Show("请选择宿舍号！");
            }
            else
            {
                try
                {
                    cn.Open();
                    string sql = string.Format("insert into checkinformation(dormID,CheckDate,CheckState,CheckRemark) values ('{0}','{1}','{2}','{3}')", txtDormID.Text, checkTime.Value.Date.ToString("yyyy-MM-dd"), txtcheckstate.Text, txtCheckRemark.Text);
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.ExecuteNonQuery();
                    string sql2 = string.Format("insert into charge(dormID,chargetype,chargemonth,flag,chargemoney) values ('{0}','{1}','{2}','{3}',{4})", txtDormID.Text, txtcheckstate.Text, checkTime.Value.Date.ToString("yyyy-MM-dd"), 0,txtCheckRemark.Text);
                    SqlCommand cmd2 = new SqlCommand(sql2, cn);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("插入成功！");
                    txtDormID.Text = "";
                    txtcheckstate.Text = "";
                    txtCheckRemark.Text = "";
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
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtCheckRemark_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcheckstate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDormID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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
    }
}
