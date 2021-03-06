﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlocklandManager
{
    public partial class Container : Form
    {
        public Container()
        {
            InitializeComponent();
            //Directory directoryForm = new Directory();
            //directoryForm.MdiParent = this;
            //directoryForm.Show();
        }

        private void managerWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            mainForm.MdiParent = this;
            mainForm.Show();
        }

        public string statusText //Does not work.
        {
            get
            {
                return this.statusBar.Text;
            }
            set
            {
                this.statusBar.Text = value;
            }
        }

        private void blocklandV21SteamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("This requires a copy of Blockland to be on your Steam account. If Blockland is already installed, then this will launch Blockland.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            //{
            //    System.Diagnostics.Process.Start("steam://run/250340");
            //}
            throw new NotImplementedException();
        }

        private void aboutBlocklandManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutForm = new AboutBox();
            aboutForm.MdiParent = this;
            aboutForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Start iconDebug = new Start();
            iconDebug.MdiParent = this;
            iconDebug.Show();
        }
    }
}
