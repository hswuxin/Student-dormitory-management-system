namespace 学生宿舍管理系统
{
    partial class AddCheck2
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
            this.checkTime = new System.Windows.Forms.DateTimePicker();
            this.btncancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnaddcheck = new System.Windows.Forms.Button();
            this.txtCheckRemark = new System.Windows.Forms.TextBox();
            this.txtcheckstate = new System.Windows.Forms.ComboBox();
            this.txtDormID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkTime
            // 
            this.checkTime.Location = new System.Drawing.Point(155, 116);
            this.checkTime.Name = "checkTime";
            this.checkTime.Size = new System.Drawing.Size(185, 41);
            this.checkTime.TabIndex = 21;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(391, 212);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(123, 41);
            this.btncancel.TabIndex = 20;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkTime);
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btnaddcheck);
            this.groupBox1.Controls.Add(this.txtCheckRemark);
            this.groupBox1.Controls.Add(this.txtcheckstate);
            this.groupBox1.Controls.Add(this.txtDormID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(11, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 353);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "水电信息";
            // 
            // btnaddcheck
            // 
            this.btnaddcheck.Location = new System.Drawing.Point(155, 212);
            this.btnaddcheck.Name = "btnaddcheck";
            this.btnaddcheck.Size = new System.Drawing.Size(106, 41);
            this.btnaddcheck.TabIndex = 19;
            this.btnaddcheck.Text = "确定";
            this.btnaddcheck.UseVisualStyleBackColor = true;
            this.btnaddcheck.Click += new System.EventHandler(this.btnaddcheck_Click);
            // 
            // txtCheckRemark
            // 
            this.txtCheckRemark.Location = new System.Drawing.Point(495, 121);
            this.txtCheckRemark.Name = "txtCheckRemark";
            this.txtCheckRemark.Size = new System.Drawing.Size(121, 41);
            this.txtCheckRemark.TabIndex = 18;
            // 
            // txtcheckstate
            // 
            this.txtcheckstate.FormattingEnabled = true;
            this.txtcheckstate.Items.AddRange(new object[] {
            "类型1",
            "类型2"});
            this.txtcheckstate.Location = new System.Drawing.Point(495, 40);
            this.txtcheckstate.Name = "txtcheckstate";
            this.txtcheckstate.Size = new System.Drawing.Size(121, 37);
            this.txtcheckstate.TabIndex = 16;
            // 
            // txtDormID
            // 
            this.txtDormID.FormattingEnabled = true;
            this.txtDormID.Location = new System.Drawing.Point(168, 37);
            this.txtDormID.Name = "txtDormID";
            this.txtDormID.Size = new System.Drawing.Size(121, 37);
            this.txtDormID.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "应缴费额";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "抄表类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "抄表月份";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "宿 舍 号";
            // 
            // AddCheck2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 464);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddCheck2";
            this.Text = "水电抄表";
            this.Load += new System.EventHandler(this.AddCheck_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker checkTime;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnaddcheck;
        private System.Windows.Forms.TextBox txtCheckRemark;
        private System.Windows.Forms.ComboBox txtcheckstate;
        private System.Windows.Forms.ComboBox txtDormID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}