namespace BOOK
{
    partial class admin1
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
            this.系統ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.圖書館裡ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.幫助ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系統ToolStripMenuItem1,
            this.圖書館裡ToolStripMenuItem1,
            this.幫助ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系統ToolStripMenuItem1
            // 
            this.系統ToolStripMenuItem1.Name = "系統ToolStripMenuItem1";
            this.系統ToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.系統ToolStripMenuItem1.Text = "系統";
            // 
            // 圖書館裡ToolStripMenuItem1
            // 
            this.圖書館裡ToolStripMenuItem1.Name = "圖書館裡ToolStripMenuItem1";
            this.圖書館裡ToolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.圖書館裡ToolStripMenuItem1.Text = "圖書管理";
            this.圖書館裡ToolStripMenuItem1.Click += new System.EventHandler(this.圖書館裡ToolStripMenuItem1_Click);
            // 
            // 幫助ToolStripMenuItem1
            // 
            this.幫助ToolStripMenuItem1.Name = "幫助ToolStripMenuItem1";
            this.幫助ToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.幫助ToolStripMenuItem1.Text = "幫助";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 81);
            this.label1.TabIndex = 3;
            this.label1.Text = "管理員登入";
            // 
            // admin1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "admin1";
            this.Text = "admin1";
            this.Load += new System.EventHandler(this.admin1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系統ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 圖書館裡ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 幫助ToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
    }
}