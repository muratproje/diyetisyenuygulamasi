using System;
using System.Windows.Forms;
using diyetisyen_core_project.controller;
using diyetisyen_core_project.domain;
using System.IO;
using diyetisyen_core_project.entity;

namespace diyetisyenGUI
{
    public partial class frmRaporlama : Form
    {
        IDiyetisyenController controller;
        public frmRaporlama(IDiyetisyenController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void frmRaporlama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
        }
        int tip, duzen;
        private void frmRaporlama_Load(object sender, EventArgs e)
        {
            htmlRapor();
            tip = 1;
            duzen = 1;
        }
        void htmlRapor()
        {

        }
        void jsonRapor()
        {

            
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                htmlRapor();
            else if (tabControl1.SelectedIndex == 1)
                jsonRapor();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void rbHTML_Click(object sender, EventArgs e)
        {
            tip = 1;
        }
        private void rbJSON_Click(object sender, EventArgs e)
        {
            tip = 2;
        }

        private void rbHasta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbHasta_Click(object sender, EventArgs e)
        {
            duzen = 1;
        }

        private void rbDiyet_Click(object sender, EventArgs e)
        {
            duzen = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hasta hasta = controller.hastaBul(txtTC.Text);
            controller.raporAl(hasta, tip, duzen);
            webBrowser1.Url = new Uri(Path.GetDirectoryName(Application.ExecutablePath) + "/htmlRapor.html");
        }
    }
}
