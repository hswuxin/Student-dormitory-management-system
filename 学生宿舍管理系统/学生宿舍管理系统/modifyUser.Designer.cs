﻿namespace 学生宿舍管理系统
{
    partial class modifyUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnewpassword2 = new System.Windows.Forms.TextBox();
            this.btnmoddify = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名称";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(126, 34);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(100, 21);
            this.txtusername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "密    码";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(126, 82);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 21);
            this.txtpassword.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "新 密 码";
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Location = new System.Drawing.Point(126, 138);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.Size = new System.Drawing.Size(100, 21);
            this.txtnewpassword.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "确认密码";
            // 
            // txtnewpassword2
            // 
            this.txtnewpassword2.Location = new System.Drawing.Point(126, 200);
            this.txtnewpassword2.Name = "txtnewpassword2";
            this.txtnewpassword2.Size = new System.Drawing.Size(100, 21);
            this.txtnewpassword2.TabIndex = 1;
            // 
            // btnmoddify
            // 
            this.btnmoddify.Location = new System.Drawing.Point(45, 249);
            this.btnmoddify.Name = "btnmoddify";
            this.btnmoddify.Size = new System.Drawing.Size(75, 23);
            this.btnmoddify.TabIndex = 2;
            this.btnmoddify.Text = "确定";
            this.btnmoddify.UseVisualStyleBackColor = true;
            this.btnmoddify.Click += new System.EventHandler(this.btnmoddify_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // modifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 321);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnmoddify);
            this.Controls.Add(this.txtnewpassword2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnewpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label1);
            this.Name = "modifyUser";
            this.Text = "modifyUser";
            this.Load += new System.EventHandler(this.modifyUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnewpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnewpassword2;
        private System.Windows.Forms.Button btnmoddify;
        private System.Windows.Forms.Button button2;
    }
}