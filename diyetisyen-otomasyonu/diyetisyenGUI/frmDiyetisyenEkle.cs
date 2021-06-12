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
using diyetisyen_core_project.entity;
namespace diyetisyenGUI
{
    public partial class frmDiyetisyenEkle : Form
    {
        IDiyetisyenController controller;
        public frmDiyetisyenEkle(IDiyetisyenController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }
        void Aktif(bool dd)
        {
            txtAd.Enabled = dd;
            txtSoyad.Enabled = dd;

            btnYeni.Enabled = !dd;
            btnEkle.Enabled = dd;
            btnIptal.Enabled = dd;
            btnSil.Enabled = !dd;
            btnGuncelle.Enabled = !dd;

        }
        void Doldur()
        {
            List<Diyetisyen> diyetisyenler = new List<Diyetisyen>();
            diyetisyenler = controller.diyetisyenTumunuBul();
            dgwDiyetisyen.Rows.Clear();
            int sat = 0;
            foreach (var item in diyetisyenler)
            {
                dgwDiyetisyen.Rows.Add(1);
                dgwDiyetisyen.Rows[sat].Cells[0].Value = (sat + 1).ToString();
                dgwDiyetisyen.Rows[sat].Cells[1].Value = item.tc;
                dgwDiyetisyen.Rows[sat].Cells[2].Value = item.ad;
                dgwDiyetisyen.Rows[sat].Cells[3].Value = item.soyad;
                dgwDiyetisyen.Rows[sat].Cells[4].Value = item.id;
                sat++;
            }
        }
        private void frmDiyetisyen_Load(object sender, EventArgs e)
        {
            Doldur();
            Aktif(false);
        }

        private void frmDiyetisyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(bayraK=="Yeni")
                controller.diyetisyenEkle(txtTC.Text, txtAd.Text, txtSoyad.Text, "D");
            else
                controller.diyetisyenGuncelle(txtAd.Text, txtSoyad.Text, txtTC.Text);
            Aktif(false);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtTC.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            bayraK = "Yeni";
            Aktif(true);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Kaydı Silmek İStediğinize Emin Misiniz?", "Hasta Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == cvp)
                controller.diyetisyenSil(txtTC.Text);
        }
        string bayraK;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bayraK = "Guncelle";
            Aktif(true);
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Aktif(false);
        }
        int diyetisyenID;
        private void dgwDiyetisyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTC.Text = dgwDiyetisyen.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAd.Text = dgwDiyetisyen.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSoyad.Text= dgwDiyetisyen.Rows[e.RowIndex].Cells[3].Value.ToString();
                diyetisyenID = int.Parse(dgwDiyetisyen.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
        }
    }
}
