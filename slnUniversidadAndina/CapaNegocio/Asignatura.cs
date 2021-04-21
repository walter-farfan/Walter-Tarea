using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        //Atributos
        private string nombre;
        private string profesor;
        private int unidades;
        private int creditos;
        //Propiedades
        public string Nombre
        {
            get { return nombre; } // lectura del atributo
            set { nombre = value; } //Escritura del atributo
        }

        public string Profesor
        {
            get { return profesor; }
            set { profesor = value; }
        }
        public int Unidades
        {
            get { return unidades; }
            set { unidades = value; }
        }
        public int Creditos
        {
            get { return creditos; }
            set { creditos = value; }
        }
        // Metodos u operaciones
        public string Tareas()
        {
            return "No se ha implementado el metodo";
        }
        public string Exposiciones()
        {
            return "No se ha implementado el metodo";
        }
        public string Examenes()
        {
            return "No se ha implementado el metodo";
        }

    }
}
