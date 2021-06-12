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
    public partial class frmHastalikEkle : Form
    {
        IDiyetisyenController controller;
        public frmHastalikEkle(IDiyetisyenController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }
        string bayraK;
        void Aktif(bool dd)
        {
            txtTanim.Enabled = dd;
            txtAd.Enabled = dd;

            btnYeni.Enabled = !dd;
            btnEkle.Enabled = dd;
            btnIptal.Enabled = dd;
            btnSil.Enabled = !dd;
            btnGuncelle.Enabled = !dd;
        }

        void Doldur()
        {
            List<Hastalik> hastaliklar = new List<Hastalik>();
            hastaliklar = controller.hastalikTumunuBul();
            dgwHastalik.Rows.Clear();
            int sat = 0;
            foreach (var item in hastaliklar)
            {
                dgwHastalik.Rows.Add(1);
                dgwHastalik.Rows[sat].Cells[0].Value = (sat + 1).ToString();
                dgwHastalik.Rows[sat].Cells[1].Value = item.ad;
                dgwHastalik.Rows[sat].Cells[2].Value = item.tanim;
                dgwHastalik.Rows[sat].Cells[3].Value = item.id;
                sat++;
            }
        }
        private void frmHastalikEkle_Load(object sender, EventArgs e)
        {
            Doldur();
            Aktif(false);
        }

        private void frmHastalikEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
        }
        int hastalikID;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (bayraK == "Yeni")
                controller.hastalikEkle(txtAd.Text, txtTanim.Text);
            else
                controller.hastalikGuncelle(1, txtAd.Text, txtTanim.Text);
            Doldur();
            Aktif(false);
        }

        private void dgwHastalik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtAd.Text = dgwHastalik.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTanim.Text = dgwHastalik.Rows[e.RowIndex].Cells[2].Value.ToString();
                hastalikID = int.Parse(dgwHastalik.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtTanim.Text = "";
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

        private void dgwHastalik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
