using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenLibrary
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChanPassword frm = new frmChanPassword();
            frm.Show();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserManagement frm = new frmUserManagement();
            frm.Show();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void loạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookType frm = new frmBookType();
            frm.Show();
        }

        private void tênSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBook frm = new frmBook();
            frm.Show();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPublishingCompany frm = new frmPublishingCompany();
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDateTime.Visible = statusToolStripMenuItem.Checked;
        }

    }
}
