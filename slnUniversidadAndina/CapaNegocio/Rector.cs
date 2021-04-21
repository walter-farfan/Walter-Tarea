using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Rector
    {
        //Atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private string lugarNacimiento;
        private string profesion;
        //Propiedades
        public string Apellidos
        {
            get { return apellidos; } 
            set { apellidos = value; } 
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string LugarNacimiento
        {
            get { return lugarNacimiento; }
            set { lugarNacimiento = value; }
        }
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        // Metodos u operaciones
        public string Administrar()
        {
            return "No se ha implementado el metodo";
        }
        public string DarDeclaraciones()
        {
            return "No se ha implementado el metodo";
        }
        public string LiderarUniversidad()
        {
            return "No se ha implementado el metodo";
        }
    }
}
