using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EPEstudianteCompleja
/// </summary>
public class EPEstudianteCompleja
{

    [DataMember]
    public string Id_Estudiante { get; set; }
    [DataMember]
    public string NombreCompleto { get; set; }
    [DataMember]
    public string CarnetIdentidad { get; set; }
    [DataMember]
    public string NombreCarrera { get; set; }



    public EPEstudianteCompleja()
    {
        Id_Estudiante = string.Empty;
        NombreCompleto = string.Empty;
        CarnetIdentidad = string.Empty;
        NombreCarrera = string.Empty;
    }
}