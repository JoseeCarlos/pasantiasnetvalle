using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EPPostulacionSimple
/// </summary>
[DataContract]
public class PasantiasCompleja
{
    

    [DataMember]
    public int IdPasantia { get; set; }
    [DataMember]
    public int IdEstudiante { get; set; }
    [DataMember]
    public int IdSedeAcademica { get; set; }
    [DataMember]
    public string NombreModalidad { get; set; }

    public PasantiasCompleja()
    { 
    
    }
    public PasantiasCompleja(int idPasantia, int idEstudiante, int idSedeAcademica, string nombreModalidad)
    {
        IdPasantia = idPasantia;
        IdEstudiante = idEstudiante;
        IdSedeAcademica = idSedeAcademica;
        NombreModalidad = nombreModalidad;
    }
    public PasantiasCompleja(int idPasantia, int idEstudiante, int idSedeAcademica)
    {
        IdPasantia = idPasantia;
        IdEstudiante = idEstudiante;
        IdSedeAcademica = idSedeAcademica;
        
    }



}