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
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        //instanciar la clase a travez de un objeto
        //declaracion de variables globales
        CapaNegocio.Alumno alumno1 = new CapaNegocio.Alumno();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //leer datos del formulario
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string lugarNacimiento = txtLugarNacimiento.Text;
            alumno1.Apellidos = apellidos;
            alumno1.Nombres = nombres;
            alumno1.Edad = edad;
            alumno1.LugarNacimiento = lugarNacimiento;
            MessageBox.Show("Se han registrado correctamente los datos de Alumno 1");

        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //mostrar los datos almacenados en el objeto 1
            string apellidos = alumno1.Apellidos;
            string nombres = alumno1.Nombres;
            int edad = alumno1.Edad;
            string lugarNacimiento = alumno1.LugarNacimiento;
            MessageBox.Show("Apellidos: " + apellidos + " Nombres: " + nombres + " Edad: " + edad + " LugarNacimiento: " + lugarNacimiento);
        }

        private void btnEstudiar_Click(object sender, EventArgs e)
        {
            //mostrar el metodo estudiar
            MessageBox.Show(alumno1.Estudiar());
        }

        private void btnTrabajar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno1.Trabajar());
        }

        private void btnAprobarExamen_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno1.AprobarExamen());
        }
    }
}
