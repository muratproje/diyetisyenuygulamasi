using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using diyetisyen_core_project.controller;

namespace diyetisyenGUI
{
    public partial class DiyetisyenAnaForm : Form
    {
        public DiyetisyenAnaForm()
        {
            InitializeComponent();
        }
        IDiyetisyenController controller=null;
        private void DiyetisyenAnaForm_Load(object sender, EventArgs e)
        {
            controller = DiyetisyenControllerImp.getInstance();//Singleton 
            frmLogin dlg = new frmLogin(controller);
            DialogResult dr = dlg.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                if(Tanimlar.UserRole=="D")
                    diyetsiyenKayıtToolStripMenuItem.Visible = false;
                else
                    diyetsiyenKayıtToolStripMenuItem.Visible = true;                
            }
            else
                this.Close();
            
        }
        private void hastaKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count != 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            frmHastaEkle frm = new frmHastaEkle(controller);
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Top;
            frm.BringToFront();
            frm.Show();
        }

        private void diyetsiyenKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count != 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            frmDiyetisyenEkle frm = new frmDiyetisyenEkle(controller);
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Top;
            frm.BringToFront();
            frm.Show();
        }

        private void diyetKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count != 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            frmDiyetEkle frm = new frmDiyetEkle(controller);
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Top;
            frm.BringToFront();
            frm.Show();
        }

        private void hastalıkKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count != 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            frmHastalikEkle frm = new frmHastalikEkle(controller);
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Top;
            frm.BringToFront();
            frm.Show();
        }

        private void hastaRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Count != 0)
            {
                panel1.Controls.RemoveAt(0);
            }
            frmRaporlama frm = new frmRaporlama(controller);
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Top;
            frm.BringToFront();
            frm.Show();
        }
    }
}
