namespace 学生宿舍管理系统
{
    partial class Addcharge
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkTime = new System.Windows.Forms.DateTimePicker();
            this.txtchargetype = new System.Windows.Forms.ComboBox();
            this.txtdormID = new System.Windows.Forms.ComboBox();
            this.btnsearchcharge = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtchargeperson = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnaddcharge = new System.Windows.Forms.Button();
            this.txtchargemoney = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkTime);
            this.groupBox1.Controls.Add(this.txtchargetype);
            this.groupBox1.Controls.Add(this.txtdormID);
            this.groupBox1.Controls.Add(this.btnsearchcharge);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(30, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 269);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "水电缴费信息";
            // 
            // checkTime
            // 
            this.checkTime.Location = new System.Drawing.Point(200, 171);
            this.checkTime.Name = "checkTime";
            this.checkTime.Size = new System.Drawing.Size(185, 41);
            this.checkTime.TabIndex = 29;
            // 
            // txtchargetype
            // 
            this.txtchargetype.FormattingEnabled = true;
            this.txtchargetype.Items.AddRange(new object[] {
            "类型1",
            "类型2"});
            this.txtchargetype.Location = new System.Drawing.Point(522, 73);
            this.txtchargetype.Name = "txtchargetype";
            this.txtchargetype.Size = new System.Drawing.Size(121, 37);
            this.txtchargetype.TabIndex = 27;
            // 
            // txtdormID
            // 
            this.txtdormID.FormattingEnabled = true;
            this.txtdormID.Location = new System.Drawing.Point(185, 73);
            this.txtdormID.Name = "txtdormID";
            this.txtdormID.Size = new System.Drawing.Size(121, 37);
            this.txtdormID.TabIndex = 26;
            // 
            // btnsearchcharge
            // 
            this.btnsearchcharge.Location = new System.Drawing.Point(568, 175);
            this.btnsearchcharge.Name = "btnsearchcharge";
            this.btnsearchcharge.Size = new System.Drawing.Size(143, 37);
            this.btnsearchcharge.TabIndex = 23;
            this.btnsearchcharge.Text = "查询";
            this.btnsearchcharge.UseVisualStyleBackColor = true;
            this.btnsearchcharge.Click += new System.EventHandler(this.btnsearchcharge_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "缴费月份";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "缴费类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "宿舍号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 29);
            this.label7.TabIndex = 47;
            this.label7.Text = "缴费人";
            // 
            // txtchargeperson
            // 
            this.txtchargeperson.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtchargeperson.Location = new System.Drawing.Point(522, 61);
            this.txtchargeperson.Name = "txtchargeperson";
            this.txtchargeperson.Size = new System.Drawing.Size(152, 41);
            this.txtchargeperson.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 29);
            this.label8.TabIndex = 45;
            this.label8.Text = "缴费额";
            // 
            // btnaddcharge
            // 
            this.btnaddcharge.Location = new System.Drawing.Point(316, 164);
            this.btnaddcharge.Name = "btnaddcharge";
            this.btnaddcharge.Size = new System.Drawing.Size(121, 38);
            this.btnaddcharge.TabIndex = 48;
            this.btnaddcharge.Text = "确定";
            this.btnaddcharge.UseVisualStyleBackColor = true;
            this.btnaddcharge.Click += new System.EventHandler(this.btnaddcharge_Click);
            // 
            // txtchargemoney
            // 
            this.txtchargemoney.Location = new System.Drawing.Point(185, 161);
            this.txtchargemoney.Name = "txtchargemoney";
            this.txtchargemoney.Size = new System.Drawing.Size(121, 41);
            this.txtchargemoney.TabIndex = 49;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txtchargemoney);
            this.groupBox2.Controls.Add(this.btnaddcharge);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtchargeperson);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(30, 360);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 250);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "缴费详情";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 41);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 29);
            this.label6.TabIndex = 44;
            this.label6.Text = "缴费日期";
            // 
            // Addcharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Addcharge";
            this.Text = "Addcharge";
            this.Load += new System.EventHandler(this.Addcharge_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtchargetype;
        private System.Windows.Forms.ComboBox txtdormID;
        private System.Windows.Forms.Button btnsearchcharge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtchargeperson;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnaddcharge;
        private System.Windows.Forms.TextBox txtchargemoney;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker checkTime;
    }
}