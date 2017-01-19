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

namespace InsightControl
{
	/// <summary>
	/// Summary description for OpenJobForm.
	/// </summary>
	public class OpenJobForm : System.Windows.Forms.Form
	{
    internal System.Windows.Forms.Button cmdDone;
    internal System.Windows.Forms.Button cmdOpen;
    internal System.Windows.Forms.ListBox lstJobList;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
    
    // This is the InSight object that communicates with the In-Sight sensor
    public Cognex.InSight.CvsInSight m_oInSight;
    
    // Represents a list of job files on the sensor.  List is populated and used 
    private string[] oFileList;


		public OpenJobForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            Cognex.InSight.CvsInSightSoftwareDevelopmentKit.Initialize();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      this.cmdDone = new System.Windows.Forms.Button();
      this.cmdOpen = new System.Windows.Forms.Button();
      this.lstJobList = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // cmdDone
      // 
      this.cmdDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdDone.Location = new System.Drawing.Point(87, 260);
      this.cmdDone.Name = "cmdDone";
      this.cmdDone.TabIndex = 6;
      this.cmdDone.Text = "&Done";
      this.cmdDone.Click += new System.EventHandler(this.cmdDone_Click);
      // 
      // cmdOpen
      // 
      this.cmdOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.cmdOpen.Location = new System.Drawing.Point(7, 260);
      this.cmdOpen.Name = "cmdOpen";
      this.cmdOpen.TabIndex = 5;
      this.cmdOpen.Text = "&Open";
      this.cmdOpen.Click += new System.EventHandler(this.cmdOpen_Click);
      // 
      // lstJobList
      // 
      this.lstJobList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
      this.lstJobList.Location = new System.Drawing.Point(7, 4);
      this.lstJobList.Name = "lstJobList";
      this.lstJobList.Size = new System.Drawing.Size(152, 251);
      this.lstJobList.TabIndex = 4;
      this.lstJobList.DoubleClick += new System.EventHandler(this.lstJobList_DoubleClick);
      // 
      // OpenJobForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
      this.ClientSize = new System.Drawing.Size(168, 286);
      this.Controls.Add(this.cmdDone);
      this.Controls.Add(this.cmdOpen);
      this.Controls.Add(this.lstJobList);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "OpenJobForm";
      this.Text = "OpenJobForm";
      this.Load += new System.EventHandler(this.OpenJobForm_Load);
      this.ResumeLayout(false);

    }
		#endregion



    // User doubleclicked an item in the list
    private void lstJobList_DoubleClick(object sender, System.EventArgs e)
    {
      cmdOpen_Click(sender, e);
    }

    // User clicked the Open button
    private void cmdOpen_Click(object sender, System.EventArgs e)
    {
      if (!(m_oInSight == null)) 
      {
        bool bState;
       
        // Save current state
        bState = m_oInSight.SoftOnline;
        
        // Must be offline to load a job
        m_oInSight.SoftOnline = false;
        
        // Load the new job file if exists
        if( lstJobList.SelectedIndex >=0 )
        {
          m_oInSight.File.LoadJobFile(lstJobList.SelectedItem.ToString());
        }
        
        // restore the online state to what it was
        m_oInSight.SoftOnline = bState;
      }
    }

    
    // Initialization of the OpenJobForm.  Populates the list of job files found on the Sensor
    private void OpenJobForm_Load(object sender, System.EventArgs e)
    {
      long i;
      if (!(m_oInSight == null)) 
      {
        // Retrieve the file list from the sensor
        oFileList = m_oInSight.File.GetFileList();
        for (i = 0; i < oFileList.Length; i++) 
        {
          // Filter out non-job files
          if(oFileList[i].Substring(oFileList[i].Length-4).ToUpper() == ".JOB") 
          {
            lstJobList.Items.Add(oFileList[i]);
          }
        }
      }
    }
    
    // User clicked the Done button
    private void cmdDone_Click(object sender, System.EventArgs e)
    {
      this.Close();
    }
	}
}
