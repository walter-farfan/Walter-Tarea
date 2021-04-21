using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPPP : Form
    {
        public frmPPP()
        {
            InitializeComponent();
        }
        CapaNegocio.PPP ppp1 = new CapaNegocio.PPP();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string empresa = txtEmpresa.Text;
            int nroMeses = int.Parse(txtNroMeses.Text);
            string profesion = txtProfesion.Text;
            string area = txtArea.Text;
            ppp1.Empresa = empresa;
            ppp1.NroMeses = nroMeses;
            ppp1.Profesion = profesion;
            ppp1.Area = area;
            MessageBox.Show("Se han registrado correctamente los datos de Practicas Pre-Profesionales 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string empresa = ppp1.Empresa;
            int nroMeses = ppp1.NroMeses;
            string profesion = ppp1.Profesion;
            string area = ppp1.Area;
            MessageBox.Show("Empresa: " + empresa + " Nro. de Mesess: " + nroMeses + " Profesion: " + profesion + " Area: " + area);
        }

        private void btnGanarExperiencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.GanarExperiencia());
        }

        private void btnAprender_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.Aprender());
        }

        private void btnAplicarConocimientos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp1.AplicarConocimientos());
        }
    }
}
