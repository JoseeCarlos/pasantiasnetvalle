using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ENFacultad
/// </summary>
[DataContract]
public class ENFacultad
{
    [DataMember]
    public string Id_Facultad { get; set; }
    [DataMember]
    public string NombreFacultad { get; set; }
    [DataMember]
    public string Id_Emp { get; set; }
    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaModificacion { get; set; }
    public ENFacultad()
    {
        Id_Facultad = string.Empty;
        NombreFacultad = string.Empty;
        Id_Emp = string.Empty;
        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
}