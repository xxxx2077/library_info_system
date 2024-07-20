namespace 图书管理系统
{
    partial class selectPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selectPage));
            this.reader_btn = new System.Windows.Forms.Button();
            this.manager_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reader_btn
            // 
            this.reader_btn.Location = new System.Drawing.Point(0, 187);
            this.reader_btn.Name = "reader_btn";
            this.reader_btn.Size = new System.Drawing.Size(276, 91);
            this.reader_btn.TabIndex = 0;
            this.reader_btn.Text = "我是读者";
            this.reader_btn.UseVisualStyleBackColor = true;
            this.reader_btn.Click += new System.EventHandler(this.reader_btn_Click);
            // 
            // manager_btn
            // 
            this.manager_btn.Location = new System.Drawing.Point(358, 187);
            this.manager_btn.Name = "manager_btn";
            this.manager_btn.Size = new System.Drawing.Size(270, 91);
            this.manager_btn.TabIndex = 1;
            this.manager_btn.Text = "我是管理员";
            this.manager_btn.UseVisualStyleBackColor = true;
            this.manager_btn.Click += new System.EventHandler(this.manager_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.reader_btn);
            this.groupBox1.Controls.Add(this.manager_btn);
            this.groupBox1.Location = new System.Drawing.Point(75, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 285);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("宋体", 20F);
            this.textBox1.Location = new System.Drawing.Point(175, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(291, 53);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "请选择你的身份";
            // 
            // selectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "selectPage";
            this.Text = "读者身份选择";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reader_btn;
        private System.Windows.Forms.Button manager_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}