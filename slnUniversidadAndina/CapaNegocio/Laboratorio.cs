using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
        //atributos
        private string nombreCurso;
        private string profesor;
        private string materiales;
        private string ubicacion;

        //propiedades
        public string NombreCurso
        {
            get { return nombreCurso; }
            set { nombreCurso = value; }
        }
        public string Profesor
        {
            get { return profesor; }
            set { profesor = value; }
        }
        public string Materiales
        {
            get { return materiales; }
            set { materiales = value; }
        }
        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
        //metodos
        public string Clases()
        {
            return "No se ha implementado el metodo";
        }
        public string Experimentos()
        {
            return "No se ha implementado el metodo";
        }
        public string Practicas()
        {
            return "No se ha implementado el metodo";
        }
        


    }
}
