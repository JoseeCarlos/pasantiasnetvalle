using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EPEstudianteDirectorCarreraCompleja
/// </summary>
[DataContract]
public class EPEstudianteDirectorCarreraCompleja
{

    [DataMember]
    public string Id_Estudiante { get; set; }
    [DataMember]
    public string NombreCompleto { get; set; }
    [DataMember]
    public string CarnetIdentidad { get; set; }
    [DataMember]
    public string NombreCarrera { get; set; }
    [DataMember]
    public string NombreCompletoDirector { get; set; }
    [DataMember]
    public string CargoDirectorCarrera { get; set; }
    [DataMember]
    public string NombreFacultad { get; set; }



    public EPEstudianteDirectorCarreraCompleja()
    {
        Id_Estudiante = string.Empty;
        NombreCompleto = string.Empty;
        CarnetIdentidad = string.Empty;
        NombreCarrera = string.Empty;
        NombreCompletoDirector = string.Empty;
        CargoDirectorCarrera = string.Empty;
        NombreFacultad = string.Empty;
    }
}