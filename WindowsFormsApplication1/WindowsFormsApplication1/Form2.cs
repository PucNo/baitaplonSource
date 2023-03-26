using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.OleDb;
using System.Threading;
using System.IO;
using System.Media;
using System.Drawing.Drawing2D;

using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void enablefull()
        {
            
            đăngNhậpToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = true;
            
            quảnLýBăngĐĩaToolStripMenuItem.Enabled = true;
            đăngKýToolStripMenuItem.Enabled = true;
            tìmKiếmToolStripMenuItem.Enabled = true;
            thôngTinBăngĐĩaToolStripMenuItem.Enabled = true;
            helpToolStripMenuItem.Enabled = true;
            khácToolStripMenuItem.Enabled = true;
        }
        public void disfull()
        {
            
         
            đăngNhậpToolStripMenuItem.Enabled = true;
            đăngXuấtToolStripMenuItem.Enabled = false;
            quảnLýBăngĐĩaToolStripMenuItem.Enabled = false;
            tìmKiếmToolStripMenuItem.Enabled = false;
            thôngTinBăngĐĩaToolStripMenuItem.Enabled = false;
            helpToolStripMenuItem.Enabled = false;
            khácToolStripMenuItem.Enabled = false;
        }
        public void dangxuatdong()
        {
            disfull();
            đăngXuấtToolStripMenuItem.Enabled = false;
            đăngNhậpToolStripMenuItem.Enabled = true;
            đăngKýToolStripMenuItem.Enabled = true;
            quảnLýBăngĐĩaToolStripMenuItem.Enabled = false;
            tìmKiếmToolStripMenuItem.Enabled = false;
            thôngTinBăngĐĩaToolStripMenuItem.Enabled = false;
            helpToolStripMenuItem.Enabled = false;
            khácToolStripMenuItem.Enabled = false;
        }
        public void dangxuathien()
        {
            đăngXuấtToolStripMenuItem.Enabled = true;
            đăngNhậpToolStripMenuItem.Enabled = false;
            đăngKýToolStripMenuItem.Enabled = false;
            quảnLýBăngĐĩaToolStripMenuItem.Enabled = false;
            tìmKiếmToolStripMenuItem.Enabled = false;
            thôngTinBăngĐĩaToolStripMenuItem.Enabled = false;
            helpToolStripMenuItem.Enabled = false;
            khácToolStripMenuItem.Enabled = false;
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmlog = new Form1();
            frmlog.MdiParent = this;
            frmlog.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            disfull();
            dangxuatdong();
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            disfull();
            Form frmlog = new Form1();
            frmlog.MdiParent = this;
            frmlog.Show();
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReg frmreg = new FrmReg();
            frmreg.MdiParent = this;
            frmreg.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFind frmfind = new FrmFind();
            frmfind.MdiParent = this;
            frmfind.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = Application.StartupPath + "\\Help.chm";
                p.Start();
            }
            catch
            {
                MessageBox.Show("Mở file Help.chm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void khácToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                Process p = new Process();
                p.StartInfo.FileName = Application.StartupPath + "\\Help.pdf";
                p.Start();
            }
            catch
            {
                MessageBox.Show("Mở file Help.pdf thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void quảnLýBăngĐĩaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQL frmql = new FrmQL();
            frmql.MdiParent = this;
            frmql.Show();
        }

        private void thôngTinBăngĐĩaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.MdiParent = this;
            frm3.Show();
        }

    }
}
