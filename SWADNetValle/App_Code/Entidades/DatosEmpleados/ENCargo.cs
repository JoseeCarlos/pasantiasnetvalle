using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ENCargo
/// </summary>
[DataContract]
public class ENCargo
{

    [DataMember]
    public string Id_Cargo { get; set; }
    [DataMember]
    public string NombreCargo { get; set; }
    [DataMember]
    public string Id_Emp { get; set; }
    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaModificacion { get; set; }
    public ENCargo()
    {
        Id_Cargo = string.Empty;
        NombreCargo = string.Empty;
        Id_Emp = string.Empty;
        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
}