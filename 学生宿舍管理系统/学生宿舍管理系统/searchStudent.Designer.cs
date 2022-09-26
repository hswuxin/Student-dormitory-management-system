namespace 学生宿舍管理系统
{
    partial class searchStudent
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
            this.btnserch = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDormID = new System.Windows.Forms.ComboBox();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.txtsno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnserch
            // 
            this.btnserch.Location = new System.Drawing.Point(505, 34);
            this.btnserch.Name = "btnserch";
            this.btnserch.Size = new System.Drawing.Size(75, 23);
            this.btnserch.TabIndex = 21;
            this.btnserch.Text = "查询";
            this.btnserch.UseVisualStyleBackColor = true;
            this.btnserch.Click += new System.EventHandler(this.btnserch_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(405, 270);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 20;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(249, 270);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 19;
            this.btndel.Text = "退宿";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(54, 270);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 18;
            this.btnupdate.Text = "修改";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(475, 143);
            this.dataGridView1.TabIndex = 17;
            // 
            // txtDormID
            // 
            this.txtDormID.FormattingEnabled = true;
            this.txtDormID.Location = new System.Drawing.Point(359, 37);
            this.txtDormID.Name = "txtDormID";
            this.txtDormID.Size = new System.Drawing.Size(121, 20);
            this.txtDormID.TabIndex = 16;
            // 
            // txtsname
            // 
            this.txtsname.Location = new System.Drawing.Point(206, 37);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(100, 21);
            this.txtsname.TabIndex = 15;
            // 
            // txtsno
            // 
            this.txtsno.Location = new System.Drawing.Point(64, 37);
            this.txtsno.Name = "txtsno";
            this.txtsno.Size = new System.Drawing.Size(100, 21);
            this.txtsno.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "宿舍号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "姓名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "学号";
            // 
            // searchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 340);
            this.Controls.Add(this.btnserch);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDormID);
            this.Controls.Add(this.txtsname);
            this.Controls.Add(this.txtsno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "searchStudent";
            this.Text = "searchStudent";
            this.Load += new System.EventHandler(this.searchStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnserch;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox txtDormID;
        private System.Windows.Forms.TextBox txtsname;
        private System.Windows.Forms.TextBox txtsno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}