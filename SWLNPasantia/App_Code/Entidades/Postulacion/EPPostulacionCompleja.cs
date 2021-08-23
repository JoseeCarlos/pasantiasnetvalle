using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;



/// <summary>
/// Descripción breve de EPPostulacionCompleja
/// </summary>



[DataContract]
public class EPPostulacionCompleja
{
    [DataMember]
    public string Id_Postulacion { get; set; }
    [DataMember]
    public string Id_Estudiante { get; set; }
    [DataMember]
    public string NombreCompleto { get; set; }
    [DataMember]
    public string Correo { get; set; }
    [DataMember]
    public string NombreCarrera { get; set; }
    [DataMember]
    public string Id_Institucion { get; set; }
    [DataMember]
    public string NombreInstitucion { get; set; }
    [DataMember]
    public string Id_Modalidad { get; set; }
    [DataMember]
    public string NombreModalidad { get; set; }
    [DataMember]
    public string Id_SedeAcademica { get; set; }
    [DataMember]
    public string NombreSedeAcademica { get; set; }
    [DataMember]
    public DateTime FechaAceptacion { get; set; }
    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaModificacion { get; set; }
    public EPPostulacionCompleja()
    {
        Id_Postulacion = string.Empty;
        Id_Estudiante = string.Empty;
        NombreCompleto = string.Empty;
        Correo = string.Empty;
        NombreCarrera = string.Empty;
        Id_Institucion = string.Empty;
        NombreInstitucion = string.Empty;
        Id_Modalidad = string.Empty;
        NombreModalidad = string.Empty;
        Id_SedeAcademica = string.Empty;
        NombreSedeAcademica = string.Empty;
        FechaAceptacion = DateTime.MinValue;
        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;
    }
}