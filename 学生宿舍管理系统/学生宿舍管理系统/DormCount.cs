using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Resources;

namespace 学生宿舍管理系统
{
    public partial class DormCount : Form
    {
        public DormCount()
        {
            InitializeComponent();
        }

        private void DormCount_Load(object sender, EventArgs e)
        {
            //reportViewer1.ServerReport.ReportServerUrl = new Uri("./ReportServer");
            //reportViewer1.ServerReport.ReportPath = "/报表项目1/Report1";
            this.reportViewer1.RefreshReport();

        }
    }
}
