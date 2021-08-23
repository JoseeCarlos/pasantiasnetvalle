using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ENEmpleadoSimple
/// </summary>
[DataContract]
public class ENEmpleadoSimple
{

    [DataMember]
    public string Id_Empleado { get; set; }
    [DataMember]
    public string Nombres { get; set; }
    [DataMember]
    public string PrimerApellido { get; set; }
    [DataMember]
    public string SegundoApellido { get; set; }
    [DataMember]
    public string Id_Cargo { get; set; }
    [DataMember]
    public string Id_Emp { get; set; }
    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaModificacion { get; set; }
    public ENEmpleadoSimple()
    {

        Id_Empleado = string.Empty;
        Nombres = string.Empty;
        PrimerApellido = string.Empty;
        SegundoApellido = string.Empty;
        Id_Cargo = string.Empty;
        Id_Emp = string.Empty;
        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;

    }
}