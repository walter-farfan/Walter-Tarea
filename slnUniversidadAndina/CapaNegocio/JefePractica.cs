using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class JefePractica
    {
        //Atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private string profesion;
        //Propiedades
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
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        // Metodos u operaciones
        public string ApruevaNotas()
        {
            return "No se ha implementado el metodo";
        }
        public string Explica()
        {
            return "No se ha implementado el metodo";
        }
        public string Califica()
        {
            return "No se ha implementado el metodo";
        }

    }
}
