namespace 图书管理系统
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.UsersManageButton = new System.Windows.Forms.Button();
            this.BookManageButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.BookStrorageButton = new System.Windows.Forms.Button();
            this.PublisherButton = new System.Windows.Forms.Button();
            this.borrowBtn = new System.Windows.Forms.Button();
            this.FineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsersManageButton
            // 
            this.UsersManageButton.Location = new System.Drawing.Point(43, 142);
            this.UsersManageButton.Name = "UsersManageButton";
            this.UsersManageButton.Size = new System.Drawing.Size(125, 56);
            this.UsersManageButton.TabIndex = 0;
            this.UsersManageButton.Text = "用户管理";
            this.UsersManageButton.UseVisualStyleBackColor = true;
            this.UsersManageButton.Click += new System.EventHandler(this.UsersManageButton_Click);
            // 
            // BookManageButton
            // 
            this.BookManageButton.Location = new System.Drawing.Point(196, 51);
            this.BookManageButton.Name = "BookManageButton";
            this.BookManageButton.Size = new System.Drawing.Size(125, 56);
            this.BookManageButton.TabIndex = 1;
            this.BookManageButton.Text = "图书信息管理";
            this.BookManageButton.UseVisualStyleBackColor = true;
            this.BookManageButton.Click += new System.EventHandler(this.BookManageButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(196, 233);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 56);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "退出登录";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // BookStrorageButton
            // 
            this.BookStrorageButton.Location = new System.Drawing.Point(351, 51);
            this.BookStrorageButton.Name = "BookStrorageButton";
            this.BookStrorageButton.Size = new System.Drawing.Size(131, 56);
            this.BookStrorageButton.TabIndex = 5;
            this.BookStrorageButton.Text = "图书馆藏管理";
            this.BookStrorageButton.UseVisualStyleBackColor = true;
            this.BookStrorageButton.Click += new System.EventHandler(this.BookStrorageButton_Click);
            // 
            // PublisherButton
            // 
            this.PublisherButton.Location = new System.Drawing.Point(196, 142);
            this.PublisherButton.Name = "PublisherButton";
            this.PublisherButton.Size = new System.Drawing.Size(125, 56);
            this.PublisherButton.TabIndex = 6;
            this.PublisherButton.Text = "出版社管理";
            this.PublisherButton.UseVisualStyleBackColor = true;
            this.PublisherButton.Click += new System.EventHandler(this.PublisherButton_Click);
            // 
            // borrowBtn
            // 
            this.borrowBtn.Location = new System.Drawing.Point(43, 48);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(125, 59);
            this.borrowBtn.TabIndex = 7;
            this.borrowBtn.Text = "图书借还管理";
            this.borrowBtn.UseVisualStyleBackColor = true;
            this.borrowBtn.Click += new System.EventHandler(this.borrowBtn_Click);
            // 
            // FineButton
            // 
            this.FineButton.Location = new System.Drawing.Point(351, 142);
            this.FineButton.Name = "FineButton";
            this.FineButton.Size = new System.Drawing.Size(131, 56);
            this.FineButton.TabIndex = 8;
            this.FineButton.Text = "罚款管理";
            this.FineButton.UseVisualStyleBackColor = true;
            this.FineButton.Click += new System.EventHandler(this.FineButton_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 318);
            this.ControlBox = false;
            this.Controls.Add(this.FineButton);
            this.Controls.Add(this.PublisherButton);
            this.Controls.Add(this.BookStrorageButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.BookManageButton);
            this.Controls.Add(this.UsersManageButton);
            this.Controls.Add(this.borrowBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书管理菜单";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UsersManageButton;
        private System.Windows.Forms.Button BookManageButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button BookStrorageButton;
        private System.Windows.Forms.Button PublisherButton;
        private System.Windows.Forms.Button borrowBtn;
        private System.Windows.Forms.Button FineButton;
    }
}