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
    public partial class frmLaboratorio : Form
    {
        public frmLaboratorio()
        {
            InitializeComponent();
        }

        CapaNegocio.Laboratorio laboratorio1 = new CapaNegocio.Laboratorio();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string nombreCurso = txtNombreCurso.Text;
            string profesor = txtProfesor.Text;
            string materiales = txtMateriales.Text;
            string ubicacion = txtUbicacion.Text;
            laboratorio1.NombreCurso = nombreCurso;
            laboratorio1.Profesor = profesor;
            laboratorio1.Materiales = materiales;
            laboratorio1.Ubicacion = ubicacion;
            MessageBox.Show("Se han registrado correctamente los datos de Laboratorio 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string nombreCurso = laboratorio1.NombreCurso;
            string profesor = laboratorio1.Profesor;
            string materiales = laboratorio1.Materiales;
            string ubicacion = laboratorio1.Ubicacion;
            MessageBox.Show("Nombre Curso: " + nombreCurso + " Profesor: " + profesor + " Materiales: " + materiales + " Ubicacion: " + ubicacion);
        }

        private void btnClases_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Clases());
        }

        private void btnExperimentos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Experimentos());
        }

        private void btnPracticas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio1.Practicas());
        }

        
    }
}
