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
    public partial class SearchCheck : Form
    {
        public SearchCheck()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(Form1.constr);
        DataSet ds = new DataSet();
        SqlDataAdapter adpter;
        void displaydb()
        {
            string sql = "select dormID 宿舍号,CheckDate 检查时间,CheckState 检查成绩,CheckRemark 检查备注 from checkinformation";
            SqlCommand cmd = new SqlCommand(sql, cn);
            adpter = new SqlDataAdapter(cmd);
            ds.Clear();
            adpter.Fill(ds, "checkinformation");
            dataGridView1.DataSource = ds.Tables["checkinformation"];
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string sql = "select dormID 宿舍号,CheckDate 检查时间,CheckState 检查成绩,CheckRemark 检查备注 from checkinformation where 0=0";
            if (txtDormID.Text == "")
                sql += "and dormID='" + txtDormID.Text + "'";
            if (checkTime.Value != null)
                sql += "and checkdate='" + checkTime.Value.Date + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            adpter = new SqlDataAdapter(cmd);
            ds.Clear();
            adpter.Fill(ds, "checkinformation");
            dataGridView1.DataSource = ds.Tables["checkinformation"];
            txtDormID.Text = "";
        }

        private void SearchCheck_Load(object sender, EventArgs e)
        {
            displaydb();
            string str = "select dormID from dorm";
            SqlCommand cmd = new SqlCommand(str, cn);
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtDormID.Items.Add(reader[0].ToString());
            }
            cn.Close();
        }
        Modifycheck modifycheck = new Modifycheck();
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null && dataGridView1.CurrentCell.RowIndex >= 0 && dataGridView1.CurrentCell != null)
            {
                modifycheck = new Modifycheck();
                modifycheck.txtDormID.Text = ds.Tables["checkinformation"].Rows[dataGridView1.CurrentCell.RowIndex]["宿舍号"].ToString().Trim();
                modifycheck.checkTime.Text = ds.Tables["checkinformation"].Rows[dataGridView1.CurrentCell.RowIndex]["检查时间"].ToString().Trim();
                modifycheck.txtCheckRemark.Text = ds.Tables["checkinformation"].Rows[dataGridView1.CurrentCell.RowIndex]["检查备注"].ToString().Trim();
                modifycheck.txtcheckstate.Text = ds.Tables["checkinformation"].Rows[dataGridView1.CurrentCell.RowIndex]["检查成绩"].ToString().Trim();
                modifycheck.ShowDialog();
            }
            displaydb();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
