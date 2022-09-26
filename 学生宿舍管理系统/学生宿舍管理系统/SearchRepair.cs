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
    public partial class SearchRepair : Form
    {
        public SearchRepair()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(Form1.constr);
        DataSet ds = new DataSet();
        SqlDataAdapter adper;

        private void SearchRepair_Load(object sender, EventArgs e)
        {
            string sql = "select dormID 宿舍号, repairperson 报修人, addrepairdate 报修日期, repairremark 报修详情 from repair";
            adper = new SqlDataAdapter(sql, cn);
            adper.Fill(ds, "repair");
            dataGridView1.DataSource = ds.Tables["repair"];

            string str = "select dormID from dorm";
            SqlCommand cmd = new SqlCommand(str, cn);

            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtdormID.Items.Add(dr[0].ToString());
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

        private void btnsearchrepair_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select dormID 宿舍号, repairperson 报修人, addrepairdate 报修日期, repairremark 报修详情 from repair where 0=0");
            if (txtdormID.Text != "")
                sql += "and dormID='" + txtdormID.Text + "'";
            if (txtreportperson.Text != "")
                sql += "and repairperson='" + txtreportperson.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            adper = new SqlDataAdapter(cmd);
            ds.Clear();
            adper.Fill(ds, "report");
            dataGridView1.DataSource = ds.Tables["report"];

        }

        private void txtreportperson_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdormID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
