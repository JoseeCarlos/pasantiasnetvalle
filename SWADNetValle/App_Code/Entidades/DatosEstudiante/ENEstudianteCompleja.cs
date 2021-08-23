using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ENEstudianteCompleja
/// </summary>
[DataContract]
public class ENEstudianteCompleja
{

    [DataMember]
    public string Id_Estudiante { get; set; }
    [DataMember]
    public string NombreCompleto { get; set; }

    [DataMember]
    public string CedulaIdentidad { get; set; }

    [DataMember]
    public string Id_Carrera { get; set; }
    [DataMember]
    public string NombreCarrera { get; set; }


    public ENEstudianteCompleja()
    {
        Id_Estudiante = string.Empty;
        NombreCompleto = string.Empty;

        CedulaIdentidad = string.Empty;

        Id_Carrera = string.Empty;
        NombreCarrera = string.Empty;

    }
}