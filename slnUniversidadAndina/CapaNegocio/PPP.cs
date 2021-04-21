using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PPP
    {
        //Atributos
        private string empresa;
        private int nroMeses;
        private string profesion;
        private string area;
        
        //Propiedades
        public string Empresa
        {
            get { return empresa; } 
            set { empresa = value; } 
        }
        public int NroMeses
        {
            get { return nroMeses; }
            set { nroMeses = value; }
        }
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }
        public string Area
        {
            get { return area; }
            set { area = value; }
        }

        // Metodos u operaciones
        public string GanarExperiencia()
        {
            return "No se ha implementado el metodo";
        }
        public string Aprender()
        {
            return "No se ha implementado el metodo";
        }
        public string AplicarConocimientos()
        {
            return "No se ha implementado el metodo";
        }
    }
}
