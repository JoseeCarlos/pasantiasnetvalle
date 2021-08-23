using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ENCiudad
/// </summary>
[DataContract]
public class Ciudad
{
   

    [DataMember]
    public int IdSedeAcademica { get; set; }
    [DataMember]
    public string NombreSede { get; set; }

    public Ciudad()
    {

    }
    public Ciudad(int idSedeAcademica, string nombreSede)
    {
        IdSedeAcademica = idSedeAcademica;
        NombreSede = nombreSede;
    }


}