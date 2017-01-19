/********************************************************************************
Copyright (C) 2005 Cognex Corporation

Subject to Cognex Corporation's terms and conditions and license agreement,
you are authorized to use and modify this sample source code in any way you find
useful, provided the Software and/or the modified Software is used solely in
conjunction with a Cognex Machine Vision System.  Furthermore you acknowledge
and agree that Cognex has no warranty, obligations or liability for your use
of the Software.
*******************************************************************************
NOTE: YOUR AND YOUR COMPANY'S USE OF THE IN-SIGHT SAMPLE SOURCE CODE CONTAINED
IN THIS FILE IS SUBJECT TO THE TERMS AND CONDITIONS OF SALE AS FURTHER
MODIFIED BY THE LIMITED USE LICENSE AGREEMENT GOVERNING THE USE AND
DISTRIBUTION OF IN-SIGHT SAMPLE SOURCE CODE.

PLEASE READ THE TERMS OF USE BELOW:
LIMITED USE LICENSE AGREEMENT (LULA)

YOUR AND YOUR COMPANY'S ("YOUR") USE OF THE SOURCE CODE IS
EXPRESSLY CONDITIONED UPON YOUR ACCEPTANCE OF THE FOLLOWING TERMS:
1.  IN-SIGHT SAMPLE SOURCE CODE MAY BE USED EXCLUSIVELY WITH COGNEX HARDWARE
    AND SOFTWARE PRODUCTS.
2.  IN-SIGHT SAMPLE SOURCE CODE MAY NOT BE DISTRIBUTED OR SUB-LICENSED WITHOUT
    A SEPARATE WRITTEN AGREEMENT SIGNED BY BOTH YOUR COMPANY AND COGNEX CORPORATION.
3.  ANY VIOLATION OF THIS LULA, THE TERMS AND CONDITIONS OF SALE, AND/OR
    THE ACCOMPANYING SOFTWARE LICENSE WILL ENTITLE COGNEX CORPORATION TO REVOKE
    YOUR SOFTWARE LICENSE.
********************************************************************************/


using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Cognex.InSight;

namespace InsightControl
{

    /// <summary>
    /// Summary description for frmMain.
    /// </summary>
    public class frmMain : System.Windows.Forms.Form
    {
        public enum ConnectStatus
        {
            Disconnected,
            Connecting,
            Connected,
            Disconnecting
        }


        #region
        internal System.Windows.Forms.MainMenu MainMenu1;
        internal System.Windows.Forms.MenuItem Menu_File;
        internal System.Windows.Forms.MenuItem Menu_OpenJob;
        internal System.Windows.Forms.MenuItem Menu_Exit;
        internal System.Windows.Forms.MenuItem Menu_View;
        internal System.Windows.Forms.MenuItem Menu_CustomView;
        internal System.Windows.Forms.MenuItem Menu_Overlay;
        internal System.Windows.Forms.MenuItem Menu_Image;
        internal System.Windows.Forms.MenuItem Menu_ManualTrigger;
        internal System.Windows.Forms.MenuItem Menu_LiveMode;
        internal System.Windows.Forms.MenuItem MenuItem9;
        internal System.Windows.Forms.MenuItem Menu_ZoomIn;
        internal System.Windows.Forms.MenuItem Menu_ZoomOut;
        internal System.Windows.Forms.MenuItem Menu_Zoom1To1;
        internal System.Windows.Forms.MenuItem MenuItem13;
        internal System.Windows.Forms.MenuItem Menu_ZoomFit;
        internal System.Windows.Forms.MenuItem Menu_ZoomFill;
        internal System.Windows.Forms.MenuItem Menu_Device;
        internal System.Windows.Forms.MenuItem Menu_Online;
        internal System.Windows.Forms.MenuItem Menu_Options;
        internal System.Windows.Forms.MenuItem Menu_Transparency;
        internal System.Windows.Forms.MenuItem Menu_Transparency0;
        internal System.Windows.Forms.MenuItem Menu_Transparency10;
        internal System.Windows.Forms.MenuItem Menu_Transparency20;
        internal System.Windows.Forms.MenuItem Menu_Transparency30;
        internal System.Windows.Forms.MenuItem Menu_Transparency40;
        internal System.Windows.Forms.MenuItem Menu_Transparency50;
        internal System.Windows.Forms.MenuItem Menu_Transparency60;
        internal System.Windows.Forms.MenuItem Menu_Transparency70;
        internal System.Windows.Forms.MenuItem Menu_Transparency80;
        internal System.Windows.Forms.MenuItem Menu_Transparency90;
        internal System.Windows.Forms.MenuItem Menu_Transparency100;
        internal System.Windows.Forms.MenuItem Menu_Scale;
        internal System.Windows.Forms.MenuItem Menu_Scale25;
        internal System.Windows.Forms.MenuItem Menu_Scale50;
        internal System.Windows.Forms.MenuItem Menu_Scale75;
        internal System.Windows.Forms.MenuItem Menu_Scale100;
        internal System.Windows.Forms.MenuItem Menu_Scale200;
        internal System.Windows.Forms.MenuItem Menu_Scale300;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal Cognex.InSight.Controls.Display.CvsInSightDisplay CvsInSightDisplay1;
        #endregion  控件定义

