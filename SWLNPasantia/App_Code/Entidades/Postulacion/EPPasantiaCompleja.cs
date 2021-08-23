using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EPPasantiaCompleja
/// </summary>
[DataContract]
public class EPPasantiaCompleja
{

    [DataMember]
    public string Id_Pasantia { get; set; }
    [DataMember]
    public string Id_Postulacion { get; set; }

    /// ////////////ESTUDIANTE
    [DataMember]
    public string Id_Estudiante { get; set; }

    [DataMember]
    public string Nombres { get; set; }
    [DataMember]
    public string PrimerApellido { get; set; }

    [DataMember]
    public string SegundoApellido { get; set; }

    [DataMember]
    public string NombreCompleto { get; set; }


    /// ////////////MODALIDAD
    [DataMember]
    public string Id_Modalidad { get; set; }
    [DataMember]
    public string NombreModalidad { get; set; }


    /// ////////////HORARIO
    [DataMember]
    public string ID_Horario { get; set; }
    [DataMember]
    public string CantidadHoras { get; set; }


    /// ////////////INSTITUCION
    [DataMember]
    public string Id_Institucion { get; set; }
    [DataMember]
    public string NombreInstitucion { get; set; }


    [DataMember]
    public DateTime FechaInicioPasantia { get; set; }

    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaModificacion { get; set; }



    public EPPasantiaCompleja()
    {

        Id_Pasantia = string.Empty;
        Id_Postulacion = string.Empty;
        Id_Estudiante = string.Empty;
        Nombres = string.Empty;
        PrimerApellido = string.Empty;
        SegundoApellido = string.Empty;
        Id_Modalidad = string.Empty;
        NombreModalidad = string.Empty;
        ID_Horario = string.Empty;
        CantidadHoras = string.Empty;
        Id_Institucion = string.Empty;
        NombreInstitucion = string.Empty;
        FechaInicioPasantia = DateTime.MinValue;
        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;

    }
}