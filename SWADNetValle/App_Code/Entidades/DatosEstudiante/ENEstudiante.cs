using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ENEstudiante
/// </summary>
[DataContract]
public class ENEstudiante
{

    [DataMember]
    public string Id_Estudiante { get; set; }
    [DataMember]
    public string Nombres { get; set; }
    [DataMember]
    public string PrimerApellido { get; set; }
    [DataMember]
    public string SegundoApellido { get; set; }
    [DataMember]
    public string CedulaIdentidad { get; set; }
    [DataMember]
    public string EmitidoEn { get; set; }
    [DataMember]
    public string Celular { get; set; }
    [DataMember]
    public string Telefono { get; set; }
    [DataMember]
    public string CorreoElectronico { get; set; }
    [DataMember]
    public string Id_Carrera { get; set; }
    [DataMember]
    public string Id_SedeAcademica { get; set; }
    [DataMember]
    public string Id_Emp { get; set; }
    [DataMember]
    public string Estado { get; set; }

    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaModificacion { get; set; }
    public ENEstudiante()
    {
        Id_Estudiante = string.Empty;
        Nombres = string.Empty;
        PrimerApellido = string.Empty;
        SegundoApellido = string.Empty;
        CedulaIdentidad = string.Empty;
        EmitidoEn = string.Empty;
        Celular = string.Empty;
        Telefono = string.Empty;
        CorreoElectronico = string.Empty;
        Id_Carrera = string.Empty;
        Id_SedeAcademica = string.Empty;
        Id_Emp = string.Empty;
        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
}