        #region Variable Declarations
        // This is the InSight object that communicates with the In-Sight sensor
        private Cognex.InSight.CvsInSight m_oInSight;

        // This is the network monitor that detects In-Sight sensors on the network
        // private Cognex.InSight.Net.CvsNetworkMonitor m_oMonitor;
        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private ToolStripStatusLabel lblCurrentStatus;
        private IContainer components;
        private OpenFileDialog openFileDialog1;
        private bool bClosing = false;

        #region  变量定义
        /// <summary>
        /// 变量定义
        /// </summary>
        private string ipAddress;//相机的IP地址
        private bool isConnect;
        public string IPAddreess
        {
            get
            {
                return ipAddress;
            }
            set
            {
                this.ipAddress = value;
            }
        }
        public bool IsConnect
        {
            get
            {
                return isConnect;
            }
            set
            {
                isConnect = value;
            }
        }
        #endregion
        // Required for Windows Form Designer support
        public frmMain(Main parent,string ipAddress, bool isConnect)
        {
            //initialize the SDK before Insight Display control can load properly
            Cognex.InSight.CvsInSightSoftwareDevelopmentKit.Initialize();
            InitializeComponent();
            lblCurrentStatus.Text = "Not Connected";
            lblCurrentStatus.Tag = ConnectStatus.Disconnected;
            this.IsConnect = isConnect;
            this.IPAddreess = ipAddress;
            MdiParent = parent;
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /* [STAThread]
         static void Main()
         {
           Application.Run(new frmMain());
         }
         */

    /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.components = new System.ComponentModel.Container();
            this.MainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.Menu_File = new System.Windows.Forms.MenuItem();
            this.Menu_OpenJob = new System.Windows.Forms.MenuItem();
            this.Menu_Exit = new System.Windows.Forms.MenuItem();
            this.Menu_View = new System.Windows.Forms.MenuItem();
            this.Menu_CustomView = new System.Windows.Forms.MenuItem();
            this.Menu_Overlay = new System.Windows.Forms.MenuItem();
            this.Menu_Image = new System.Windows.Forms.MenuItem();
            this.Menu_ManualTrigger = new System.Windows.Forms.MenuItem();
            this.Menu_LiveMode = new System.Windows.Forms.MenuItem();
            this.MenuItem9 = new System.Windows.Forms.MenuItem();
            this.Menu_ZoomIn = new System.Windows.Forms.MenuItem();
            this.Menu_ZoomOut = new System.Windows.Forms.MenuItem();
            this.Menu_Zoom1To1 = new System.Windows.Forms.MenuItem();
            this.MenuItem13 = new System.Windows.Forms.MenuItem();
            this.Menu_ZoomFit = new System.Windows.Forms.MenuItem();
            this.Menu_ZoomFill = new System.Windows.Forms.MenuItem();
            this.Menu_Device = new System.Windows.Forms.MenuItem();
            this.Menu_Online = new System.Windows.Forms.MenuItem();
            this.Menu_Options = new System.Windows.Forms.MenuItem();
            this.Menu_Transparency = new System.Windows.Forms.MenuItem();
            this.Menu_Transparency0 = new System.Windows.Forms.MenuItem();
            this.Menu_Transparency10 = new System.Windows.Forms.MenuItem();
            this.Menu_Transparency20 = new System.Windows.Forms.MenuItem();
            this.Menu_Transparency30 = new System.Windows.Forms.MenuItem();
            this.Menu_Transparency40 = new System.Windows.Forms.MenuItem();
            this.Menu_Transparency50 = new System.Windows.Forms.MenuItem();
            this.Menu_Transparency60 = new System.Windows.Forms.MenuItem();
            this.Menu_Transparency70 = new System.Windows.Forms.MenuItem();
            this.Menu_Transparency80 = new System.Windows.Forms.MenuItem();
            this.Menu_Transparency90 = new System.Windows.Forms.MenuItem();
            this.Menu_Transparency100 = new System.Windows.Forms.MenuItem();
            this.Menu_Scale = new System.Windows.Forms.MenuItem();
            this.Menu_Scale25 = new System.Windows.Forms.MenuItem();
            this.Menu_Scale50 = new System.Windows.Forms.MenuItem();
            this.Menu_Scale75 = new System.Windows.Forms.MenuItem();
            this.Menu_Scale100 = new System.Windows.Forms.MenuItem();
            this.Menu_Scale200 = new System.Windows.Forms.MenuItem();
            this.Menu_Scale300 = new System.Windows.Forms.MenuItem();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.CvsInSightDisplay1 = new Cognex.InSight.Controls.Display.CvsInSightDisplay();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrentStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.GroupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu1
            // 
            this.MainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Menu_File,
            this.Menu_View,
            this.Menu_Image,
            this.Menu_Device,
            this.Menu_Options});
            this.MainMenu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // Menu_File
            // 
            this.Menu_File.Index = 0;
            this.Menu_File.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Menu_OpenJob,
            this.Menu_Exit});
            this.Menu_File.Text = "&File";
            // 
            // Menu_OpenJob
            // 
            this.Menu_OpenJob.Index = 0;
            this.Menu_OpenJob.MergeType = System.Windows.Forms.MenuMerge.Replace;
            this.Menu_OpenJob.Text = "&Open Job";
            this.Menu_OpenJob.Click += new System.EventHandler(this.Menu_OpenJob_Click);
            // 
            // Menu_Exit
            // 
            this.Menu_Exit.Index = 1;
            this.Menu_Exit.MergeOrder = 3;
            this.Menu_Exit.MergeType = System.Windows.Forms.MenuMerge.Replace;
            this.Menu_Exit.Text = "E&xit";
            this.Menu_Exit.Click += new System.EventHandler(this.Menu_Exit_Click);
            // 
            // Menu_View
            // 
            this.Menu_View.Index = 1;
            this.Menu_View.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Menu_CustomView,
            this.Menu_Overlay});
            this.Menu_View.Text = "&View";
            // 
            // Menu_CustomView
            // 
            this.Menu_CustomView.Index = 0;
            this.Menu_CustomView.MergeType = System.Windows.Forms.MenuMerge.Replace;
            this.Menu_CustomView.Text = "&Custom View";
            this.Menu_CustomView.Click += new System.EventHandler(this.Menu_CustomView_Click);
            // 
            // Menu_Overlay
            // 
            this.Menu_Overlay.Index = 1;
            this.Menu_Overlay.MergeType = System.Windows.Forms.MenuMerge.Replace;
            this.Menu_Overlay.Text = "&Overlay";
            this.Menu_Overlay.Click += new System.EventHandler(this.Menu_Overlay_Click);
            // 
            // Menu_Image
            // 
            this.Menu_Image.Index = 2;
            this.Menu_Image.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Menu_ManualTrigger,
            this.Menu_LiveMode,
            this.MenuItem9,
            this.Menu_ZoomIn,
            this.Menu_ZoomOut,
            this.Menu_Zoom1To1,
            this.MenuItem13,
            this.Menu_ZoomFit,
            this.Menu_ZoomFill});
            this.Menu_Image.Text = "&Image";
            // 
            // Menu_ManualTrigger
            // 
            this.Menu_ManualTrigger.Index = 0;
            this.Menu_ManualTrigger.Text = "&Manual Trigger";
            this.Menu_ManualTrigger.Click += new System.EventHandler(this.Menu_ManualTrigger_Click);
            // 
            // Menu_LiveMode
            // 
            this.Menu_LiveMode.Index = 1;
            this.Menu_LiveMode.Text = "&Live Mode";
            this.Menu_LiveMode.Click += new System.EventHandler(this.Menu_LiveMode_Click);
            // 
            // MenuItem9
            // 
            this.MenuItem9.Index = 2;
            this.MenuItem9.Text = "-";
            // 
            // Menu_ZoomIn
            // 
            this.Menu_ZoomIn.Index = 3;
            this.Menu_ZoomIn.Text = "Zoom &In";
            this.Menu_ZoomIn.Click += new System.EventHandler(this.Menu_ZoomIn_Click);
            // 
            // Menu_ZoomOut
            // 
            this.Menu_ZoomOut.Index = 4;
            this.Menu_ZoomOut.Text = "Zoom &Out";
            this.Menu_ZoomOut.Click += new System.EventHandler(this.Menu_ZoomOut_Click);
            // 
            // Menu_Zoom1To1
            // 
            this.Menu_Zoom1To1.Index = 5;
            this.Menu_Zoom1To1.Text = "Zoom &1:1";
            this.Menu_Zoom1To1.Click += new System.EventHandler(this.Menu_Zoom1To1_Click);
            // 
            // MenuItem13
            // 
            this.MenuItem13.Index = 6;
            this.MenuItem13.Text = "-";
            // 
            // Menu_ZoomFit
            // 
            this.Menu_ZoomFit.Index = 7;
            this.Menu_ZoomFit.Text = "Zoom To Fi&t";
            this.Menu_ZoomFit.Click += new System.EventHandler(this.Menu_ZoomFit_Click);
            // 
            // Menu_ZoomFill
            // 
            this.Menu_ZoomFill.Index = 8;
            this.Menu_ZoomFill.Text = "&Zoom To Fill";
            this.Menu_ZoomFill.Click += new System.EventHandler(this.Menu_ZoomFill_Click);
            // 
            // Menu_Device
            // 
            this.Menu_Device.Index = 3;
            this.Menu_Device.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Menu_Online});
            this.Menu_Device.Text = "&Sensor";
            // 
            // Menu_Online
            // 
            this.Menu_Online.Index = 0;
            this.Menu_Online.Text = "&Online";
            this.Menu_Online.Click += new System.EventHandler(this.Menu_Online_Click);
            // 
            // Menu_Options
            // 
            this.Menu_Options.Index = 4;
            this.Menu_Options.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Menu_Transparency,
            this.Menu_Scale});
            this.Menu_Options.Text = "&Options";
            // 
            // Menu_Transparency
            // 
            this.Menu_Transparency.Index = 0;
            this.Menu_Transparency.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Menu_Transparency0,
            this.Menu_Transparency10,
            this.Menu_Transparency20,
            this.Menu_Transparency30,
            this.Menu_Transparency40,
            this.Menu_Transparency50,
            this.Menu_Transparency60,
            this.Menu_Transparency70,
            this.Menu_Transparency80,
            this.Menu_Transparency90,
            this.Menu_Transparency100});
            this.Menu_Transparency.RadioCheck = true;
            this.Menu_Transparency.Text = "Spreadsheet &Transparency";
            this.Menu_Transparency.Click += new System.EventHandler(this.Menu_Transparency0_Click);
            // 
            // Menu_Transparency0
            // 
            this.Menu_Transparency0.Index = 0;
            this.Menu_Transparency0.Text = "0%";
            this.Menu_Transparency0.Click += new System.EventHandler(this.Menu_Transparency0_Click);
            // 
            // Menu_Transparency10
            // 
            this.Menu_Transparency10.Index = 1;
            this.Menu_Transparency10.Text = "10%";
            this.Menu_Transparency10.Click += new System.EventHandler(this.Menu_Transparency10_Click);
            // 
            // Menu_Transparency20
            // 
            this.Menu_Transparency20.Index = 2;
            this.Menu_Transparency20.Text = "20%";
            this.Menu_Transparency20.Click += new System.EventHandler(this.Menu_Transparency20_Click);
            // 
            // Menu_Transparency30
            // 
            this.Menu_Transparency30.Index = 3;
            this.Menu_Transparency30.Text = "30%";
            this.Menu_Transparency30.Click += new System.EventHandler(this.Menu_Transparency30_Click);
            // 
            // Menu_Transparency40
            // 
            this.Menu_Transparency40.Index = 4;
            this.Menu_Transparency40.Text = "40%";
            this.Menu_Transparency40.Click += new System.EventHandler(this.Menu_Transparency40_Click);
            // 
            // Menu_Transparency50
            // 
            this.Menu_Transparency50.Index = 5;
            this.Menu_Transparency50.Text = "50%";
            this.Menu_Transparency50.Click += new System.EventHandler(this.Menu_Transparency50_Click);
            // 
            // Menu_Transparency60
            // 
            this.Menu_Transparency60.Index = 6;
            this.Menu_Transparency60.Text = "60%";
            this.Menu_Transparency60.Click += new System.EventHandler(this.Menu_Transparency60_Click);
            // 
            // Menu_Transparency70
            // 
            this.Menu_Transparency70.Checked = true;
            this.Menu_Transparency70.Index = 7;
            this.Menu_Transparency70.Text = "70%";
            this.Menu_Transparency70.Click += new System.EventHandler(this.Menu_Transparency70_Click);
            // 
            // Menu_Transparency80
            // 
            this.Menu_Transparency80.Index = 8;
            this.Menu_Transparency80.Text = "80%";
            this.Menu_Transparency80.Click += new System.EventHandler(this.Menu_Transparency80_Click);
            // 
            // Menu_Transparency90
            // 
            this.Menu_Transparency90.Index = 9;
            this.Menu_Transparency90.Text = "90%";
            this.Menu_Transparency90.Click += new System.EventHandler(this.Menu_Transparency90_Click);
            // 
            // Menu_Transparency100
            // 
            this.Menu_Transparency100.Index = 10;
            this.Menu_Transparency100.Text = "100%";
            this.Menu_Transparency100.Click += new System.EventHandler(this.Menu_Transparency100_Click);
            // 
            // Menu_Scale
            // 
            this.Menu_Scale.Index = 1;
            this.Menu_Scale.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Menu_Scale25,
            this.Menu_Scale50,
            this.Menu_Scale75,
            this.Menu_Scale100,
            this.Menu_Scale200,
            this.Menu_Scale300});
            this.Menu_Scale.Text = "Spreadsheet &Scale";
            // 
            // Menu_Scale25
            // 
            this.Menu_Scale25.Index = 0;
            this.Menu_Scale25.Text = "25%";
            this.Menu_Scale25.Click += new System.EventHandler(this.Menu_Scale25_Click);
            // 
            // Menu_Scale50
            // 
            this.Menu_Scale50.Index = 1;
            this.Menu_Scale50.Text = "50%";
            this.Menu_Scale50.Click += new System.EventHandler(this.Menu_Scale50_Click);
            // 
            // Menu_Scale75
            // 
            this.Menu_Scale75.Index = 2;
            this.Menu_Scale75.Text = "75%";
            this.Menu_Scale75.Click += new System.EventHandler(this.Menu_Scale75_Click);
            // 
            // Menu_Scale100
            // 
            this.Menu_Scale100.Checked = true;
            this.Menu_Scale100.Index = 3;
            this.Menu_Scale100.Text = "100%";
            this.Menu_Scale100.Click += new System.EventHandler(this.Menu_Scale100_Click);
            // 
            // Menu_Scale200
            // 
            this.Menu_Scale200.Index = 4;
            this.Menu_Scale200.Text = "200%";
            this.Menu_Scale200.Click += new System.EventHandler(this.Menu_Scale200_Click);
            // 
            // Menu_Scale300
            // 
            this.Menu_Scale300.Index = 5;
            this.Menu_Scale300.Text = "300%";
            this.Menu_Scale300.Click += new System.EventHandler(this.Menu_Scale300_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox1.Controls.Add(this.CvsInSightDisplay1);
            this.GroupBox1.Location = new System.Drawing.Point(5, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(686, 467);
            this.GroupBox1.TabIndex = 20;
            this.GroupBox1.TabStop = false;
            // 
            // CvsInSightDisplay1
            // 
            this.CvsInSightDisplay1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CvsInSightDisplay1.DefaultTextScaleMode = Cognex.InSight.Controls.Display.CvsInSightDisplay.TextScaleModeType.Proportional;
            this.CvsInSightDisplay1.DialogIcon = null;
            this.CvsInSightDisplay1.GridOpacity = 0.7D;
            this.CvsInSightDisplay1.Location = new System.Drawing.Point(8, 23);
            this.CvsInSightDisplay1.Name = "CvsInSightDisplay1";
            this.CvsInSightDisplay1.Size = new System.Drawing.Size(670, 436);
            this.CvsInSightDisplay1.TabIndex = 1;
            this.CvsInSightDisplay1.InSightChanged += new System.EventHandler(this.CvsInSightDisplay1_InSightChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.lblCurrentStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 494);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(696, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 17);
            this.statusLabel.Text = "Status";
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(86, 17);
            this.lblCurrentStatus.Text = "Disconnected";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(696, 516);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu = this.MainMenu1;
            this.Name = "frmMain";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.frmMain_Closing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.GroupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

    #region Button Events

        // User pressed the Accept button (graphics editing)
     
        // User pressed the Cancel button (graphics editing)
      
        // User pressed the Connect / Disconnect button

    #endregion

    #region General Functions

    // Refresh the controls.
    // Function is usually called if something changed

    private void connectToInsight(bool connect)
        {
            try
            {
                if (connect)
                {
                    if (!(IsConnected))
                    {
                        // Connect using classic mode
                        CvsInSightDisplay1.Connect(IPAddreess, "admin", "", false);

                        // Store connected sensor name 
                       

                        // Initialize the display control
                        CvsInSightDisplay1.ShowGrid = true;
                        CvsInSightDisplay1.ShowGraphics = true;
                        CvsInSightDisplay1.ShowImage = true;
                        CvsInSightDisplay1.ShowScrollBars = true;

                        lblCurrentStatus.Text = "Connecting";
                        lblCurrentStatus.Tag = ConnectStatus.Connecting;
                        // Update the insight object (returns null)
                        m_oInSight = CvsInSightDisplay1.InSight;
                    }
                    else
                    {
                        lblCurrentStatus.Text = "Disconnecting";
                        lblCurrentStatus.Tag = ConnectStatus.Disconnected;
                        m_oInSight.Disconnect();
                    }

                    // Refresh the form before updating the status bar, to make sure that
                    // the results from the CvsInSight are current.
                    this.Refresh();

                }

            }
            catch (Exception ex)
            {
                // m_oMonitor.Enabled = true;
                if (!(ex.GetType() == Cognex.InSight.CvsInSightError.SensorAlreadyConnectedException.GetType()))
                {
                    // do error handling
                }
            }
            UpdateControls(false);
        }
    private void UpdateControls(bool sensorUpdate)
    {
      if (!bClosing)
      {
        if (!IsConnected)
        {
          Menu_OpenJob.Enabled = false;
          Menu_View.Enabled = false;
          Menu_Image.Enabled = false;
          Menu_Device.Enabled = false;
          Menu_Options.Enabled = false;
          this.Text = "Cognex In-Sight Display Demo - Not Connected";
          if ((ConnectStatus)lblCurrentStatus.Tag == ConnectStatus.Connecting && sensorUpdate)
          {
            lblCurrentStatus.Text = "Not Connected - Connection Failed";
            MessageBox.Show(this, "Failed to Connect", "Error");
          }
          else
          {
            lblCurrentStatus.Text = "Not Connected";
          }
          lblCurrentStatus.Tag = ConnectStatus.Disconnected;
        }
        else
        {
          Menu_Image.Enabled = true;
          Menu_Device.Enabled = true;
          Menu_CustomView.Checked = m_oInSight.JobInfo.AnyCustomViews;
          Menu_Overlay.Checked = CvsInSightDisplay1.ShowGrid;

          // When in live acquisition mode, disable invalid operations
          Menu_LiveMode.Checked = m_oInSight.LiveAcquisition;
          if (m_oInSight.LiveAcquisition)
          {
            Menu_OpenJob.Enabled = false;
            Menu_ManualTrigger.Enabled = false;
            Menu_LiveMode.Enabled = true;
            Menu_Device.Enabled = false;
            Menu_View.Enabled = false;
            Menu_Options.Enabled = false;
          }
          else
          {
            Menu_OpenJob.Enabled = true;
            Menu_ManualTrigger.Enabled = (m_oInSight.State == Cognex.InSight.CvsInSightState.Offline);
            Menu_LiveMode.Enabled = (m_oInSight.State == Cognex.InSight.CvsInSightState.Offline);
            Menu_Device.Enabled = true;
            Menu_View.Enabled = true;
            Menu_Options.Enabled = true;
          }
          lblCurrentStatus.Tag = ConnectStatus.Connected;
          ApplyGenericOnlineStatusLabel();
          // Refresh the titlebar with the current info
          if (m_oInSight.State == Cognex.InSight.CvsInSightState.Offline)
          {
            this.Text = "In-Sight Display Demo - " + IPAddreess + ", Offline";
            Menu_Online.Text = "Go Online";
          }
          else
          {
            this.Text = "In-Sight Display Demo - " + IPAddreess + ", Online";
            Menu_Online.Text = "Go Offline";
          }
        }
      }
    }
    private void ApplyGenericOnlineStatusLabel()
    {
      if (m_oInSight != null)
      {
        if (m_oInSight.LiveAcquisition)
        {
          lblCurrentStatus.Text = "Connected and in Live Mode";
        }
        else
        {
          lblCurrentStatus.Text = "Connected";
        }
        // Refresh the titlebar with the current info
        if (m_oInSight.State == Cognex.InSight.CvsInSightState.Offline)
        {
          lblCurrentStatus.Text += " - Sensor is Offline";
        }
        else
        {
          lblCurrentStatus.Text += " - Sensor is Online";
        }
      }
    }
    // Detects a list of In-Sight Sensors on the network, adding each sensor to a combo box (cmbHosts)
    //不使用
  /*  private void PopulateHostList()
    {
      cmbHosts.Items.Clear();
      int Index;
      Index = 0;
      //cmbHosts.Enabled = (m_oMonitor.Hosts.Count > 0);

      // Traverse through the hosts (InSight Sensors), adding them to the combo box (cmbHosts)
      foreach (Cognex.InSight.Net.CvsHostSensor Host in m_oMonitor.Hosts)
      {
        cmbHosts.Items.Add(Host.Name);

        Index = Index + 1;

        if (IsConnected && Host.Name == cmbHosts.Tag.ToString())
        {
          cmbHosts.SelectedIndex = cmbHosts.Items.Count - 1;
        }
      }

      // Select the first item in the list if none are selected
      if (cmbHosts.Items.Count > 0 & cmbHosts.SelectedIndex == -1) cmbHosts.SelectedIndex = 0;
      else if (cmbHosts.Tag.ToString() != "") cmbHosts.Text = cmbHosts.Tag.ToString();
    }

*/
    // Returns true if currently connected to an In-Sight Sensor
    public bool IsConnected
    {
      get
      {
        // It's possible for oInSight to be nothing while the display is
        // connecting to a new sensor, so we must handle that case as well as
        // when its State property is CvsInSightState_NotConnected
        if (!(m_oInSight == null))
          if (m_oInSight.State != Cognex.InSight.CvsInSightState.NotConnected)
            return (true);
          else
            return false;
        else
          return false;
      }
    }

    #endregion

    #region ISDK Events
    // This event is raised when the status information of the Cognex Display Control changes
    private void OnStatusInformationChanged(object sender, EventArgs e)
    {
      if (CvsInSightDisplay1.StatusInformation != null)
      {
        lblCurrentStatus.Text = CvsInSightDisplay1.StatusInformation;
      }
      else
      {
        ApplyGenericOnlineStatusLabel();
      }
      this.statusStrip1.Update();
    }

    // This event is raised when the InSight property of the display has changed
    private void CvsInSightDisplay1_InSightChanged(object sender, System.EventArgs e)
    {
      m_oInSight = CvsInSightDisplay1.InSight;
      UpdateControls(true);
    }


    // Called when the CvsInSight's State property has changed
    private void m_oInSight_StateChanged(object sender, Cognex.InSight.CvsStateChangedEventArgs e)
    {
      UpdateControls(true);
    }


    // Called when the network monitor's list of hosts has changed
    private void m_oMonitor_HostsChanged(object sender, System.EventArgs e)
    {
     // PopulateHostList();
    }

    #endregion

    #region Form Events
    // Initialization of the main form.
    private void frmMain_Load(object sender, System.EventArgs e)
    {

      // Ensure graphics editing buttons are disabled
      //cmdAccept.Visible = false;
     // cmdCancel.Visible = false;

      // Create a new network monitor and connect to events of the display's InSight
     // m_oMonitor = new Cognex.InSight.Net.CvsNetworkMonitor();
      //m_oMonitor.PingInterval = 0;

      SpreadsheetDisplayTypeUpdate(0);
      m_oInSight = CvsInSightDisplay1.InSight;
      CvsInSightDisplay1.GridOpacity = .7;
      CvsInSightDisplay1.ImageScale = 1;
      CvsInSightDisplay1.StatusInformationChanged += new EventHandler(OnStatusInformationChanged);
      this.m_oInSight.StateChanged += new Cognex.InSight.CvsStateChangedEventHandler(m_oInSight_StateChanged);
    //  this.m_oMonitor.HostsChanged += new EventHandler(m_oMonitor_HostsChanged);

     // m_oMonitor.Enabled = true;

      // Refresh all form & control state settings
      UpdateControls(true);
      connectToInsight(true);

            //MDI父窗体设置
     
    }

    // Form close event - Cleanup 
    private void frmMain_Closing(object sender, System.ComponentModel.CancelEventArgs e)
    {
      bClosing = true;
      if (m_oInSight != null)
      {
        m_oInSight.Disconnect();
      }
    //  m_oMonitor.Dispose();
      m_oInSight = null;
    }

    #endregion

    #region Main Menu
    // User clicked the Open Job menu item
    private void Menu_OpenJob_Click(object sender, System.EventArgs e)
    {
      // Connect current In-Sight object to the open job form
      if (IsConnected)
      {
        OpenJobForm OJF = new OpenJobForm();
        OJF.m_oInSight = m_oInSight;
        OJF.Show();
      }
    }

    // User clicked the Exit menu item
    private void Menu_Exit_Click(object sender, System.EventArgs e)
    {
      //m_oMonitor.Dispose();
      System.Environment.Exit(0);
    }


    // User clicked View->CustomView menu item
    private void Menu_CustomView_Click(object sender, System.EventArgs e)
    {
      CvsInSightDisplay1.ShowCustomView = !(Menu_CustomView.Checked);
      Menu_CustomView.Checked = CvsInSightDisplay1.ShowCustomView;
    }


    // User clicked View->Overlay menu item
    private void Menu_Overlay_Click(object sender, System.EventArgs e)
    {
      CvsInSightDisplay1.ShowGrid = !(Menu_Overlay.Checked);
      Menu_Overlay.Checked = CvsInSightDisplay1.ShowGrid;
    }


    // User clicked ManualTrigger menu item
    private void Menu_ManualTrigger_Click(object sender, System.EventArgs e)
    {
      if (IsConnected)
      {
        m_oInSight.ManualAcquire();
      }
    }
    
    // User clicked the Live Mode menu option
    private void Menu_LiveMode_Click(object sender, System.EventArgs e)
    {
      if (IsConnected)
      {
        Menu_LiveMode.Checked = !(Menu_LiveMode.Checked);
        m_oInSight.LiveAcquisition = Menu_LiveMode.Checked;
        UpdateControls(false);
      }
    }


    // User clicked the zoom in menu option
    private void Menu_ZoomIn_Click(object sender, System.EventArgs e)
    {
      Menu_ZoomFit.Checked = false;
      Menu_ZoomFill.Checked = false;
      CvsInSightDisplay1.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.None;
      CvsInSightDisplay1.ImageScale = CvsInSightDisplay1.ImageScale * 2;
    }


    // User clicked the zoom out menu option
    private void Menu_ZoomOut_Click(object sender, System.EventArgs e)
    {
      Menu_ZoomFit.Checked = false;
      Menu_ZoomFill.Checked = false;
      CvsInSightDisplay1.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.None;
      CvsInSightDisplay1.ImageScale = CvsInSightDisplay1.ImageScale / 2;
    }


    // User clicked the zoom 1:1 menu option
    private void Menu_Zoom1To1_Click(object sender, System.EventArgs e)
    {
      Menu_ZoomFit.Checked = false;
      Menu_ZoomFill.Checked = false;
      CvsInSightDisplay1.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.None;
      CvsInSightDisplay1.ImageScale = 1;
    }


    // User has clicked Image->Zoom to fit menu item
    private void Menu_ZoomFit_Click(object sender, System.EventArgs e)
    {
      Menu_ZoomFit.Checked = !(Menu_ZoomFit.Checked);
      Menu_ZoomFill.Checked = false;
      if (Menu_ZoomFit.Checked)
      {
        CvsInSightDisplay1.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fit;
      }
      else
      {
        CvsInSightDisplay1.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.None;
      }
    }
    
    // User has clicked Image->Zoom to fill menu item
    private void Menu_ZoomFill_Click(object sender, System.EventArgs e)
    {
      Menu_ZoomFit.Checked = false;
      Menu_ZoomFill.Checked = !(Menu_ZoomFill.Checked);
      if (Menu_ZoomFill.Checked)
      {
        CvsInSightDisplay1.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.Fill;
      }
      else
      {
        CvsInSightDisplay1.ImageZoomMode = Cognex.InSight.Controls.Display.CvsDisplayZoom.None;
      }
    }


    // User has clicked Sensor->Go Online/Offline menu item
    private void Menu_Online_Click(object sender, System.EventArgs e)
    {
      CvsInSightDisplay1.InSight.SoftOnline = !(CvsInSightDisplay1.InSight.SoftOnline);
      UpdateControls(false);
    }



    // SpreadsheetDisplayTypeUpdate - User clicked a spreadsheet menu item, other controls need to be updated.
    private void SpreadsheetDisplayTypeUpdate(short val)
    {
      switch (val)
      {
        // Initial
        case 0:
          break;

        // Spreadsheet
        case 1:
          CvsInSightDisplay1.ShowGrid = true;
          CvsInSightDisplay1.ShowImage = true;
          CvsInSightDisplay1.ShowGraphics = true;
          break;

        // Custom View
        case 2:
          CvsInSightDisplay1.ShowCustomView = true;
          break;

        // Image Only (no spreadsheet)
        case 3:
          CvsInSightDisplay1.ShowGrid = true;
          CvsInSightDisplay1.ShowCustomView = true;
          CvsInSightDisplay1.ShowImage = true;
          CvsInSightDisplay1.ShowGraphics = true;
          break;
      }
    }


    // User clicked a transparency menu option, controls need to be updated.
    private void TransparencyUpdate(short val)
    {
      Menu_Transparency0.Checked = false;
      Menu_Transparency10.Checked = false;
      Menu_Transparency20.Checked = false;
      Menu_Transparency30.Checked = false;
      Menu_Transparency40.Checked = false;
      Menu_Transparency50.Checked = false;
      Menu_Transparency60.Checked = false;
      Menu_Transparency70.Checked = false;
      Menu_Transparency80.Checked = false;
      Menu_Transparency90.Checked = false;
      Menu_Transparency100.Checked = false;

      switch (val)
      {
        case 0:
          Menu_Transparency0.Checked = true;
          break;
        case 10:
          Menu_Transparency10.Checked = true;
          break;
        case 20:
          Menu_Transparency20.Checked = true;
          break;
        case 30:
          Menu_Transparency30.Checked = true;
          break;
        case 40:
          Menu_Transparency40.Checked = true;
          break;
        case 50:
          Menu_Transparency50.Checked = true;
          break;
        case 60:
          Menu_Transparency60.Checked = true;
          break;
        case 70:
          Menu_Transparency70.Checked = true;
          break;
        case 80:
          Menu_Transparency80.Checked = true;
          break;
        case 90:
          Menu_Transparency90.Checked = true;
          break;
        case 100:
          Menu_Transparency100.Checked = true;
          break;
      }
      CvsInSightDisplay1.GridOpacity = ((100 - val) / 100.0);
    }


    // User clicked a Spreadsheet Scale menu option, controls need to be updated.
    private void SpreadsheetScaleUpdate(double val)
    {
      Menu_Scale25.Checked = false;
      Menu_Scale50.Checked = false;
      Menu_Scale75.Checked = false;
      Menu_Scale100.Checked = false;
      Menu_Scale200.Checked = false;
      Menu_Scale300.Checked = false;
      if (val == 25)
      {
        Menu_Scale25.Checked = true;
      }
      else if (val == 50)
      {
        Menu_Scale50.Checked = true;
      }
      else if (val == 75)
      {
        Menu_Scale75.Checked = true;
      }
      else if (val == 100)
      {
        Menu_Scale100.Checked = true;
      }
      else if (val == 200)
      {
        Menu_Scale200.Checked = true;
      }
      else if (val == 300)
      {
        Menu_Scale300.Checked = true;
      }
      CvsInSightDisplay1.GridScale = (val / 100);
    }


    // User clicked a Spreadsheet Transparency menu option, controls need to be updated.
    #region Transparency

    // User clicked Transparency of 0% menu item
    private void Menu_Transparency0_Click(object sender, System.EventArgs e)
    {
      TransparencyUpdate(0);
    }
    // User clicked Transparency of 10% menu item
    private void Menu_Transparency10_Click(object sender, System.EventArgs e)
    {
      TransparencyUpdate(10);
    }
    // User clicked Transparency of 20% menu item
    private void Menu_Transparency20_Click(object sender, System.EventArgs e)
    {
      TransparencyUpdate(20);
    }
    // User clicked Transparency of 30% menu item
    private void Menu_Transparency30_Click(object sender, System.EventArgs e)
    {
      TransparencyUpdate(30);
    }
    // User clicked Transparency of 40% menu item
    private void Menu_Transparency40_Click(object sender, System.EventArgs e)
    {
      TransparencyUpdate(40);
    }
    // User clicked Transparency of 50% menu item
    private void Menu_Transparency50_Click(object sender, System.EventArgs e)
    {
      TransparencyUpdate(50);
    }
    // User clicked Transparency of 60% menu item
    private void Menu_Transparency60_Click(object sender, System.EventArgs e)
    {
      TransparencyUpdate(60);
    }
    // User clicked Transparency of 70% menu item
    private void Menu_Transparency70_Click(object sender, System.EventArgs e)
    {
      TransparencyUpdate(70);
    }
    // User clicked Transparency of 80% menu item
    private void Menu_Transparency80_Click(object sender, System.EventArgs e)
    {
      TransparencyUpdate(80);
    }
    // User clicked Transparency of 90% menu item
    private void Menu_Transparency90_Click(object sender, System.EventArgs e)
    {
      TransparencyUpdate(90);
    }
    // User clicked Transparency of 100% menu item
    private void Menu_Transparency100_Click(object sender, System.EventArgs e)
    {
      TransparencyUpdate(100);
    }
    #endregion

    // User clicked a Spreadsheet Scale menu option, controls need to be updated.
    #region Spreadsheet Scale
    // User clicked Scale of 25% menu item
    private void Menu_Scale25_Click(object sender, System.EventArgs e)
    {
      SpreadsheetScaleUpdate(25);
    }
    // User clicked Scale of 50% menu item
    private void Menu_Scale50_Click(object sender, System.EventArgs e)
    {
      SpreadsheetScaleUpdate(50);
    }
    // User clicked Scale of 75% menu item
    private void Menu_Scale75_Click(object sender, System.EventArgs e)
    {
      SpreadsheetScaleUpdate(75);
    }
    // User clicked Scale of 100% menu item
    private void Menu_Scale100_Click(object sender, System.EventArgs e)
    {
      SpreadsheetScaleUpdate(100);
    }
    // User clicked Scale of 200% menu item
    private void Menu_Scale200_Click(object sender, System.EventArgs e)
    {
      SpreadsheetScaleUpdate(200);
    }
    // User clicked Scale of 300% menu item
    private void Menu_Scale300_Click(object sender, System.EventArgs e)
    {
      SpreadsheetScaleUpdate(300);
    }
    #endregion

    private void button1_Click(object sender, EventArgs e)
    {
      openFileDialog1.ShowDialog();
    }
        #endregion
    }
}
