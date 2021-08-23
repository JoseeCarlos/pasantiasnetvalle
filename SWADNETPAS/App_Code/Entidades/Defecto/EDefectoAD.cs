using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EDefectoAD
/// </summary>
public class EDefectoAD
{
    [DataMember]
    public string Servicio { get; set; }
    [DataMember]
    public string Clase { get; set; }
    [DataMember]
    public string Metodo { get; set; }
    [DataMember]
    public string Excepcion { get; set; }
    [DataMember]
    public string Mensaje { get; set; }
    public EDefectoAD()
    {
        Servicio = String.Empty;
        Clase = String.Empty;
        Metodo = String.Empty;
        Excepcion = String.Empty;
        Mensaje = String.Empty;
    }
}