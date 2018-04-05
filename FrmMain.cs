using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RailwayDatabaseClient.ClassApplication;
using RailwayDatabaseClient.ClassEncry;

namespace RailwayDatabaseClient
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 筛选配置文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TxtboxSearch_Leave(object sender, EventArgs e)
        {
            if (TxtBoxSearch.Text == "") TxtBoxSearch.Text = "搜索...";
        }

        private void TxtboxSearch_Click(object sender, EventArgs e)
        {
            if (TxtBoxSearch.Text == "搜索...") TxtBoxSearch.Text = "";
        }

        private void ButtSearch_Click(object sender, EventArgs e)
        {

        }

        private void TxtBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtFliter_Click(object sender, EventArgs e)
        {

        }
    }
}
