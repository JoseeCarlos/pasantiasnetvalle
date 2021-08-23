using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ENSedeAcademica
/// </summary>
[DataContract]
public class ENSedeAcademica
{
    [DataMember]
    public string Id_SedeAcademica { get; set; }
    [DataMember]
    public string Id_Ciudad { get; set; }
    [DataMember]
    public string Id_Emp { get; set; }
    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaModificacion { get; set; }

    public ENSedeAcademica()
    {

        Id_SedeAcademica = string.Empty;
        Id_Ciudad = string.Empty;
        Id_Emp = string.Empty;
        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;


    }
}