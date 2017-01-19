namespace InsightControl
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.相机配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通讯配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openJobToolStripMenuItem,
            this.相机配置ToolStripMenuItem,
            this.通讯配置ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // 相机配置ToolStripMenuItem
            // 
            this.相机配置ToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.相机配置ToolStripMenuItem.MergeIndex = 1;
            this.相机配置ToolStripMenuItem.Name = "相机配置ToolStripMenuItem";
            this.相机配置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.相机配置ToolStripMenuItem.Text = "相机配置";
            // 
            // 通讯配置ToolStripMenuItem
            // 
            this.通讯配置ToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.通讯配置ToolStripMenuItem.MergeIndex = 2;
            this.通讯配置ToolStripMenuItem.Name = "通讯配置ToolStripMenuItem";
            this.通讯配置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.通讯配置ToolStripMenuItem.Text = "通讯配置";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.exitToolStripMenuItem.MergeIndex = 3;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // openJobToolStripMenuItem
            // 
            this.openJobToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.openJobToolStripMenuItem.MergeIndex = 0;
            this.openJobToolStripMenuItem.Name = "openJobToolStripMenuItem";
            this.openJobToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openJobToolStripMenuItem.Text = "&OpenJob";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 370);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 相机配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 通讯配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem openJobToolStripMenuItem;
    }
}

