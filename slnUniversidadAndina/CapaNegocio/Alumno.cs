﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Alumno
    {
        //Atributos
        private string apellidos;
        private string nombres;
        private int edad;
        private string lugarNacimiento;
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
        public string LugarNacimiento
        {
            get { return lugarNacimiento; }
            set { lugarNacimiento = value; }
        }
            
        // Metodos u operaciones
        public string Estudiar()
        {
            return "No se ha implementado el metodo";
        }
        public string Trabajar()
        {
            return "No se ha implementado el metodo";
        }
        public string AprobarExamen()
        {
            return "No se ha implementado el metodo";
        }
    }
}
