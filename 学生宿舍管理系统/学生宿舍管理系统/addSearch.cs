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

namespace 学生宿舍管理系统
{
    public partial class addSearch : Form
    {
        public addSearch()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(Form1.constr);

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into register(dormID,vistor,bevisted,vistdatetime,leaverdatetime,registerremark)values('{0}','{1}','{2}','{3}','{4}','{5}')", txtdormid.Text, txtvistor.Text, txtbevisted.Text, arrivetime.Value.ToString("yyyy-MM-dd hh:mm:ss"), leavetime.Value.ToString("yyyy-MM-dd hh:mm:ss"), txtregsterremark.Text);
            SqlCommand cmd = new SqlCommand(sql, cn);
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("登记成功");
                txtdormid.Text = "";
                txtbevisted.Text = "";
                txtvistor.Text = "";
                txtregsterremark.Text = "";
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void addSearch_Load(object sender, EventArgs e)
        {
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
            arrivetime.Format = DateTimePickerFormat.Custom;
            arrivetime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            arrivetime.ShowUpDown = true;
            leavetime.Format = DateTimePickerFormat.Custom;
            leavetime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            leavetime.ShowUpDown = true;
        }
    }
}
