using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EPPasantiaSimple
/// </summary>
[DataContract]
public class EPPasantiaSimple
{

    [DataMember]
    public string Id_Pasantia { get; set; }
    [DataMember]
    public string Id_Postulacion { get; set; }
    [DataMember]
    public string Horas { get; set; }
    [DataMember]
    public DateTime FechaInicioPasantia { get; set; }

    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaModificacion { get; set; }


    public EPPasantiaSimple()
    {

        Id_Pasantia = string.Empty;
        Id_Postulacion = string.Empty;
        Horas = string.Empty;
        FechaInicioPasantia = DateTime.MinValue;
        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
}