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
    public partial class frmJefePractica : Form
    {
        public frmJefePractica()
        {
            InitializeComponent();
        }

        CapaNegocio.JefePractica jefePractica1 = new CapaNegocio.JefePractica();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string profesion = txtProfesion.Text;
            jefePractica1.Apellidos = apellidos;
            jefePractica1.Nombres = nombres;
            jefePractica1.Edad = edad;
            jefePractica1.Profesion = profesion;
            MessageBox.Show("Se han registrado correctamente los datos de Jefe Practica 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = jefePractica1.Apellidos;
            string nombres = jefePractica1.Nombres;
            int edad = jefePractica1.Edad;
            string profesion = jefePractica1.Profesion;
            MessageBox.Show("Apellidos: " + apellidos + " Nombres: " + nombres + " Edad: " + edad + " Profesion: " + profesion);
        }

        private void btnApruevaNotas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica1.ApruevaNotas());
        }

        private void btnExplica_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica1.Explica());
        }

        private void btnCalifica_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica1.Califica());
        }
    }
}
