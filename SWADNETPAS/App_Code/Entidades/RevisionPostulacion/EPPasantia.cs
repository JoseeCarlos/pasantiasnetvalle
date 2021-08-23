﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EPPasantia
/// </summary>
public class EPPasantia
{
    [DataMember]
    public string NombreResposable { get; set; }
    [DataMember]
    public string CargoResposable { get; set; }
    [DataMember]
    public string NombreInstitucion { get; set; }
    [DataMember]
    public string DireccionInstitucion { get; set; }
    [DataMember]
    public string NombreModalidad { get; set; }
    [DataMember]
    public string HorasPasantia { get; set; }
    public EPPasantia()
    {
        NombreResposable = string.Empty;
        CargoResposable = string.Empty;
        NombreInstitucion = string.Empty;
        DireccionInstitucion = string.Empty;
        NombreModalidad = string.Empty;
        HorasPasantia = string.Empty;
    }
}