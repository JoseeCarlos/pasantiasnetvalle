using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EPInstitucionCompleja2
/// </summary>

[DataContract]
public class EPInstitucionCompleja2
{
    [DataMember]
    public string Id_Institucion { get; set; }

    [DataMember]
    public string NombreInstitucion { get; set; }



    public EPInstitucionCompleja2()
    {
        Id_Institucion = string.Empty;
        NombreInstitucion = string.Empty;

    }
}