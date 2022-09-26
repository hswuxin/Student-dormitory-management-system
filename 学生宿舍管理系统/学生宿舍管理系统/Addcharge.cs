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
    public partial class Addcharge : Form
    {
        public Addcharge()
        {
            InitializeComponent();
        }

        //公有类
        SqlConnection cn = new SqlConnection(Form1.constr);


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Addcharge_Load(object sender, EventArgs e)
        {
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

        private void btnsearchcharge_Click(object sender, EventArgs e)
        {
            if (txtdormID.Text == "" || checkTime.Text == "" || txtchargetype.Text == "")
            {
                MessageBox.Show("请选择完整信息", "提示");
            }
            else
            {
                cn.Open();
                string str = string.Format("select chargemoney,chargeparson,chargedate,flag from charge where dormID='{0}' and chargetype='{1}' and  chargemonth='{2}' ", txtdormID.Text, txtchargetype.Text, checkTime.Text);
                SqlCommand cmd = new SqlCommand(str, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                try
                {
                    if (dr.Read())
                    {
                        if (dr[3].ToString()=="1")
                        {
                            MessageBox.Show("该宿舍已经缴费成功！");
                            txtchargemoney.Text = dr[0].ToString();
                            txtchargeperson.Text = dr[1].ToString();
                            dateTimePicker1.Text = Convert.ToDateTime(dr[2]).ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            MessageBox.Show("该宿舍尚未缴费，请缴费！");
                            txtchargemoney.Text = dr[0].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("尚未抄表，无法缴费！");
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
        }

        private void btnaddcharge_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            if (txtchargeperson.Text == "" || txtchargemoney.Text == "")
            {
                MessageBox.Show("请选择完整信息！");
            }
            else
            {
                cn.Open();
                string sql = string.Format("update charge set chargemoney={0},chargeparson='{1}',chargedate='{2}',flag='1' where dormID='{3}' and chargetype='{4}' and chargemonth='{5}'",
                    txtchargemoney.Text, txtchargeperson.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), txtdormID.Text, txtchargetype.Text,checkTime.Text );
                cmd.CommandText = sql;
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                MessageBox.Show("缴费成功！");
                txtchargemoney.Text = "";
                checkTime.Text = "";
                txtchargeperson.Text = "";
                txtchargetype.Text = "";
                txtdormID.Text = "";
                cn.Close();
            }
        }

        private void txtchargemonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
