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
    public partial class frmLogin : Form
    {
        IDiyetisyenController controller;
        public frmLogin(IDiyetisyenController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            Diyetisyen diyetisyen = new Diyetisyen();
            diyetisyen = controller.diyetisyenBul(int.Parse(cmbDiyetisyen.SelectedValue.ToString()));
            if (txtSifre.Text == diyetisyen.tc)
            {
                Tanimlar.UserRole = diyetisyen.rol;
                Tanimlar.DiyetisyenID = diyetisyen.id;
                Tanimlar.DiyetisyenTC = diyetisyen.tc;
                Tanimlar.DiyetisyenAd = diyetisyen.ad;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            #region Diyetisyen Doldur
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] { new DataColumn("Id", typeof(int)), new DataColumn("adsoyad", typeof(string)) });
            dt.Rows.Add(0, "Seçiniz");

            List<Diyetisyen> diyetisyenler = controller.diyetisyenTumunuBul();
            foreach (var item in diyetisyenler)
            {
                dt.Rows.Add(item.id, item.ad + " " + item.soyad);
            }
            cmbDiyetisyen.DataSource = dt;
            cmbDiyetisyen.DisplayMember = "adsoyad";
            cmbDiyetisyen.ValueMember = "Id";
            #endregion
        }
    }
}
