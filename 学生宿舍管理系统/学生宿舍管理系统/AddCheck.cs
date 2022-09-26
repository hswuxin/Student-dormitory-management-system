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
    public partial class AddCheck : Form
    {

        public AddCheck()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(Form1.constr);
        DataSet ds = new DataSet();
        // SqlDataAdapter adpter;
        private void btnaddcheck_Click(object sender, EventArgs e)
        {
            if (txtDormID.Text == "")
                MessageBox.Show("请选择宿舍号");
            else
            {
                try
                {
                    cn.Open();
                    string sql = string.Format("insert into checkinformation (dormID,CheckDate,CheckState,CheckRemark) values ('{0}','{1}','{2}','{3}')", txtDormID.Text, checkTime.Value.Date.ToString("yyyy-MM-dd"), txtcheckstate.Text, txtCheckRemark.Text);
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("插人成功");
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

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
