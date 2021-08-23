using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CPPasantia
/// </summary>
public class CPPasantia
{
    private ADPPasantia adpPasantia;

    public CPPasantia()
    {
        adpPasantia = new ADPPasantia();
    }

    public void Adicionar_PPasantia(EPPasantiaSimple epPasantiaSimple)
    {
        adpPasantia.Adicionar_PPasantia(epPasantiaSimple);
    }

    public void Actualizar_PPasantia(EPPasantiaSimple epPasantiaSimple)
    {
        adpPasantia.Actualizar_PPasantia(epPasantiaSimple);

    }
    public void Actualizar_PPasantia_FechaInicio(EPPasantiaSimple epPasantiaSimple)
    {
        adpPasantia.Actualizar_PPasantia_FechaInicio(epPasantiaSimple);

    }

    public List<EPPasantiaSimple> Obtener_PPasantia()
    {
        EPPasantiaSimple epPasantiaSimple = new EPPasantiaSimple();
        List<EPPasantiaSimple> lstPPasantia = new List<EPPasantiaSimple>();
        DTOPPasantia dtoPPasantia = adpPasantia.Obtener_PPasantia();
        foreach (DTOPPasantia.PPasantiaRow drPPasantia in dtoPPasantia.PPasantia.Rows)
        {
            epPasantiaSimple = new EPPasantiaSimple();
            epPasantiaSimple.Id_Pasantia = drPPasantia.Id_Pasantia;
            epPasantiaSimple.Id_Postulacion = drPPasantia.Id_Postulacion;
            epPasantiaSimple.Horas = drPPasantia.Horas;
            epPasantiaSimple.FechaInicioPasantia = drPPasantia.FechaInicioPasantia;
            epPasantiaSimple.Estado = drPPasantia.Estado;
            epPasantiaSimple.FechaRegistro = drPPasantia.FechaRegistro;
            epPasantiaSimple.FechaModificacion = drPPasantia.FechaModificacion;
            lstPPasantia.Add(epPasantiaSimple);
        }
        return lstPPasantia;
    }

    public EPPasantiaSimple Obtener_PPasantia_Id_Pasantia(string Id_Pasantia)
    {
        EPPasantiaSimple epPasantiaSimple = new EPPasantiaSimple();
        DTOPPasantia dtoPPasantia = adpPasantia.Obtener_PPasantia_Id_Pasantia(Id_Pasantia);
        foreach (DTOPPasantia.PPasantiaRow drPPasantia in dtoPPasantia.PPasantia.Rows)
        {
            epPasantiaSimple = new EPPasantiaSimple();
            epPasantiaSimple.Id_Pasantia = drPPasantia.Id_Pasantia;
            epPasantiaSimple.Id_Postulacion = drPPasantia.Id_Postulacion;
            epPasantiaSimple.Horas = drPPasantia.Horas;
            epPasantiaSimple.FechaInicioPasantia = drPPasantia.FechaInicioPasantia;
            epPasantiaSimple.Estado = drPPasantia.Estado;
            epPasantiaSimple.FechaRegistro = drPPasantia.FechaRegistro;
            epPasantiaSimple.FechaModificacion = drPPasantia.FechaModificacion;
        }
        return epPasantiaSimple;
    }
    public EPPasantia Obtener_Datos_Soilicitud_Id_Estudiante(string Id_Estudiante)
    {
        EPPasantia epPasantia = new EPPasantia();
        DTOPSolicitud dtoPPasantia = adpPasantia.Obtener_Datos_Soilicitud_Id_Estudiante(Id_Estudiante);
        foreach (DTOPSolicitud.v_SolicitudRow drPPasantia in dtoPPasantia.v_Solicitud.Rows)
        {
            epPasantia = new EPPasantia();
            epPasantia.NombreResposable = drPPasantia.NombreResponsable;
            epPasantia.CargoResposable = drPPasantia.CargoResponsable;
            epPasantia.NombreInstitucion = drPPasantia.NombreInstitucion;
            epPasantia.DireccionInstitucion = drPPasantia.DireccionInstitucion;
            epPasantia.NombreModalidad = drPPasantia.NombreModalidad;
            epPasantia.HorasPasantia = drPPasantia.Horas;


        }
        return epPasantia;
    }
    public EPPasantiaSimple Obtener_PPasantia_Id_Postulacion(string Id_Postulacion)
    {
        EPPasantiaSimple epPasantiaSimple = new EPPasantiaSimple();
        DTOPPasantia dtoPPasantia = adpPasantia.Obtener_PPasantia_Id_Postulacion(Id_Postulacion);
        foreach (DTOPPasantia.PPasantiaRow drPPasantia in dtoPPasantia.PPasantia.Rows)
        {
            epPasantiaSimple = new EPPasantiaSimple();
            epPasantiaSimple.Id_Pasantia = drPPasantia.Id_Pasantia;
            epPasantiaSimple.Id_Postulacion = drPPasantia.Id_Postulacion;
            epPasantiaSimple.Horas = drPPasantia.Horas;
            epPasantiaSimple.FechaInicioPasantia = drPPasantia.FechaInicioPasantia;
            epPasantiaSimple.Estado = drPPasantia.Estado;
            epPasantiaSimple.FechaRegistro = drPPasantia.FechaRegistro;
            epPasantiaSimple.FechaModificacion = drPPasantia.FechaModificacion;
        }
        return epPasantiaSimple;
    }

    public List<EPPasantiaSimple> Obtener_PPasantia_Finalizado()
    {
        EPPasantiaSimple epPasantiaSimple = new EPPasantiaSimple();
        List<EPPasantiaSimple> lstPPasantia = new List<EPPasantiaSimple>();
        DTOPPasantia dtoPPasantia = adpPasantia.Obtener_PPasantia_Finalizado();
        foreach (DTOPPasantia.PPasantiaRow drPPostulacion in dtoPPasantia.PPasantia.Rows)
        {
            epPasantiaSimple = new EPPasantiaSimple();
            epPasantiaSimple.Id_Pasantia = drPPostulacion.Id_Pasantia;
            epPasantiaSimple.Id_Postulacion = drPPostulacion.Id_Postulacion;
            epPasantiaSimple.Horas = drPPostulacion.Horas;
            epPasantiaSimple.FechaInicioPasantia = drPPostulacion.FechaInicioPasantia;
            epPasantiaSimple.Estado = drPPostulacion.Estado;
            epPasantiaSimple.FechaRegistro = drPPostulacion.FechaRegistro;
            epPasantiaSimple.FechaModificacion = drPPostulacion.FechaModificacion;
            lstPPasantia.Add(epPasantiaSimple);
        }
        return lstPPasantia;
    }
}