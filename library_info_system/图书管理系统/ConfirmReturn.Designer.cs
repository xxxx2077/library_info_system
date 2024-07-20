namespace 图书管理系统
{
    partial class ConfirmReturn
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
            this.OverdueBtn = new System.Windows.Forms.Button();
            this.DamagedBtn = new System.Windows.Forms.Button();
            this.LostBtn = new System.Windows.Forms.Button();
            this.normalBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OverdueBtn
            // 
            this.OverdueBtn.Location = new System.Drawing.Point(192, 33);
            this.OverdueBtn.Name = "OverdueBtn";
            this.OverdueBtn.Size = new System.Drawing.Size(139, 55);
            this.OverdueBtn.TabIndex = 0;
            this.OverdueBtn.Text = "超期处理";
            this.OverdueBtn.UseVisualStyleBackColor = true;
            this.OverdueBtn.Click += new System.EventHandler(this.OverdueBtn_Click);
            // 
            // DamagedBtn
            // 
            this.DamagedBtn.Location = new System.Drawing.Point(192, 137);
            this.DamagedBtn.Name = "DamagedBtn";
            this.DamagedBtn.Size = new System.Drawing.Size(139, 55);
            this.DamagedBtn.TabIndex = 1;
            this.DamagedBtn.Text = "损坏处理";
            this.DamagedBtn.UseVisualStyleBackColor = true;
            this.DamagedBtn.Click += new System.EventHandler(this.DamagedBtn_Click);
            // 
            // LostBtn
            // 
            this.LostBtn.Location = new System.Drawing.Point(12, 137);
            this.LostBtn.Name = "LostBtn";
            this.LostBtn.Size = new System.Drawing.Size(139, 55);
            this.LostBtn.TabIndex = 2;
            this.LostBtn.Text = "丢失处理";
            this.LostBtn.UseVisualStyleBackColor = true;
            this.LostBtn.Click += new System.EventHandler(this.LostBtn_Click);
            // 
            // normalBtn
            // 
            this.normalBtn.Location = new System.Drawing.Point(12, 33);
            this.normalBtn.Name = "normalBtn";
            this.normalBtn.Size = new System.Drawing.Size(139, 55);
            this.normalBtn.TabIndex = 3;
            this.normalBtn.Text = "普通处理";
            this.normalBtn.UseVisualStyleBackColor = true;
            this.normalBtn.Click += new System.EventHandler(this.normalBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(99, 221);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(139, 55);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "退出";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // ConfirmReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 289);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.normalBtn);
            this.Controls.Add(this.LostBtn);
            this.Controls.Add(this.DamagedBtn);
            this.Controls.Add(this.OverdueBtn);
            this.Name = "ConfirmReturn";
            this.Text = "confirmReturn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OverdueBtn;
        private System.Windows.Forms.Button DamagedBtn;
        private System.Windows.Forms.Button LostBtn;
        private System.Windows.Forms.Button normalBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}