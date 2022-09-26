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
    public partial class SearchRegister : Form
    {
        public SearchRegister()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(Form1.constr);
        SqlDataAdapter adpter;
        DataSet ds = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select dormID 宿舍号,vistor 来访者,bevisted 被访者,vistdatetime 访问时间,leaverdatetime 离开时间,registerremark 备注 from register where 0=0";
            if (txtdormid.Text != "")
                sql += " and dormID='" + txtdormid.Text + "'";
            adpter = new SqlDataAdapter(sql, cn);
            ds.Clear();
            adpter.Fill(ds, "register");
            dataGridView1.DataSource = ds.Tables["register"];
        }

        private void SearchRegister_Load(object sender, EventArgs e)
        {
            string sql = "select dormID 宿舍号,vistor 来访者,bevisted 被访者,vistdatetime 访问时间,leaverdatetime 离开时间,registerremark 备注 from register where 0=0";
            if (txtdormid.Text != "")
                sql += " and dormID='" + txtdormid.Text + "'";
            adpter = new SqlDataAdapter(sql, cn);
            adpter.Fill(ds, "register");
            dataGridView1.DataSource = ds.Tables["register"];

            string str = "select dormID from dorm";
            SqlCommand cmd = new SqlCommand(str, cn);
            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtdormid.Items.Add(dr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
