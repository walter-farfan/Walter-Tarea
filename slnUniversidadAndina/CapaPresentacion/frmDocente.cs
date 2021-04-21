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
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
        }
        
        CapaNegocio.Docente docente1 = new CapaNegocio.Docente();
        
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            DateTime fechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            string profesion = txtProfesion.Text;
            docente1.Dni = dni;
            docente1.Apellidos = apellidos;
            docente1.Nombres = nombres;
            docente1.FechaNacimiento = fechaNacimiento;
            docente1.Profesion = profesion;
            MessageBox.Show("Se han registrado correctamente los datos de Docente 1");

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string dni = docente1.Dni;
            string apellidos = docente1.Apellidos;
            string nombres = docente1.Nombres;
            DateTime fechaNacimeinto = docente1.FechaNacimiento;
            string profesion = docente1.Profesion;
            MessageBox.Show("Dni: " + dni + " Apellidos: " + apellidos + " Nombres: " + nombres + " fecha de Nacimiento: " + fechaNacimeinto + " Profesion: " + profesion);
        }

        private void btnEnseñar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Enseñar());
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Matricular());
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente1.Desaprobar());
        }
    }
}
