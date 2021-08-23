using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EPReporte1
/// </summary>


[DataContract]
public class EPReporte1
{

    [DataMember]
    public string SedeAcademica { get; set; }
    [DataMember]
    public string Facultad { get; set; }
    [DataMember]
    public string Cantidad { get; set; }

    public EPReporte1()
    {
        SedeAcademica = string.Empty;

        Facultad = string.Empty;

        Cantidad = string.Empty;
    }
}