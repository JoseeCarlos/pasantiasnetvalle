using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAPasantia.Reportes
{
    public class Reporte1
    {
        public string NombreSede { get; set; }
        public string NombreFacultad { get; set; }
        public int Total { get; set; }
        public string NombreCarrera { get; set; }

        public string Modalidad { get; set; }

        public Reporte1()
        {

        }

        public Reporte1(string nombreSede, string nombreFacultad, int total)
        {
            NombreSede = nombreSede;
            NombreFacultad = nombreFacultad;
            Total = total;
        }

        public Reporte1(string nombreSede, string nombreFacultad, int total, string nombreCarrera)
        {
            NombreSede = nombreSede;
            NombreFacultad = nombreFacultad;
            Total = total;
            NombreCarrera = nombreCarrera;
        }

        public Reporte1(string nombreSede, string nombreFacultad, int total, string nombreCarrera, string modalidad)
        {
            NombreSede = nombreSede;
            NombreFacultad = nombreFacultad;
            Total = total;
            NombreCarrera = nombreCarrera;
            Modalidad = modalidad;
        }
    }
}