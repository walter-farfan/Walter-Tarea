using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Docente
    {
        //atributos
        private string dni;
        private string apellidos;
        private string nombres;
        private DateTime fechaNacimiento;
        private string profesion;

        //propiedades
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Apellidos
        {
            get { return apellidos; } // lectura del atributo
            set { apellidos = value; } //Escritura del atributo
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }

        //metodos
        public string Enseñar()
        {
            return "No se ha implementado el metodo";
        }
        public string Matricular()
        {
            return "No se ha implementado el metodo";
        }
        public string Aprobar()
        {
            return "No se ha implementado el metodo";
        }
        public string Desaprobar()
        {
            return "No se ha implementado el metodo";
        }

    }
}
