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
    public partial class searchDorm : Form
    {
        public searchDorm()
        {
            InitializeComponent();
        }
        private DataSet ds;
        SqlConnection cn = new SqlConnection(Form1.constr);
        SqlDataAdapter adpter;
        void displaydb()
        {
            ds = new DataSet();
            try
            {
                cn.Open();
                string sqlstring = string.Format("select dormID 宿舍号,dormMoney 住宿费,dormbed 床位数,dormchair 椅子数,dormndesk 桌子数,dormdirection 朝向,dormremark 备注 from dorm");
                adpter = new SqlDataAdapter(sqlstring, cn);
                ds.Clear();
                adpter.Fill(ds, "dorm");
                dataGridView1.DataSource = ds.Tables["dorm"];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        private void searchDorm_Load(object sender, EventArgs e)
        {
            displaydb();
        }

        private void btndormSearch_Click(object sender, EventArgs e)
        {
            if (txtdormID.Text !="")
            {
                ds = new DataSet();
                try
                {
                    cn.Open();
                    string sqlstring = string.Format("select dormID 宿舍号,dormMoney 住宿费,dormbed 床位数,dormchair 椅子数,dormndesk 桌子数,dormdirection 朝向,dormremark 备注 from dorm where dormID='{0}'", txtdormID.Text);
                    adpter = new SqlDataAdapter(sqlstring, cn);
                    ds.Clear();
                    adpter.Fill(ds, "dorm");
                    dataGridView1.DataSource = ds.Tables["dorm"];
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
            else
            {
                displaydb();
            }
        }
        ModifyDorm modifydorm;
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null && dataGridView1.CurrentCell.RowIndex >= 0 && dataGridView1.CurrentCell != null)
            {
                modifydorm = new ModifyDorm();
                modifydorm.txtdormID.Text = ds.Tables["dorm"].Rows[dataGridView1.CurrentCell.RowIndex]["宿舍号"].ToString().Trim();
                modifydorm.txtdormbed.Text = ds.Tables["dorm"].Rows[dataGridView1.CurrentCell.RowIndex]["床位数"].ToString().Trim();
                modifydorm.txtdormschair.Text = ds.Tables["dorm"].Rows[dataGridView1.CurrentCell.RowIndex]["椅子数"].ToString().Trim();
                modifydorm.txtdormdesk.Text = ds.Tables["dorm"].Rows[dataGridView1.CurrentCell.RowIndex]["桌子数"].ToString().Trim();
                modifydorm.txtdormdirection.Text = ds.Tables["dorm"].Rows[dataGridView1.CurrentCell.RowIndex]["朝向"].ToString().Trim();
                modifydorm.txtdormMoney.Text = ds.Tables["dorm"].Rows[dataGridView1.CurrentCell.RowIndex]["住宿费"].ToString().Trim();
                modifydorm.txtdormremark.Text = ds.Tables["dorm"].Rows[dataGridView1.CurrentCell.RowIndex]["备注"].ToString().Trim();
                modifydorm.ShowDialog();
            }
            displaydb();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmdbuilder = new SqlCommandBuilder(adpter);
            if (MessageBox.Show("真的删除吗", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataRow delrow = ds.Tables["dorm"].Rows[dataGridView1.CurrentCell.RowIndex];
                delrow.Delete();
                adpter.Update(ds, "dorm");
                MessageBox.Show("删除成功");
            }
            string sqlstring;
            if (txtdormID.Text == "")
                sqlstring = "select dormID 宿舍号,dormMoney 住宿费,dormbed 床位数,dormchair 椅子数,dormndesk 桌子数,dormdirection 朝向,dormremark 备注 from dorm";
            else
                sqlstring = string.Format("select dormID 宿舍号,dormMoney 住宿费,dormbed 床位数,dormchair 椅子数,dormndesk 桌子数,dormdirection 朝向,dormremark 备注 from dorm where dormID='{0}'", txtdormID.Text);
            adpter = new SqlDataAdapter(sqlstring, cn);
            ds.Clear();
            adpter.Fill(ds, "dorm");
            dataGridView1.DataSource = ds.Tables["dorm"];
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
