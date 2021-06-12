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
    public partial class frmHastaEkle : Form
    {
        IDiyetisyenController controller;
        void Aktif(bool dd)
        {
            txtAd.Enabled = dd;
            txtSoyad.Enabled = dd;
            cmbDiyet.Enabled = dd;
            cmbDiyetisyen.Enabled = dd;
            cmbHastalik.Enabled = dd;
            txtdiyetTanim.Enabled = dd;

            btnYeni.Enabled =! dd;
            btnEkle.Enabled = dd;
            btnIptal.Enabled = dd;
            btnSil.Enabled = !dd;
            btnGuncelle.Enabled = !dd;

        }
        public frmHastaEkle(IDiyetisyenController controller)
        {
            InitializeComponent();
            this.controller=controller;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if(bayraK=="Yeni")
                controller.hastaEkle(txtTC.Text, txtAd.Text, txtSoyad.Text,int.Parse(cmbDiyetisyen.SelectedValue.ToString()),int.Parse(cmbHastalik.SelectedValue.ToString()),int.Parse(cmbDiyet.SelectedValue.ToString()),txtdiyetTanim.Text);
            else
                controller.hastaGuncelle(txtAd.Text, txtSoyad.Text, txtTC.Text, int.Parse(cmbDiyetisyen.SelectedValue.ToString()), int.Parse(cmbHastalik.SelectedValue.ToString()), int.Parse(cmbDiyet.SelectedValue.ToString()), txtdiyetTanim.Text);
            controller.diyetGuncelle(int.Parse(cmbDiyet.SelectedValue.ToString()), cmbDiyet.Text, txtdiyetTanim.Text);

            Aktif(false);
        }
        private void frmHastaEkle_Load(object sender, EventArgs e)
        {
            Aktif(false);
            #region Diyetisyen Doldur
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] { new DataColumn("Id", typeof(int)), new DataColumn("adsoyad", typeof(string)) });
            dt.Rows.Add(0, "Seçiniz");

            List<Diyetisyen> diyetisyenler = controller.diyetisyenTumunuBul();
            foreach (var item in diyetisyenler)
            {
                dt.Rows.Add(item.id, item.ad+" "+item.soyad);
            }
            cmbDiyetisyen.DataSource = dt;
            cmbDiyetisyen.DisplayMember = "adsoyad";
            cmbDiyetisyen.ValueMember = "Id";
            #endregion
            #region Hastalık Doldur
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] { new DataColumn("Id", typeof(int)), new DataColumn("ad", typeof(string)) });
            dt.Rows.Add(0, "Seçiniz");

            List<Hastalik> hastaliklar = controller.hastalikTumunuBul();
            foreach (var item in hastaliklar)
            {
                dt.Rows.Add(item.id, item.ad);
            }
            cmbHastalik.DataSource = dt;
            cmbHastalik.DisplayMember = "ad";
            cmbHastalik.ValueMember = "Id";
            #endregion
            #region Diyet Doldur
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] { new DataColumn("Id", typeof(int)), new DataColumn("ad", typeof(string)) });
            dt.Rows.Add(0, "Seçiniz");

            List<Diyet> diyetler = controller.diyetTumunuBul();
            foreach (var item in diyetler)
            {
                dt.Rows.Add(item.id, item.ad);
            }
            cmbDiyet.DataSource = dt;
            cmbDiyet.DisplayMember = "ad";
            cmbDiyet.ValueMember = "Id";
            #endregion
        }
        string bayraK;
        private void btnYeni_Click(object sender, EventArgs e)
        {
            bayraK = "Yeni";
            Aktif(true);
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTC.Text = "";
        }

        private void frmHastaEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Aktif(false);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bayraK = "Guncelle";
            Aktif(true);
        }

        private void cmbDiyetisyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cvp = MessageBox.Show("Kaydı Silmek İStediğinize Emin Misiniz?", "Hasta Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes==cvp)
                controller.hastaSil(txtTC.Text);
        }

        private void cmbDiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDiyet.SelectedIndex > 0)
                txtdiyetTanim.Text= controller.diyetBul(int.Parse(cmbDiyet.SelectedValue.ToString())).besin;
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                Hasta hasta = new Hasta();
                hasta=controller.hastaBul(txtTC.Text);
                txtAd.Text = hasta.ad;
                txtSoyad.Text = hasta.soyad;
                txtdiyetTanim.Text = hasta.diyettanim;

                for (int i = 0; i < cmbDiyet.Items.Count; i++)
                {
                    cmbDiyet.SelectedIndex = i;
                    if ((int)cmbDiyet.SelectedValue == hasta.diyet)
                        break;
                }

                for (int i = 0; i < cmbDiyetisyen.Items.Count; i++)
                {
                    cmbDiyetisyen.SelectedIndex = i;
                    if ((int)cmbDiyetisyen.SelectedValue == hasta.diyetisyen)
                        break;
                }

                for (int i = 0; i < cmbHastalik.Items.Count; i++)
                {
                    cmbHastalik.SelectedIndex = i;
                    if ((int)cmbHastalik.SelectedValue == hasta.hastalik)
                        break;
                }
            }
        }
    }
}
