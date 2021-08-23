using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ENFacultad
/// </summary>
[DataContract]
public class Facultad
{
   

    [DataMember]
    public int IdEstudiante { get; set; }
    [DataMember]
    public string NombreFacultad { get; set; }
    [DataMember]
    public string NombeCarrera { get; set; }

    public Facultad()
    {

    }
    public Facultad(int idEstudiante, string nombreFacultad, string nombeCarrera)
    {
        IdEstudiante = idEstudiante;
        NombreFacultad = nombreFacultad;
        NombeCarrera = nombeCarrera;
    }
    public Facultad(int idEstudiante, string nombreFacultad)
    {
        IdEstudiante = idEstudiante;
        NombreFacultad = nombreFacultad;
      
    }

}