using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EPPostulacionCompleja2
/// </summary>
[DataContract]
public class EPPostulacionCompleja2
{

    [DataMember]
    public string Id_Postulacion { get; set; }
    [DataMember]
    public string Id_Estudiante { get; set; }
    [DataMember]
    public string Nombres { get; set; }
    [DataMember]
    public string Apellidos { get; set; }
    [DataMember]
    public string CedulaIdentidad { get; set; }

    [DataMember]
    public string EmitidoEn { get; set; }

    [DataMember]
    public string Celular { get; set; }

    [DataMember]
    public string Telefono { get; set; }
    [DataMember]
    public string Correo { get; set; }

    [DataMember]
    public string Id_Institucion { get; set; }
    [DataMember]
    public string NombreInstitucion { get; set; }
    [DataMember]
    public string NombreEncargado { get; set; }
    [DataMember]
    public string Cargo { get; set; }
    [DataMember]
    public string DireccionInstitucion { get; set; }
    [DataMember]
    public string TelefonoInstitucion { get; set; }
    [DataMember]
    public string CiudadInstitucion { get; set; }
    [DataMember]
    public string CorreoInstitucion { get; set; }


    public EPPostulacionCompleja2()
    {
        Id_Postulacion = string.Empty;
        Id_Estudiante = string.Empty;
        Nombres = string.Empty;
        Apellidos = string.Empty;
        CedulaIdentidad = string.Empty;
        EmitidoEn = string.Empty;
        Celular = string.Empty;
        Telefono = string.Empty;
        Correo = string.Empty;
        Id_Institucion = string.Empty;
        NombreInstitucion = string.Empty;
        NombreEncargado = string.Empty;
        Cargo = string.Empty;
        DireccionInstitucion = string.Empty;
        TelefonoInstitucion = string.Empty;
        CiudadInstitucion = string.Empty;
        CorreoInstitucion = string.Empty;
    }
}