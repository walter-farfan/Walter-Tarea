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
    public partial class frmAsignatura : Form
    {
        public frmAsignatura()
        {
            InitializeComponent();
        }
        
        CapaNegocio.Asignatura asignatura1 = new CapaNegocio.Asignatura();
        
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string profesor = txtProfesor.Text;
            int unidades = int.Parse(txtUnidades.Text);
            int creditos = int.Parse(txtCreditos.Text);
            asignatura1.Nombre = nombre;
            asignatura1.Profesor = profesor;
            asignatura1.Unidades = unidades;
            asignatura1.Creditos = creditos;
            MessageBox.Show("Se han registrado correctamente los datos de Laboratorio 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombre = asignatura1.Nombre;
            string profesor = asignatura1.Profesor;
            int unidades = asignatura1.Unidades;
            int creditos = asignatura1.Creditos;
            MessageBox.Show("Nombre Curso: " + nombre + " Profesor: " + profesor + " NroUnidades: " + unidades + " Creditos: " + creditos);
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Tareas());
        }

        private void btnExposiciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Exposiciones());
        }

        private void btnExamenes_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura1.Examenes());
        }
    }
}
