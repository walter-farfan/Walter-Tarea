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
    public partial class frmRector : Form
    {
        public frmRector()
        {
            InitializeComponent();
        }
        CapaNegocio.Rector rector1 = new CapaNegocio.Rector();

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text;
            string nombres = txtNombres.Text;
            int edad = int.Parse(txtEdad.Text);
            string lugarNacimiento = txtLugarNacimiento.Text;
            string profesion = txtProfesion.Text;
            rector1.Apellidos = apellidos;
            rector1.Nombres = nombres;
            rector1.Edad = edad;
            rector1.LugarNacimiento = lugarNacimiento;
            rector1.Profesion = profesion;
            MessageBox.Show("Se han registrado correctamente los datos de Rector 1");
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string apellidos = rector1.Apellidos;
            string nombres = rector1.Nombres;
            int edad = rector1.Edad;
            string lugarNacimiento = rector1.LugarNacimiento;
            string profesion = rector1.Profesion;
            MessageBox.Show("Apellidos: " + apellidos + " Nombres: " + nombres + " Edad: " + edad + " Lugar Nacimiento: " + lugarNacimiento + " Profesion: " + profesion);
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.Administrar());
        }

        private void btnDarDeclaraciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.DarDeclaraciones());
        }

        private void btnLiderarUniversidad_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector1.LiderarUniversidad());
        }
    }
}
