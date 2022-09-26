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
    public partial class Modifycheck : Form
    {
        SqlConnection cn = new SqlConnection(Form1.constr);
        public Modifycheck()
        {
            InitializeComponent();
        }

        private void Modifycheck_Load(object sender, EventArgs e)
        {

        }

        private void btnmodifycheck_Click(object sender, EventArgs e)
        {
            if (txtDormID.Text.Trim() == "")
                MessageBox.Show("请填写宿舍号");
            else
            {
                string str = string.Format("update checkinformation set CheckDate='{0}',CheckState='{1}',CheckRemark='{2}' where dormID='{3}'", checkTime.Value.ToString("yyyy-MM-dd"), txtcheckstate.Text, txtCheckRemark.Text, txtDormID.Text);
                SqlCommand cmd = new SqlCommand(str, cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("修改成功", "提示");
                cn.Close();
                this.Close();
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcheckstate_SelectedIndexChanged(object sender, EventArgs e)
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

        private void txtCheckRemark_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDormID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtcheckstate_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

    }
}
