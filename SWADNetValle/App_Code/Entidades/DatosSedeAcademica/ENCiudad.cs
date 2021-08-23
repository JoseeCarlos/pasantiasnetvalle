using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ENCiudad
/// </summary>
[DataContract]
public class ENCiudad
{
    [DataMember]
    public string Id_Ciudad { get; set; }
    [DataMember]
    public string NombreCiudad { get; set; }
    [DataMember]
    public string Id_Emp { get; set; }
    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaModificacion { get; set; }
    public ENCiudad()
    {
        Id_Ciudad = string.Empty;
        NombreCiudad = string.Empty;
        Id_Emp = string.Empty;
        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;


    }
}