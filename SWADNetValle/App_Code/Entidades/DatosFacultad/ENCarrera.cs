using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ENCarrera
/// </summary>
[DataContract]
public class ENCarrera
{

    [DataMember]
    public string Id_Carrera { get; set; }
    [DataMember]
    public string NombreCarrera { get; set; }
    [DataMember]
    public string Id_Facultad { get; set; }
    [DataMember]
    public string Id_Emp { get; set; }
    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaModificacion { get; set; }

    public ENCarrera()
    {
        Id_Carrera = string.Empty;
        NombreCarrera = string.Empty;
        Id_Facultad = string.Empty;
        Id_Emp = string.Empty;
        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
}