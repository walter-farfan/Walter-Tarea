using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Notas
    {
        //Atributos
        private string curso;
        private string docente;
        private string tipo;
        private int tamaño;
        //Propiedades
        public string Curso
        {
            get { return curso; } 
            set { curso = value; }   
        }
        public string Docente
        {
            get { return docente; }
            set { docente = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public int Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }
        // Metodos u operaciones
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
