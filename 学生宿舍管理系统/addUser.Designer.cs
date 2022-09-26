namespace 学生宿舍管理系统
{
    partial class addUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassword2 = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(171, 125);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(104, 21);
            this.txtpassword.TabIndex = 4;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(171, 43);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(104, 21);
            this.txtusername.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密  码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "用户名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码：";
            // 
            // txtpassword2
            // 
            this.txtpassword2.Location = new System.Drawing.Point(171, 196);
            this.txtpassword2.Name = "txtpassword2";
            this.txtpassword2.Size = new System.Drawing.Size(104, 21);
            this.txtpassword2.TabIndex = 4;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(66, 269);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "确定";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(224, 269);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "退出";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 326);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtpassword2);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addUser";
            this.Text = "添加用户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpassword2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnexit;
    }
}