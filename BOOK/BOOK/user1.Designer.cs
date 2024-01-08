namespace BOOK
{
    partial class user1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系統ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看借閱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借出與歸還ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系統ToolStripMenuItem,
            this.查看借閱ToolStripMenuItem,
            this.借出與歸還ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系統ToolStripMenuItem
            // 
            this.系統ToolStripMenuItem.Name = "系統ToolStripMenuItem";
            this.系統ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.系統ToolStripMenuItem.Text = "系統";
            // 
            // 查看借閱ToolStripMenuItem
            // 
            this.查看借閱ToolStripMenuItem.Name = "查看借閱ToolStripMenuItem";
            this.查看借閱ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.查看借閱ToolStripMenuItem.Text = "查看借閱";
            this.查看借閱ToolStripMenuItem.Click += new System.EventHandler(this.查看借閱ToolStripMenuItem_Click);
            // 
            // 借出與歸還ToolStripMenuItem
            // 
            this.借出與歸還ToolStripMenuItem.Name = "借出與歸還ToolStripMenuItem";
            this.借出與歸還ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.借出與歸還ToolStripMenuItem.Text = "借出與歸還";
            this.借出與歸還ToolStripMenuItem.Click += new System.EventHandler(this.借出與歸還ToolStripMenuItem_Click);
            // 
            // user1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "user1";
            this.Text = "user1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系統ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看借閱ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借出與歸還ToolStripMenuItem;
    }
}