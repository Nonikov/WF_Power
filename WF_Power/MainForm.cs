using System;
using System.Windows.Forms;

namespace WF_Power
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Model
        private void buttonShutDown_Click(object sender, EventArgs e)
        {
            Model.ShutDown();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Model.Restart();
        }

        private void buttonHiber_Click(object sender, EventArgs e)
        {
            Model.Hiber();
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            Model.SignOut();
        }

        private void buttonLock_Click(object sender, EventArgs e)
        {
            Model.Lock();
        }

        private void buttonSleep_Click(object sender, EventArgs e)
        {
            Model.Sleep();
        }
        #endregion

        #region View
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void openAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
            }
        }
        #endregion
    }
}
