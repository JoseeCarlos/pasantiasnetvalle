using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAPasantia.ReportesJose
{
    public class Pasantia
    {

        public int Idpasantia { get; set; }

        public int idEstudiante { get; set; }

        public int idSedeAcademica { get; set; }

        public string NombreModalida { get; set; }


        public Pasantia()
        {

        }

        public Pasantia(int idpasantia, int idEstudiante, int idSedeAcademica)
        {
            Idpasantia = idpasantia;
            this.idEstudiante = idEstudiante;
            this.idSedeAcademica = idSedeAcademica;
        }

        public Pasantia(int idpasantia, int idEstudiante, int idSedeAcademica, string nombreModalida)
        {
            Idpasantia = idpasantia;
            this.idEstudiante = idEstudiante;
            this.idSedeAcademica = idSedeAcademica;
            NombreModalida = nombreModalida;
        }
    }
}