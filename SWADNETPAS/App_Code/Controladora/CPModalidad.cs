using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CPModalidad
/// </summary>
public class CPModalidad
{
    private ADPModalidad adpModalidad;
    public CPModalidad()
    {
        adpModalidad = new ADPModalidad();
    }

    public void Actualizar_PModalidad(EPModalidadSimple epModalidadSimple)
    {
        adpModalidad.Actualizar_PModalidad(epModalidadSimple);
    }

    public void Adicionar_PModalidad(EPModalidadSimple epModalidadSimple)
    {
        adpModalidad.Adicionar_PModalidad(epModalidadSimple);
    }

    public List<EPModalidadSimple> Obtener_PModalidad()
    {
        EPModalidadSimple epModalidadSimple = new EPModalidadSimple();
        List<EPModalidadSimple> lstPModalidad = new List<EPModalidadSimple>();
        DTOPModalidad dtoPModalidad = adpModalidad.Obtener_PModalidad();
        foreach (DTOPModalidad.PModalidadRow drPModalidad in dtoPModalidad.PModalidad.Rows)
        {
            epModalidadSimple = new EPModalidadSimple();
            epModalidadSimple.Id_Modalidad = drPModalidad.Id_Modalidad;
            epModalidadSimple.NombreModalidad = drPModalidad.NombreModalidad;
            epModalidadSimple.Id_Emp = drPModalidad.Id_Emp;
            epModalidadSimple.Estado = drPModalidad.Estado;
            epModalidadSimple.FechaRegistro = drPModalidad.FechaRegistro;
            epModalidadSimple.FechaModificacion = drPModalidad.FechaModificacion;
            lstPModalidad.Add(epModalidadSimple);
        }
        return lstPModalidad;
    }

    public EPModalidadSimple Obtener_PModalidad_Id_Modalidad(string Id_Modalidad)
    {
        EPModalidadSimple epModalidadSimple = new EPModalidadSimple();
        DTOPModalidad dtoPModalidad = adpModalidad.Obtener_PModalidad_Id_Modalidad(Id_Modalidad);
        foreach (DTOPModalidad.PModalidadRow drPModalidad in dtoPModalidad.PModalidad.Rows)
        {
            epModalidadSimple = new EPModalidadSimple();
            epModalidadSimple.Id_Modalidad = drPModalidad.Id_Modalidad;
            epModalidadSimple.NombreModalidad = drPModalidad.NombreModalidad;
            epModalidadSimple.Id_Emp = drPModalidad.Id_Emp;
            epModalidadSimple.Estado = drPModalidad.Estado;
            epModalidadSimple.FechaRegistro = drPModalidad.FechaRegistro;
            epModalidadSimple.FechaModificacion = drPModalidad.FechaModificacion;
        }
        return epModalidadSimple;
    }
}