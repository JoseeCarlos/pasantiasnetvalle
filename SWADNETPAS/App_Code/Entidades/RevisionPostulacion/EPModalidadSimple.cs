using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EPModalidadSimple
/// </summary>

[DataContract]
public class EPModalidadSimple
{
    [DataMember]
    public string Id_Modalidad { get; set; }
    [DataMember]
    public string NombreModalidad { get; set; }
    [DataMember]
    public string Id_Emp { get; set; }
    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaModificacion { get; set; }

    public EPModalidadSimple()
    {
        Id_Modalidad = string.Empty;
        NombreModalidad = string.Empty;
        Id_Emp = string.Empty;
        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
}