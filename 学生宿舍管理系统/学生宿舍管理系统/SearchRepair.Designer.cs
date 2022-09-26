namespace 学生宿舍管理系统
{
    partial class SearchRepair
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
            this.txtreportperson = new System.Windows.Forms.TextBox();
            this.txtdormID = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsearchrepair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtreportperson);
            this.groupBox1.Controls.Add(this.txtdormID);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnsearchrepair);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(27, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 241);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "报修信息";
            // 
            // txtreportperson
            // 
            this.txtreportperson.Location = new System.Drawing.Point(512, 65);
            this.txtreportperson.Name = "txtreportperson";
            this.txtreportperson.Size = new System.Drawing.Size(100, 41);
            this.txtreportperson.TabIndex = 5;
            // 
            // txtdormID
            // 
            this.txtdormID.FormattingEnabled = true;
            this.txtdormID.Location = new System.Drawing.Point(148, 69);
            this.txtdormID.Name = "txtdormID";
            this.txtdormID.Size = new System.Drawing.Size(121, 37);
            this.txtdormID.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnsearchrepair
            // 
            this.btnsearchrepair.Location = new System.Drawing.Point(81, 161);
            this.btnsearchrepair.Name = "btnsearchrepair";
            this.btnsearchrepair.Size = new System.Drawing.Size(96, 42);
            this.btnsearchrepair.TabIndex = 2;
            this.btnsearchrepair.Text = "确定";
            this.btnsearchrepair.UseVisualStyleBackColor = true;
            this.btnsearchrepair.Click += new System.EventHandler(this.btnsearchrepair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "报修人";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "宿舍号";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(681, 237);
            this.dataGridView1.TabIndex = 3;
            // 
            // SearchRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SearchRepair";
            this.Text = "SearchRepair";
            this.Load += new System.EventHandler(this.SearchRepair_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtreportperson;
        private System.Windows.Forms.ComboBox txtdormID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsearchrepair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}