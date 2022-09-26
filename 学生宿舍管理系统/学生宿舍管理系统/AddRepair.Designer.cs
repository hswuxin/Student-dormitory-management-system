namespace 学生宿舍管理系统
{
    partial class AddRepair
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
            this.txtRepairRemark = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtreportperson = new System.Windows.Forms.TextBox();
            this.txtDormID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnaddrepair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRepairRemark
            // 
            this.txtRepairRemark.Location = new System.Drawing.Point(36, 270);
            this.txtRepairRemark.Multiline = true;
            this.txtRepairRemark.Name = "txtRepairRemark";
            this.txtRepairRemark.Size = new System.Drawing.Size(427, 95);
            this.txtRepairRemark.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRepairRemark);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.txtreportperson);
            this.groupBox1.Controls.Add(this.txtDormID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 437);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "报修信息";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(170, 137);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 41);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // txtreportperson
            // 
            this.txtreportperson.Location = new System.Drawing.Point(605, 55);
            this.txtreportperson.Name = "txtreportperson";
            this.txtreportperson.Size = new System.Drawing.Size(197, 41);
            this.txtreportperson.TabIndex = 5;
            // 
            // txtDormID
            // 
            this.txtDormID.FormattingEnabled = true;
            this.txtDormID.Location = new System.Drawing.Point(170, 64);
            this.txtDormID.Name = "txtDormID";
            this.txtDormID.Size = new System.Drawing.Size(193, 37);
            this.txtDormID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "报修情况";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "报修人";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "报修日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "宿舍号";
            // 
            // btnaddrepair
            // 
            this.btnaddrepair.Location = new System.Drawing.Point(12, 474);
            this.btnaddrepair.Name = "btnaddrepair";
            this.btnaddrepair.Size = new System.Drawing.Size(75, 23);
            this.btnaddrepair.TabIndex = 3;
            this.btnaddrepair.Text = "确定";
            this.btnaddrepair.UseVisualStyleBackColor = true;
            this.btnaddrepair.Click += new System.EventHandler(this.btnaddrepair_Click);
            // 
            // AddRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 521);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnaddrepair);
            this.Name = "AddRepair";
            this.Text = "AddRepair";
            this.Load += new System.EventHandler(this.AddRepair_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRepairRemark;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtreportperson;
        private System.Windows.Forms.ComboBox txtDormID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaddrepair;
    }
}