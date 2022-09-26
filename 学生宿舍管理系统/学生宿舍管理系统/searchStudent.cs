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
    public partial class searchStudent : Form
    {
        SqlConnection cn = new SqlConnection(Form1.constr);
        DataSet ds = new DataSet();
        SqlDataAdapter adpter;

        void displaydb()
        {
            string str = "select sno 学号,sname 姓名,ssex 性别,sdept 学院,sclass 班级,dormID 宿舍号 from student";
            SqlCommand cmd = new SqlCommand(str, cn);
            try
            {
                adpter = new SqlDataAdapter(cmd); ;
                ds.Clear();
                adpter.Fill(ds, "student");
                dataGridView1.DataSource = ds.Tables["student"];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public searchStudent()
        {
            InitializeComponent();
        }

        private void searchStudent_Load(object sender, EventArgs e)
        {
            displaydb();
            string str = "select dormID from dorm";
            SqlCommand cmd = new SqlCommand(str, cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader(); ;
            while (dr.Read())
            {
                txtDormID.Items.Add(dr[0].ToString());
            }
            cn.Close();
        }

        private void btnserch_Click(object sender, EventArgs e)
        {
            string str = "select sno 学号,sname 姓名,ssex 性别,sdept 学院,sclass 班级,dormID 宿舍号 from student where 0=0";
            if (txtsno.Text != "")
                str += "and sno='" + txtsno.Text + "'";
            if (txtsname.Text != "")
                str += "and sname='" + txtsname.Text + "'";
            if (txtDormID.Text != "")
                str += "and dormID='" + txtDormID.Text + "'";
            SqlCommand cmd = new SqlCommand(str, cn);
            try
            {
                adpter = new SqlDataAdapter(cmd);
                ds.Clear();
                adpter.Fill(ds, "student");
                dataGridView1.DataSource = ds.Tables["student"];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                txtDormID.Text = "";
                txtsname.Text = "";
                txtsno.Text = "";
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            ModifyStudent modifystudent = new ModifyStudent();
            if (dataGridView1.DataSource != null && dataGridView1.CurrentCell.RowIndex >= 0 && dataGridView1.CurrentCell != null)
            {
                modifystudent.txtsno.Text = ds.Tables["student"].Rows[dataGridView1.CurrentCell.RowIndex]["学号"].ToString().Trim();
                modifystudent.txtsname.Text = ds.Tables["student"].Rows[dataGridView1.CurrentCell.RowIndex]["姓名"].ToString().Trim();
                modifystudent.txtssex.Text = ds.Tables["student"].Rows[dataGridView1.CurrentCell.RowIndex]["性别"].ToString().Trim();
                modifystudent.txtsdept.Text = ds.Tables["student"].Rows[dataGridView1.CurrentCell.RowIndex]["学院"].ToString().Trim();
                modifystudent.txtclass.Text = ds.Tables["student"].Rows[dataGridView1.CurrentCell.RowIndex]["班级"].ToString().Trim();
                modifystudent.txtDormID.Text = ds.Tables["student"].Rows[dataGridView1.CurrentCell.RowIndex]["宿舍号"].ToString().Trim();
                modifystudent.ShowDialog();
            }
            displaydb();

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(adpter);
            if (MessageBox.Show("真的刪除吗？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataRow delrow = ds.Tables["student"].Rows[dataGridView1.CurrentCell.RowIndex];
                delrow.Delete();
                adpter.Update(ds, "student");
                MessageBox.Show("删除成功");
            }
            string str = "select sno 学号,sname 姓名,ssex 性别,sdept 学院,sclass 班级,dormID 宿舍号 from student where 0=0";
            if (txtsno.Text != "")
                str += "and sno='" + txtsno.Text + "'";
            if (txtsname.Text != "")
                str += "and sname='" + txtsname.Text + "'";
            if (txtDormID.Text != "")
                str += "and dormID='" + txtDormID.Text + "'";
            SqlCommand cmd = new SqlCommand(str, cn);
            try
            {
                adpter = new SqlDataAdapter(cmd);
                ds.Clear();
                adpter.Fill(ds, "student");
                dataGridView1.DataSource = ds.Tables["student"];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
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

        private void txtsno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDormID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
