using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsightControl
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        public void updateDisplay()
        {
            try
            {
                //判断MDI窗口是否已打开，如果打开则关闭
                if (this.MdiChildren!=null)
                {
                    foreach (frmMain frm in this.MdiChildren)
                    {
                        frm.Close();
                    }
                }
                frmMain newForm = new frmMain(this,"192.168.170.181", true);
                newForm.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            updateDisplay();
        }
    }
}
