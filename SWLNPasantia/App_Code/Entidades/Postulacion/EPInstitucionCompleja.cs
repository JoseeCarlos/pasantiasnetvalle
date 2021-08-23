using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EPInstitucionCompleja
/// </summary>

[DataContract]
public class EPInstitucionCompleja
{
    [DataMember]
    public string Id_Institucion { get; set; }
    [DataMember]
    public string NombreResponsable { get; set; }
    [DataMember]
    public string PrimerApellidoResponsable { get; set; }
    [DataMember]
    public string SegundoApellidoResponsable { get; set; }
    [DataMember]
    public string CargoResponsable { get; set; }
    [DataMember]
    public string NombreInstitucion { get; set; }
    [DataMember]
    public string DireccionInstitucion { get; set; }
    [DataMember]
    public string TelefonoInstitucion { get; set; }
    [DataMember]
    public string CorreoInstitucion { get; set; }
    [DataMember]
    public string Id_Ciudad { get; set; }
    [DataMember]
    public string NombreCiudad { get; set; }
    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaModificacion { get; set; }


    public EPInstitucionCompleja()
    {
        Id_Institucion = string.Empty;
        NombreResponsable = string.Empty;
        PrimerApellidoResponsable = string.Empty;
        SegundoApellidoResponsable = string.Empty;
        CargoResponsable = string.Empty;
        NombreInstitucion = string.Empty;
        DireccionInstitucion = string.Empty;
        TelefonoInstitucion = string.Empty;
        CorreoInstitucion = string.Empty;
        Id_Ciudad = string.Empty;
        NombreCiudad = string.Empty;
        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
}