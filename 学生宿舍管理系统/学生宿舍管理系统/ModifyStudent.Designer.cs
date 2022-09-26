namespace 学生宿舍管理系统
{
    partial class ModifyStudent
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnmodify = new System.Windows.Forms.Button();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.txtsdept = new System.Windows.Forms.TextBox();
            this.txtsname = new System.Windows.Forms.TextBox();
            this.txtsno = new System.Windows.Forms.TextBox();
            this.txtssex = new System.Windows.Forms.ComboBox();
            this.txtDormID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(293, 263);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 27;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnmodify
            // 
            this.btnmodify.Location = new System.Drawing.Point(41, 263);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(75, 23);
            this.btnmodify.TabIndex = 26;
            this.btnmodify.Text = "确定";
            this.btnmodify.UseVisualStyleBackColor = true;
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // txtclass
            // 
            this.txtclass.Location = new System.Drawing.Point(86, 161);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(100, 21);
            this.txtclass.TabIndex = 25;
            // 
            // txtsdept
            // 
            this.txtsdept.Location = new System.Drawing.Point(303, 96);
            this.txtsdept.Name = "txtsdept";
            this.txtsdept.Size = new System.Drawing.Size(100, 21);
            this.txtsdept.TabIndex = 24;
            // 
            // txtsname
            // 
            this.txtsname.Location = new System.Drawing.Point(86, 86);
            this.txtsname.Name = "txtsname";
            this.txtsname.Size = new System.Drawing.Size(100, 21);
            this.txtsname.TabIndex = 23;
            // 
            // txtsno
            // 
            this.txtsno.Location = new System.Drawing.Point(303, 35);
            this.txtsno.Name = "txtsno";
            this.txtsno.Size = new System.Drawing.Size(100, 21);
            this.txtsno.TabIndex = 22;
            // 
            // txtssex
            // 
            this.txtssex.FormattingEnabled = true;
            this.txtssex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.txtssex.Location = new System.Drawing.Point(303, 161);
            this.txtssex.Name = "txtssex";
            this.txtssex.Size = new System.Drawing.Size(121, 20);
            this.txtssex.TabIndex = 21;
            // 
            // txtDormID
            // 
            this.txtDormID.FormattingEnabled = true;
            this.txtDormID.Location = new System.Drawing.Point(86, 32);
            this.txtDormID.Name = "txtDormID";
            this.txtDormID.Size = new System.Drawing.Size(121, 20);
            this.txtDormID.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "性别";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "班级";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "学院";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "学号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "宿舍号";
            // 
            // ModifyStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 356);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnmodify);
            this.Controls.Add(this.txtclass);
            this.Controls.Add(this.txtsdept);
            this.Controls.Add(this.txtsname);
            this.Controls.Add(this.txtsno);
            this.Controls.Add(this.txtssex);
            this.Controls.Add(this.txtDormID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifyStudent";
            this.Text = "ModifyStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnmodify;
        public System.Windows.Forms.TextBox txtclass;
        public System.Windows.Forms.TextBox txtsdept;
        public System.Windows.Forms.TextBox txtsname;
        public System.Windows.Forms.TextBox txtsno;
        public System.Windows.Forms.ComboBox txtssex;
        public System.Windows.Forms.ComboBox txtDormID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}