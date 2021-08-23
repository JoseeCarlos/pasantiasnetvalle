using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EPPostulacionSimple
/// </summary>
[DataContract]
public class EPPostulacionSimple
{
    [DataMember]
    public string Id_Postulacion { get; set; }
    [DataMember]
    public string Id_Estudiante { get; set; }
    [DataMember]
    public string Id_Institucion { get; set; }
    [DataMember]
    public string Id_Modalidad { get; set; }
    [DataMember]
    public string Id_SedeAcademica { get; set; }
    [DataMember]
    public DateTime FechaAceptacion { get; set; }
    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaModificacion { get; set; }

    public EPPostulacionSimple()
    {
        Id_Postulacion = string.Empty;
        Id_Estudiante = string.Empty;
        Id_Institucion = string.Empty;
        Id_Modalidad = string.Empty;
        Id_SedeAcademica = string.Empty;
        FechaAceptacion = DateTime.MinValue;
        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
}