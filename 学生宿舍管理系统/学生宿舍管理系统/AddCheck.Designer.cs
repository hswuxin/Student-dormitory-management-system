namespace 学生宿舍管理系统
{
    partial class AddCheck
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
            this.txtcheckstate = new System.Windows.Forms.ComboBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnaddcheck = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCheckRemark = new System.Windows.Forms.TextBox();
            this.txtDormID = new System.Windows.Forms.ComboBox();
            this.checkTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtcheckstate
            // 
            this.txtcheckstate.FormattingEnabled = true;
            this.txtcheckstate.Items.AddRange(new object[] {
            "优秀",
            "良好",
            "及格",
            "不及格"});
            this.txtcheckstate.Location = new System.Drawing.Point(261, 25);
            this.txtcheckstate.Name = "txtcheckstate";
            this.txtcheckstate.Size = new System.Drawing.Size(121, 20);
            this.txtcheckstate.TabIndex = 20;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(224, 201);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 19;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnaddcheck
            // 
            this.btnaddcheck.Location = new System.Drawing.Point(34, 201);
            this.btnaddcheck.Name = "btnaddcheck";
            this.btnaddcheck.Size = new System.Drawing.Size(75, 23);
            this.btnaddcheck.TabIndex = 18;
            this.btnaddcheck.Text = "确定";
            this.btnaddcheck.UseVisualStyleBackColor = true;
            this.btnaddcheck.Click += new System.EventHandler(this.btnaddcheck_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "备注";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "检查日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "检查状况";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "宿舍号";
            // 
            // txtCheckRemark
            // 
            this.txtCheckRemark.Location = new System.Drawing.Point(55, 140);
            this.txtCheckRemark.Name = "txtCheckRemark";
            this.txtCheckRemark.Size = new System.Drawing.Size(100, 21);
            this.txtCheckRemark.TabIndex = 13;
            // 
            // txtDormID
            // 
            this.txtDormID.FormattingEnabled = true;
            this.txtDormID.Location = new System.Drawing.Point(75, 25);
            this.txtDormID.Name = "txtDormID";
            this.txtDormID.Size = new System.Drawing.Size(121, 20);
            this.txtDormID.TabIndex = 12;
            // 
            // checkTime
            // 
            this.checkTime.Location = new System.Drawing.Point(80, 79);
            this.checkTime.Name = "checkTime";
            this.checkTime.Size = new System.Drawing.Size(200, 21);
            this.checkTime.TabIndex = 11;
            // 
            // AddCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 291);
            this.Controls.Add(this.txtcheckstate);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnaddcheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCheckRemark);
            this.Controls.Add(this.txtDormID);
            this.Controls.Add(this.checkTime);
            this.Name = "AddCheck";
            this.Text = "AddCheck";
            this.Load += new System.EventHandler(this.AddCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtcheckstate;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnaddcheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCheckRemark;
        private System.Windows.Forms.ComboBox txtDormID;
        private System.Windows.Forms.DateTimePicker checkTime;
    }
}