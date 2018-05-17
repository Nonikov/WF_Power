using System.Drawing;

namespace WF_Power
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonShutDown = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.buttonHiber = new System.Windows.Forms.Button();
            this.buttonLock = new System.Windows.Forms.Button();
            this.buttonSleep = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShutDown
            // 
            this.buttonShutDown.BackColor = System.Drawing.Color.Gray;
            this.buttonShutDown.FlatAppearance.BorderSize = 0;
            this.buttonShutDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonShutDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShutDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShutDown.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonShutDown.Location = new System.Drawing.Point(36, 15);
            this.buttonShutDown.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.buttonShutDown.Name = "buttonShutDown";
            this.buttonShutDown.Size = new System.Drawing.Size(336, 43);
            this.buttonShutDown.TabIndex = 0;
            this.buttonShutDown.Text = "Shut down";
            this.buttonShutDown.UseVisualStyleBackColor = false;
            this.buttonShutDown.Click += new System.EventHandler(this.buttonShutDown_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.Color.Gray;
            this.buttonRestart.FlatAppearance.BorderSize = 0;
            this.buttonRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestart.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRestart.Location = new System.Drawing.Point(36, 70);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(336, 43);
            this.buttonRestart.TabIndex = 2;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.BackColor = System.Drawing.Color.Gray;
            this.buttonSignOut.FlatAppearance.BorderSize = 0;
            this.buttonSignOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSignOut.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSignOut.Location = new System.Drawing.Point(36, 290);
            this.buttonSignOut.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(336, 43);
            this.buttonSignOut.TabIndex = 3;
            this.buttonSignOut.Text = "Sign out";
            this.buttonSignOut.UseVisualStyleBackColor = false;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // buttonHiber
            // 
            this.buttonHiber.BackColor = System.Drawing.Color.Gray;
            this.buttonHiber.FlatAppearance.BorderSize = 0;
            this.buttonHiber.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonHiber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHiber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHiber.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonHiber.Location = new System.Drawing.Point(36, 180);
            this.buttonHiber.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.buttonHiber.Name = "buttonHiber";
            this.buttonHiber.Size = new System.Drawing.Size(336, 43);
            this.buttonHiber.TabIndex = 4;
            this.buttonHiber.Text = "Hibernate";
            this.buttonHiber.UseVisualStyleBackColor = false;
            this.buttonHiber.Click += new System.EventHandler(this.buttonHiber_Click);
            // 
            // buttonLock
            // 
            this.buttonLock.BackColor = System.Drawing.Color.Gray;
            this.buttonLock.FlatAppearance.BorderSize = 0;
            this.buttonLock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonLock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLock.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLock.Location = new System.Drawing.Point(36, 235);
            this.buttonLock.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(336, 43);
            this.buttonLock.TabIndex = 5;
            this.buttonLock.Text = "Lock";
            this.buttonLock.UseVisualStyleBackColor = false;
            this.buttonLock.Click += new System.EventHandler(this.buttonLock_Click);
            // 
            // buttonSleep
            // 
            this.buttonSleep.BackColor = System.Drawing.Color.Gray;
            this.buttonSleep.FlatAppearance.BorderSize = 0;
            this.buttonSleep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.buttonSleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSleep.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSleep.Location = new System.Drawing.Point(36, 125);
            this.buttonSleep.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.buttonSleep.Name = "buttonSleep";
            this.buttonSleep.Size = new System.Drawing.Size(336, 43);
            this.buttonSleep.TabIndex = 6;
            this.buttonSleep.Text = "Sleep";
            this.buttonSleep.UseVisualStyleBackColor = false;
            this.buttonSleep.Click += new System.EventHandler(this.buttonSleep_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "WP_Power application still working";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "WF_Power";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAppToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // openAppToolStripMenuItem
            // 
            this.openAppToolStripMenuItem.Name = "openAppToolStripMenuItem";
            this.openAppToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.openAppToolStripMenuItem.Text = "Open App";
            this.openAppToolStripMenuItem.Click += new System.EventHandler(this.openAppToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(415, 346);
            this.Controls.Add(this.buttonSleep);
            this.Controls.Add(this.buttonLock);
            this.Controls.Add(this.buttonHiber);
            this.Controls.Add(this.buttonSignOut);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonShutDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WF_Power";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShutDown;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Button buttonHiber;
        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.Button buttonSleep;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

