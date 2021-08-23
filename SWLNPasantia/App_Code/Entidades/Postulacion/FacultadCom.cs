using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ENFacultad
/// </summary>
[DataContract]
public class FacultadCom
{
   

    [DataMember]
    public int IdEstudiante { get; set; }
    [DataMember]
    public string NombreFacultad { get; set; }
    [DataMember]
    public string NombeCarrera { get; set; }

    public FacultadCom()
    {

    }
    public FacultadCom(int idEstudiante, string nombreFacultad, string nombeCarrera)
    {
        IdEstudiante = idEstudiante;
        NombreFacultad = nombreFacultad;
        NombeCarrera = nombeCarrera;
    }
    public FacultadCom(int idEstudiante, string nombreFacultad)
    {
        IdEstudiante = idEstudiante;
        NombreFacultad = nombreFacultad;
      
    }

}