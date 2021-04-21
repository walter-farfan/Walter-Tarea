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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }
        
        CapaNegocio.Notas Notas1 = new CapaNegocio.Notas();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string curso = txtCurso.Text;
            string docente = txtDocente.Text;
            string tipo = txtTipo.Text;
            int tamaño = int.Parse(txtTamaño.Text);
            Notas1.Curso = curso;
            Notas1.Docente = docente;
            Notas1.Tipo = tipo;
            Notas1.Tamaño = tamaño;
            MessageBox.Show("Se han registrado correctamente los datos de Notas 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string curso = Notas1.Curso;
            string docente = Notas1.Docente;
            string tipo = Notas1.Tipo;
            int tamaño = Notas1.Tamaño;
            MessageBox.Show("Curso: " + curso + " Docente: " + docente + " Tipo: " + tipo + " Tamaño: " + tamaño);
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Notas1.Aprobar());
        }

        private void btnDesaprobar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Notas1.Desaprobar());
        }
    }
}
