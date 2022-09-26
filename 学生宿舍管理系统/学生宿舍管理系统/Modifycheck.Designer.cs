namespace 学生宿舍管理系统
{
    partial class Modifycheck
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
            this.btnmodifycheck = new System.Windows.Forms.Button();
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
            this.txtcheckstate.Location = new System.Drawing.Point(281, 46);
            this.txtcheckstate.Name = "txtcheckstate";
            this.txtcheckstate.Size = new System.Drawing.Size(121, 20);
            this.txtcheckstate.TabIndex = 30;
            this.txtcheckstate.SelectedIndexChanged += new System.EventHandler(this.txtcheckstate_SelectedIndexChanged_1);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(244, 222);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 29;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnmodifycheck
            // 
            this.btnmodifycheck.Location = new System.Drawing.Point(54, 222);
            this.btnmodifycheck.Name = "btnmodifycheck";
            this.btnmodifycheck.Size = new System.Drawing.Size(75, 23);
            this.btnmodifycheck.TabIndex = 28;
            this.btnmodifycheck.Text = "确定";
            this.btnmodifycheck.UseVisualStyleBackColor = true;
            this.btnmodifycheck.Click += new System.EventHandler(this.btnmodifycheck_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "备注";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "检查日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "检查状况";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "宿舍号";
            // 
            // txtCheckRemark
            // 
            this.txtCheckRemark.Location = new System.Drawing.Point(75, 161);
            this.txtCheckRemark.Name = "txtCheckRemark";
            this.txtCheckRemark.Size = new System.Drawing.Size(100, 21);
            this.txtCheckRemark.TabIndex = 23;
            // 
            // txtDormID
            // 
            this.txtDormID.FormattingEnabled = true;
            this.txtDormID.Location = new System.Drawing.Point(75, 43);
            this.txtDormID.Name = "txtDormID";
            this.txtDormID.Size = new System.Drawing.Size(121, 20);
            this.txtDormID.TabIndex = 22;
            // 
            // checkTime
            // 
            this.checkTime.Location = new System.Drawing.Point(100, 100);
            this.checkTime.Name = "checkTime";
            this.checkTime.Size = new System.Drawing.Size(200, 21);
            this.checkTime.TabIndex = 21;
            // 
            // Modifycheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 322);
            this.Controls.Add(this.txtcheckstate);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnmodifycheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCheckRemark);
            this.Controls.Add(this.txtDormID);
            this.Controls.Add(this.checkTime);
            this.Name = "Modifycheck";
            this.Text = "Modifycheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox txtcheckstate;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnmodifycheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCheckRemark;
        public System.Windows.Forms.ComboBox txtDormID;
        public System.Windows.Forms.DateTimePicker checkTime;
    }
}