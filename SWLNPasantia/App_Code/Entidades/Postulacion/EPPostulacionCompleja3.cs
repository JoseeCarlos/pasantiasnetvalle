using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;



/// <summary>
/// Descripción breve de EPPostulacionCompleja
/// </summary>



[DataContract]
public class EPPostulacionCompleja3
{
    [DataMember]
    public string Id_Postulacion { get; set; }
    [DataMember]
    public string Id_Estudiante { get; set; }



    [DataMember]
    public string NombreCompleto { get; set; }
    [DataMember]
    public string NombreCarrera { get; set; }



    [DataMember]
    public string NombreInstitucion { get; set; }
    [DataMember]
    public string Correo { get; set; }



    [DataMember]
    public DateTime FechaRegistro { get; set; }





    public EPPostulacionCompleja3()
    {



        Id_Postulacion = string.Empty;
        Id_Estudiante = string.Empty;
        NombreCompleto = string.Empty;
        NombreCarrera = string.Empty;
        NombreInstitucion = string.Empty;
        Correo = string.Empty;
        FechaRegistro = DateTime.Now;
    }
}