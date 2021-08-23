using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ENDirectorCarrera
/// </summary>
[DataContract]
public class ENDirectorCarrera
{
    [DataMember]
    public string Id_DirectorCarrera { get; set; }
    [DataMember]
    public string Id_Carrera { get; set; }
    [DataMember]
    public string Id_Emp { get; set; }
    [DataMember]
    public string Estado { get; set; }
    [DataMember]
    public DateTime FechaRegistro { get; set; }
    [DataMember]
    public DateTime FechaModificacion { get; set; }

    public ENDirectorCarrera()
    {
        Id_DirectorCarrera = string.Empty;
        Id_Carrera = string.Empty;
        Id_Emp = string.Empty;
        Estado = string.Empty;
        FechaRegistro = DateTime.MinValue;
        FechaModificacion = DateTime.MinValue;

    }
}