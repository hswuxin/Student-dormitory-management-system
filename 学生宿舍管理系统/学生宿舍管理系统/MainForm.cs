using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 学生宿舍管理系统
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 房屋保修ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void 添加用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUser addfrm = new addUser();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                Form tempchildform = this.MdiChildren[i];
                tempchildform.Close();
            }
            addfrm.MdiParent = this;
            addfrm.WindowState = FormWindowState.Maximized;
            addfrm.Show();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifyUser addfrm = new modifyUser();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                Form tempchildform = this.MdiChildren[i];
                tempchildform.Close();
            }
            addfrm.MdiParent = this;
            addfrm.WindowState = FormWindowState.Maximized;
            addfrm.Show();
        }

        private void 重新登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void 系统退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 添加宿舍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDorm addfrm = new AddDorm();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                Form tempchildform = this.MdiChildren[i];
                tempchildform.Close();
            }
            addfrm.MdiParent = this;
            addfrm.WindowState = FormWindowState.Maximized;
            addfrm.Show();
        }

        private void 宿舍查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchDorm addfrm = new searchDorm();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                Form tempchildform = this.MdiChildren[i];
                tempchildform.Close();
            }
            addfrm.MdiParent = this;
            addfrm.WindowState = FormWindowState.Maximized;
            addfrm.Show();
        }

        private void 修改宿舍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyDorm addfrm = new ModifyDorm();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                Form tempchildform = this.MdiChildren[i];
                tempchildform.Close();
            }
            addfrm.MdiParent = this;
            addfrm.WindowState = FormWindowState.Maximized;
            addfrm.Show();
        }

        private void 删除宿舍ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 入住安排ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addStudent addfrm = new addStudent();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                Form tempchildform = this.MdiChildren[i];
                tempchildform.Close();
            }
            addfrm.MdiParent = this;
            addfrm.WindowState = FormWindowState.Maximized;
            addfrm.Show();
        }

        private void 学生查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchStudent addfrm = new searchStudent();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                Form tempchildform = this.MdiChildren[i];
                tempchildform.Close();
            }
            addfrm.MdiParent = this;
            addfrm.WindowState = FormWindowState.Maximized;
            addfrm.Show();
        }

        private void 添加成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCheck addfrm = new AddCheck();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                Form tempchildform = this.MdiChildren[i];
                tempchildform.Close();
            }
            addfrm.MdiParent = this;
            addfrm.WindowState = FormWindowState.Maximized;
            addfrm.Show();
        }

        private void 查询成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCheck addfrm = new SearchCheck();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                Form tempchildform = this.MdiChildren[i];
                tempchildform.Close();
            }
            addfrm.MdiParent = this;
            addfrm.WindowState = FormWindowState.Maximized;
            addfrm.Show();
        }

        private void 水电抄表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCheck2 addfrm = new AddCheck2();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                Form tempchildform = this.MdiChildren[i];
                tempchildform.Close();
            }
            addfrm.MdiParent = this;
            addfrm.WindowState = FormWindowState.Maximized;
            addfrm.Show();
        }

        private void 水电收缴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addcharge addfrm = new Addcharge();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                Form tempchildform = this.MdiChildren[i];
                tempchildform.Close();
            }
            addfrm.MdiParent = this;
            addfrm.WindowState = FormWindowState.Maximized;
            addfrm.Show();
        }

        private void 报修等级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRepair addfrm = new AddRepair();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                Form tempchildform = this.MdiChildren[i];
                tempchildform.Close();
            }
            addfrm.MdiParent = this;
            addfrm.WindowState = FormWindowState.Maximized;
            addfrm.Show();
        }

        private void 报修查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchRepair addfrm = new SearchRepair();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                Form tempchildform = this.MdiChildren[i];
                tempchildform.Close();
            }
            addfrm.MdiParent = this;
            addfrm.WindowState = FormWindowState.Maximized;
            addfrm.Show();
        }

        private void 添加登记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addSearch addfrm = new addSearch();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                Form tempchildform = this.MdiChildren[i];
                tempchildform.Close();
            }
            addfrm.MdiParent = this;
            addfrm.WindowState = FormWindowState.Maximized;
            addfrm.Show();
        }

        private void 登记查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchRegister addfrm = new SearchRegister();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                Form tempchildform = this.MdiChildren[i];
                tempchildform.Close();
            }
            addfrm.MdiParent = this;
            addfrm.WindowState = FormWindowState.Maximized;
            addfrm.Show();
        }

        private void 宿舍入住统计报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DormCount addfrm = new DormCount();
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                Form tempchildform = this.MdiChildren[i];
                tempchildform.Close();
            }
            addfrm.MdiParent = this;
            addfrm.WindowState = FormWindowState.Maximized;
            addfrm.Show();
        }
    }
}
