using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CPInstitucion
/// </summary>
public class CPInstitucion
{
    private ADPInstitucion adpInstitucion;
    public CPInstitucion()
    {
        adpInstitucion = new ADPInstitucion();
    }

    public void Actualizar_PInstitucion(EPInstitucionSimple epInstitucionSimple)
    {
        adpInstitucion.Actualizar_PInstitucion(epInstitucionSimple);
    }

    public void Adicionar_PInstitucion(EPInstitucionSimple epInstitucionSimple)
    {
        adpInstitucion.Adicionar_PInstitucion(epInstitucionSimple);
    }

    public List<EPInstitucionSimple> Obtener_PInstitucion()
    {
        EPInstitucionSimple epInstitucionSimple = new EPInstitucionSimple();
        List<EPInstitucionSimple> lstPInstitucion = new List<EPInstitucionSimple>();
        DTOPInstitucion dtoPInstitucion = adpInstitucion.Obtener_PInstitucion();
        foreach (DTOPInstitucion.PInstitucionRow drPInstitucion in dtoPInstitucion.PInstitucion.Rows)
        {
            epInstitucionSimple = new EPInstitucionSimple();
            epInstitucionSimple.Id_Institucion = drPInstitucion.Id_Institucion;
            epInstitucionSimple.NombreResponsable = drPInstitucion.NombreResponsable;
            epInstitucionSimple.PrimerApellidoResponsable = drPInstitucion.PrimerApellidoResponsable;
            epInstitucionSimple.SegundoApellidoResponsable = drPInstitucion.SegundoApellidoResponsable;
            epInstitucionSimple.CargoResponsable = drPInstitucion.CargoResponsable;
            epInstitucionSimple.NombreInstitucion = drPInstitucion.NombreInstitucion;
            epInstitucionSimple.DireccionInstitucion = drPInstitucion.DireccionInstitucion;
            epInstitucionSimple.TelefonoInstitucion = drPInstitucion.TelefonoInstitucion;
            epInstitucionSimple.CorreoInstitucion = drPInstitucion.CorreoInstitucion;
            epInstitucionSimple.Id_Ciudad = drPInstitucion.Id_Ciudad;
            epInstitucionSimple.Estado = drPInstitucion.Estado;
            epInstitucionSimple.FechaRegistro = drPInstitucion.FechaRegistro;
            epInstitucionSimple.FechaModificacion = drPInstitucion.FechaModificacion;
            lstPInstitucion.Add(epInstitucionSimple);
        }
        return lstPInstitucion;
    }

    public EPInstitucionSimple Obtener_PInstitucion_Id_Institucion(string Id_Institucion)
    {
        EPInstitucionSimple epInstitucionSimple = new EPInstitucionSimple();
        DTOPInstitucion dtoPInstitucion = adpInstitucion.Obtener_PInstitucion_Id_Institucion(Id_Institucion);
        foreach (DTOPInstitucion.PInstitucionRow drPInstitucion in dtoPInstitucion.PInstitucion.Rows)
        {
            epInstitucionSimple = new EPInstitucionSimple();
            epInstitucionSimple.Id_Institucion = drPInstitucion.Id_Institucion;
            epInstitucionSimple.NombreResponsable = drPInstitucion.NombreResponsable;
            epInstitucionSimple.PrimerApellidoResponsable = drPInstitucion.PrimerApellidoResponsable;
            epInstitucionSimple.SegundoApellidoResponsable = drPInstitucion.SegundoApellidoResponsable;
            epInstitucionSimple.CargoResponsable = drPInstitucion.CargoResponsable;
            epInstitucionSimple.NombreInstitucion = drPInstitucion.NombreInstitucion;
            epInstitucionSimple.DireccionInstitucion = drPInstitucion.DireccionInstitucion;
            epInstitucionSimple.TelefonoInstitucion = drPInstitucion.TelefonoInstitucion;
            epInstitucionSimple.CorreoInstitucion = drPInstitucion.CorreoInstitucion;
            epInstitucionSimple.Id_Ciudad = drPInstitucion.Id_Ciudad;
            epInstitucionSimple.Estado = drPInstitucion.Estado;
            epInstitucionSimple.FechaRegistro = drPInstitucion.FechaRegistro;
            epInstitucionSimple.FechaModificacion = drPInstitucion.FechaModificacion;
        }
        return epInstitucionSimple;
    }


    public EPInstitucionSimple Obtener_PInstitucion_NombreInstitucion(string NombreInstitucion)
    {
        EPInstitucionSimple epInstitucionSimple = new EPInstitucionSimple();
        DTOPInstitucion dtoPInstitucion = adpInstitucion.Obtener_PInstitucion_Id_Institucion(NombreInstitucion);
        foreach (DTOPInstitucion.PInstitucionRow drPInstitucion in dtoPInstitucion.PInstitucion.Rows)
        {
            epInstitucionSimple = new EPInstitucionSimple();
            epInstitucionSimple.Id_Institucion = drPInstitucion.Id_Institucion;
            epInstitucionSimple.NombreResponsable = drPInstitucion.NombreResponsable;
            epInstitucionSimple.PrimerApellidoResponsable = drPInstitucion.PrimerApellidoResponsable;
            epInstitucionSimple.SegundoApellidoResponsable = drPInstitucion.SegundoApellidoResponsable;
            epInstitucionSimple.CargoResponsable = drPInstitucion.CargoResponsable;
            epInstitucionSimple.NombreInstitucion = drPInstitucion.NombreInstitucion;
            epInstitucionSimple.DireccionInstitucion = drPInstitucion.DireccionInstitucion;
            epInstitucionSimple.TelefonoInstitucion = drPInstitucion.TelefonoInstitucion;
            epInstitucionSimple.CorreoInstitucion = drPInstitucion.CorreoInstitucion;
            epInstitucionSimple.Id_Ciudad = drPInstitucion.Id_Ciudad;
            epInstitucionSimple.Estado = drPInstitucion.Estado;
            epInstitucionSimple.FechaRegistro = drPInstitucion.FechaRegistro;
            epInstitucionSimple.FechaModificacion = drPInstitucion.FechaModificacion;
        }
        return epInstitucionSimple;
    }
}