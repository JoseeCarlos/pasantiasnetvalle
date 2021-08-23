using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CWFacultad
/// </summary>
public class CWFacultad
{
    private ADWFacultad adwFacultad;
    public CWFacultad()
    {
        adwFacultad = new ADWFacultad();
    }

    public List<ENFacultad> Obtener_NFacultad()
    {
        ENFacultad enFacultad = new ENFacultad();
        List<ENFacultad> lstNFacultad = new List<ENFacultad>();
        DTONFacultad dtoNFacultad = adwFacultad.Obtener_NFacultad();
        foreach (DTONFacultad.WFacultadRow drWFacultad in dtoNFacultad.WFacultad.Rows)
        {
            enFacultad = new ENFacultad();
            enFacultad.Id_Facultad = drWFacultad.Id_Facultad;
            enFacultad.NombreFacultad = drWFacultad.NombreFacultad;
            enFacultad.Id_Emp = drWFacultad.Id_Emp;

            enFacultad.FechaRegistro = drWFacultad.FechaRegistro;
            enFacultad.FechaModificacion = drWFacultad.FechaModificacion;
            enFacultad.Estado = drWFacultad.Estado;
            lstNFacultad.Add(enFacultad);
        }
        return lstNFacultad;
    }


    public ENFacultad Obtener_NFacultad_Id_Facultad(string Id_Facultad)
    {
        ENFacultad enFacultad = new ENFacultad();
        DTONFacultad dtoNFacultad = adwFacultad.Obtener_NFacultad_Id_Facultad(Id_Facultad);
        foreach (DTONFacultad.WFacultadRow drWFacultad in dtoNFacultad.WFacultad.Rows)
        {
            enFacultad = new ENFacultad();
            enFacultad.Id_Facultad = drWFacultad.Id_Facultad;
            enFacultad.NombreFacultad = drWFacultad.NombreFacultad;

            enFacultad.Id_Emp = drWFacultad.Id_Emp;
            enFacultad.Estado = drWFacultad.Estado;
            enFacultad.FechaRegistro = drWFacultad.FechaRegistro;
            enFacultad.FechaModificacion = drWFacultad.FechaModificacion;

        }
        return enFacultad;
    }

    
}