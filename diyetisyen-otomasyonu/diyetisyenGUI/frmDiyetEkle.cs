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
    public partial class frmDiyetEkle : Form
    {
        IDiyetisyenController controller;
        public frmDiyetEkle(IDiyetisyenController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }
        void Aktif(bool dd)
        {
            txtMenu.Enabled = dd;
            txtAd.Enabled = dd;

            btnYeni.Enabled = !dd;
            btnEkle.Enabled = dd;
            btnIptal.Enabled = dd;
            btnSil.Enabled = !dd;
            btnGuncelle.Enabled = !dd;
        }
        private void frmDiyetEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
        }
        void Doldur()
        {
            List<Diyet> diyetler = new List<Diyet>();
            diyetler = controller.diyetTumunuBul();
            dgwDiyet.Rows.Clear();
            int sat = 0;
            foreach (var item in diyetler)
            {
                dgwDiyet.Rows.Add(1);
                dgwDiyet.Rows[sat].Cells[0].Value = (sat + 1).ToString();
                dgwDiyet.Rows[sat].Cells[1].Value = item.ad;
                dgwDiyet.Rows[sat].Cells[2].Value = item.besin;
                dgwDiyet.Rows[sat].Cells[3].Value = item.id;
                sat++;
            }
        }
        private void frmDiyetEkle_Load(object sender, EventArgs e)
        {
            Doldur();
            Aktif(false);
        }
        string bayraK;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (bayraK == "Yeni")
                controller.diyetEkle(txtAd.Text, txtMenu.Text);
            else
                controller.diyetGuncelle(diyetID, txtAd.Text, txtMenu.Text);
            Doldur();
            Aktif(false);
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (diyetID > 0)
            {
                DialogResult cvp = MessageBox.Show("Kaydı Silmek İStediğinize Emin Misiniz?", "Diyet Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == cvp)
                {
                    controller.diyetSil(diyetID);
                    Doldur();
                    diyetID = 0;
                }
            }
            else
                MessageBox.Show("Silinecek Kaydı Seçiniz", "Diyet Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        int diyetID;
        private void dgwDiyet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                txtAd.Text = dgwDiyet.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMenu.Text = dgwDiyet.Rows[e.RowIndex].Cells[2].Value.ToString();
                diyetID = int.Parse(dgwDiyet.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtMenu.Text = "";
            bayraK = "Yeni";
            Aktif(true);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bayraK = "Guncelle";
            Aktif(true);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Aktif(false);
        }
    }
}
