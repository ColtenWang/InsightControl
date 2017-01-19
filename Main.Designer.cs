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
            this.openJobToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.相机配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通讯配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualTriggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToFitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.sensorToolStripMenuItem,
            this.optionsToolStripMenuItem});
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
            // openJobToolStripMenuItem
            // 
            this.openJobToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.openJobToolStripMenuItem.MergeIndex = 0;
            this.openJobToolStripMenuItem.Name = "openJobToolStripMenuItem";
            this.openJobToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openJobToolStripMenuItem.Text = "&OpenJob";
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
            this.通讯配置ToolStripMenuItem.Name = "通讯配置ToolStripMenuItem";
            this.通讯配置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.通讯配置ToolStripMenuItem.Text = "通讯配置";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customViewToolStripMenuItem,
            this.overlayToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // customViewToolStripMenuItem
            // 
            this.customViewToolStripMenuItem.Name = "customViewToolStripMenuItem";
            this.customViewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customViewToolStripMenuItem.Text = "&Custom View";
            // 
            // overlayToolStripMenuItem
            // 
            this.overlayToolStripMenuItem.Name = "overlayToolStripMenuItem";
            this.overlayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.overlayToolStripMenuItem.Text = "&Overlay";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualTriggerToolStripMenuItem,
            this.liveModeToolStripMenuItem,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.zoom11ToolStripMenuItem,
            this.zoomToFitToolStripMenuItem,
            this.zoomToFillToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.imageToolStripMenuItem.Text = "&Image";
            // 
            // manualTriggerToolStripMenuItem
            // 
            this.manualTriggerToolStripMenuItem.Name = "manualTriggerToolStripMenuItem";
            this.manualTriggerToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.manualTriggerToolStripMenuItem.Text = "Manual Trigger";
            // 
            // liveModeToolStripMenuItem
            // 
            this.liveModeToolStripMenuItem.Name = "liveModeToolStripMenuItem";
            this.liveModeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.liveModeToolStripMenuItem.Text = "Live Mode";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            // 
            // zoom11ToolStripMenuItem
            // 
            this.zoom11ToolStripMenuItem.Name = "zoom11ToolStripMenuItem";
            this.zoom11ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.zoom11ToolStripMenuItem.Text = "Zoom 1:1";
            // 
            // zoomToFitToolStripMenuItem
            // 
            this.zoomToFitToolStripMenuItem.Name = "zoomToFitToolStripMenuItem";
            this.zoomToFitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.zoomToFitToolStripMenuItem.Text = "Zoom To Fit";
            // 
            // zoomToFillToolStripMenuItem
            // 
            this.zoomToFillToolStripMenuItem.Name = "zoomToFillToolStripMenuItem";
            this.zoomToFillToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.zoomToFillToolStripMenuItem.Text = "Zoom To Fill";
            // 
            // sensorToolStripMenuItem
            // 
            this.sensorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineToolStripMenuItem,
            this.connectToolStripMenuItem});
            this.sensorToolStripMenuItem.Name = "sensorToolStripMenuItem";
            this.sensorToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.sensorToolStripMenuItem.Text = "Sensor";
            // 
            // onlineToolStripMenuItem
            // 
            this.onlineToolStripMenuItem.Name = "onlineToolStripMenuItem";
            this.onlineToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.onlineToolStripMenuItem.Text = "Online";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
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
        private System.Windows.Forms.ToolStripMenuItem openJobToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 相机配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 通讯配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualTriggerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoom11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToFitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sensorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

