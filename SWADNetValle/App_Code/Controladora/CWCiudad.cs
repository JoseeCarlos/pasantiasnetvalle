using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CWCiudad
/// </summary>
public class CWCiudad
{
    private ADWCiudad adwCiudad;
    public CWCiudad()
    {
        adwCiudad = new ADWCiudad();
    }
    public List<ENCiudad> Obtener_NCiudad()
    {
        ENCiudad enCiudad = new ENCiudad();
        List<ENCiudad> lstNCiudad = new List<ENCiudad>();
        DTONCiudad dtoNCiudad = adwCiudad.Obtener_NCiudad();
        foreach (DTONCiudad.WCiudadRow drWCiudad in dtoNCiudad.WCiudad.Rows)
        {
            enCiudad = new ENCiudad();
            enCiudad.Id_Ciudad = drWCiudad.Id_Ciudad;
            enCiudad.Id_Emp = drWCiudad.Id_Emp;
            enCiudad.NombreCiudad = drWCiudad.NombreCiudad;
            enCiudad.FechaRegistro = drWCiudad.FechaRegistro;
            enCiudad.FechaModificacion = drWCiudad.FechaModificacion;
            enCiudad.Estado = drWCiudad.Estado;
            lstNCiudad.Add(enCiudad);
        }
        return lstNCiudad;
    }

    public ENCiudad Obtener_NCiudad_Id_Ciudad(string Id_Ciudad)
    {
        ENCiudad enCiudad = new ENCiudad();
        DTONCiudad dtoNCiudad = adwCiudad.Obtener_NCiudad_Id_Ciudad(Id_Ciudad);
        foreach (DTONCiudad.WCiudadRow drWCiudad in dtoNCiudad.WCiudad.Rows)
        {
            enCiudad = new ENCiudad();
            enCiudad.Id_Ciudad = drWCiudad.Id_Ciudad;
            enCiudad.Id_Emp = drWCiudad.Id_Emp;
            enCiudad.NombreCiudad = drWCiudad.NombreCiudad;
            enCiudad.FechaRegistro = drWCiudad.FechaRegistro;
            enCiudad.FechaModificacion = drWCiudad.FechaModificacion;
            enCiudad.Estado = drWCiudad.Estado;
        }
        return enCiudad;
    }
}