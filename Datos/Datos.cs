using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReachSystem.Datos
{
    public class Datos
    {
    }
    public class Lineas
    {
        public Double Precio { get; set; }
        public string Plan { get; set; }
        public string NombreCli { get; set; }
        public string NombreProd { get; set; }
        public int Cedula { get; set; }
        public int CedulaTomador { get; set; }
        //public int Certificado { get; set; }
        public string Relacion { get; set; }
        public string Genero { get; set; }
        //public string Telefono { get; set; }
        public System.DateTime FechaNac { get; set; }
        //public string Clase { get; set; }
        //public string Idioma { get; set; }
        //public string Archivo { get; set; }

    }
}