using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tuopan_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.notifyIcon1.Visible = true;

        }




        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason==CloseReason.UserClosing)
            {
                e.Cancel = true;
                ShowWindow("最小化");
                return;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.Visible == true)
            {
                ShowWindow("最小化");
            }
            else
            {
                ShowWindow("还原");
            }
        }

        private void 最大化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindow("最大化");
        }

        private void 最小化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindow("最小化");
        }



        private void 还原ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindow("还原");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notifyIcon1.Visible = false;
            this.Close();
            this.Dispose();
            System.Environment.Exit(System.Environment.ExitCode);
        }

        void ShowWindow(string strState)
        {

            if(strState=="最大化")
            {
                this.Show();
                this.WindowState = FormWindowState.Maximized;
                this.Activate();
            }
            else if (strState == "最小化")
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
            else if (strState == "还原")
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }

        }

    }
}
