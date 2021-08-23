using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CPPostulacion
/// </summary>
public class CPPostulacion
{
    private ADPPostulacion adpPostulacion;
    public CPPostulacion()
    {
        adpPostulacion = new ADPPostulacion();
    }

    public void Actualizar_PPostulacion(EPPostulacionSimple epPostulacionSimple)
    {
        adpPostulacion.Actualizar_PPostulacion(epPostulacionSimple);
    }
    public void Actualizar_PPostulacion_EstadoAprobado(string Id_Postulacion)
    {
        adpPostulacion.Actualizar_PPostulacion_EstadoAprobado(Id_Postulacion);
    }
    public void Actualizar_PPostulacion_EstadoObservado(string Id_Postulacion)
    {
        adpPostulacion.Actualizar_PPostulacion_EstadoObservado(Id_Postulacion);
    }
    public void Adicionar_PPostulacion(EPPostulacionSimple epPostulacionSimple)
    {
        adpPostulacion.Adicionar_PPostulacion(epPostulacionSimple);
    }

    public List<EPPostulacionSimple> Obtener_PPostulacion()
    {
        EPPostulacionSimple epPostulacionSimple = new EPPostulacionSimple();
        List<EPPostulacionSimple> lstPPostulacion = new List<EPPostulacionSimple>();
        DTOPPostulacion dtoPPostulacion = adpPostulacion.Obtener_PPostulacion();
        foreach (DTOPPostulacion.PPostulacionRow drPPostulacion in dtoPPostulacion.PPostulacion.Rows)
        {
            epPostulacionSimple = new EPPostulacionSimple();
            epPostulacionSimple.Id_Postulacion = drPPostulacion.Id_Postulacion;
            epPostulacionSimple.Id_Estudiante = drPPostulacion.Id_Estudiante;
            epPostulacionSimple.Id_Institucion = drPPostulacion.Id_Institucion;
            epPostulacionSimple.Id_Modalidad = drPPostulacion.Id_Modalidad;
            epPostulacionSimple.Id_SedeAcademica = drPPostulacion.Id_SedeAcademica;
            epPostulacionSimple.FechaAceptacion = drPPostulacion.FechaAceptacion;
            epPostulacionSimple.Estado = drPPostulacion.Estado;
            epPostulacionSimple.FechaRegistro = drPPostulacion.FechaRegistro;
            epPostulacionSimple.FechaModificacion = drPPostulacion.FechaModificacion;
            lstPPostulacion.Add(epPostulacionSimple);
        }
        return lstPPostulacion;
    }

    public List<EPPostulacionSimple> Obtener_PPostulacion_Estado(string Estado)
    {
        EPPostulacionSimple epPostulacionSimple = new EPPostulacionSimple();
        List<EPPostulacionSimple> lstPPostulacion = new List<EPPostulacionSimple>();
        DTOPPostulacion dtoPPostulacion = adpPostulacion.Obtener_PPostulacion_Estado(Estado);
        foreach (DTOPPostulacion.PPostulacionRow drPPostulacion in dtoPPostulacion.PPostulacion.Rows)
        {
            epPostulacionSimple = new EPPostulacionSimple();
            epPostulacionSimple.Id_Postulacion = drPPostulacion.Id_Postulacion;
            epPostulacionSimple.Id_Estudiante = drPPostulacion.Id_Estudiante;
            epPostulacionSimple.Id_Institucion = drPPostulacion.Id_Institucion;
            epPostulacionSimple.Id_Modalidad = drPPostulacion.Id_Modalidad;
            epPostulacionSimple.Id_SedeAcademica = drPPostulacion.Id_SedeAcademica;
            epPostulacionSimple.FechaAceptacion = drPPostulacion.FechaAceptacion;
            epPostulacionSimple.Estado = drPPostulacion.Estado;
            epPostulacionSimple.FechaRegistro = drPPostulacion.FechaRegistro;
            epPostulacionSimple.FechaModificacion = drPPostulacion.FechaModificacion;
            lstPPostulacion.Add(epPostulacionSimple);
        }
        return lstPPostulacion;
    }

    public EPPostulacionSimple Obtener_PPostulacion_Id_Postulacion(string Id_Postulacion)
    {
        EPPostulacionSimple epPostulacionSimple = new EPPostulacionSimple();
        DTOPPostulacion dtoPPostulacion = adpPostulacion.Obtener_PPostulacion_Id_Postulacion(Id_Postulacion);
        foreach (DTOPPostulacion.PPostulacionRow drPPostulacion in dtoPPostulacion.PPostulacion.Rows)
        {
            epPostulacionSimple = new EPPostulacionSimple();
            epPostulacionSimple.Id_Postulacion = drPPostulacion.Id_Postulacion;
            epPostulacionSimple.Id_Estudiante = drPPostulacion.Id_Estudiante;
            epPostulacionSimple.Id_Institucion = drPPostulacion.Id_Institucion;
            epPostulacionSimple.Id_Modalidad = drPPostulacion.Id_Modalidad;
            epPostulacionSimple.Id_SedeAcademica = drPPostulacion.Id_SedeAcademica;
            epPostulacionSimple.FechaAceptacion = drPPostulacion.FechaAceptacion;
            epPostulacionSimple.Estado = drPPostulacion.Estado;
            epPostulacionSimple.FechaRegistro = drPPostulacion.FechaRegistro;
            epPostulacionSimple.FechaModificacion = drPPostulacion.FechaModificacion;
        }
        return epPostulacionSimple;
    }

    public EPPostulacionSimple Obtener_PPostulacion_Id_Estudiante(string Id_Estudiante)
    {
        EPPostulacionSimple epPostulacionSimple = new EPPostulacionSimple();
        DTOPPostulacion dtoPPostulacion = adpPostulacion.Obtener_PPostulacion_Id_Estudiante(Id_Estudiante);
        foreach (DTOPPostulacion.PPostulacionRow drPPostulacion in dtoPPostulacion.PPostulacion.Rows)
        {
            epPostulacionSimple = new EPPostulacionSimple();
            epPostulacionSimple.Id_Postulacion = drPPostulacion.Id_Postulacion;
            epPostulacionSimple.Id_Estudiante = drPPostulacion.Id_Estudiante;
            epPostulacionSimple.Id_Institucion = drPPostulacion.Id_Institucion;
            epPostulacionSimple.Id_Modalidad = drPPostulacion.Id_Modalidad;
            epPostulacionSimple.Id_SedeAcademica = drPPostulacion.Id_SedeAcademica;
            epPostulacionSimple.FechaAceptacion = drPPostulacion.FechaAceptacion;
            epPostulacionSimple.Estado = drPPostulacion.Estado;
            epPostulacionSimple.FechaRegistro = drPPostulacion.FechaRegistro;
            epPostulacionSimple.FechaModificacion = drPPostulacion.FechaModificacion;
        }
        return epPostulacionSimple;
    }



    public List<EPPostulacionSimple> Obtener_PPostulacion_Id_Estudiante_Verificar(string Id_Estudiante)
    {
        EPPostulacionSimple epPostulacionSimple = new EPPostulacionSimple();
        List<EPPostulacionSimple> lstPPostulacion = new List<EPPostulacionSimple>();
        DTOPPostulacion dtoPPostulacion = adpPostulacion.Obtener_PPostulacion_Id_Estudiante_Verificar(Id_Estudiante);
        foreach (DTOPPostulacion.PPostulacionRow drPPostulacion in dtoPPostulacion.PPostulacion.Rows)
        {
            epPostulacionSimple = new EPPostulacionSimple();
            epPostulacionSimple.Id_Postulacion = drPPostulacion.Id_Postulacion;
            epPostulacionSimple.Id_Estudiante = drPPostulacion.Id_Estudiante;

            epPostulacionSimple.Id_Institucion = drPPostulacion.Id_Institucion;
            epPostulacionSimple.Id_Modalidad = drPPostulacion.Id_Modalidad;
            epPostulacionSimple.Id_SedeAcademica = drPPostulacion.Id_SedeAcademica;
            epPostulacionSimple.FechaAceptacion = drPPostulacion.FechaAceptacion;

            epPostulacionSimple.Estado = drPPostulacion.Estado;

            epPostulacionSimple.FechaRegistro = drPPostulacion.FechaRegistro;
            epPostulacionSimple.FechaModificacion = drPPostulacion.FechaModificacion;
            lstPPostulacion.Add(epPostulacionSimple);
        }
        return lstPPostulacion;
    }
    public List<EPPostulacionSimple> Obtener_PPostulacion_Id_SedeAcademica(string Id_SedeAcademica)
    {
        EPPostulacionSimple epPostulacionSimple = new EPPostulacionSimple();
        List<EPPostulacionSimple> lstPPostulacion = new List<EPPostulacionSimple>();
        DTOPPostulacion dtoPPostulacion = adpPostulacion.Obtener_PPostulacion_Id_SedeAcademica(Id_SedeAcademica);
        foreach (DTOPPostulacion.PPostulacionRow drPPostulacion in dtoPPostulacion.PPostulacion.Rows)
        {
            epPostulacionSimple = new EPPostulacionSimple();
            epPostulacionSimple.Id_Postulacion = drPPostulacion.Id_Postulacion;
            epPostulacionSimple.Id_Estudiante = drPPostulacion.Id_Estudiante;
            epPostulacionSimple.Id_Institucion = drPPostulacion.Id_Institucion;
            epPostulacionSimple.Id_Modalidad = drPPostulacion.Id_Modalidad;
            epPostulacionSimple.Id_SedeAcademica = drPPostulacion.Id_SedeAcademica;
            epPostulacionSimple.FechaAceptacion = drPPostulacion.FechaAceptacion;
            epPostulacionSimple.Estado = drPPostulacion.Estado;
            epPostulacionSimple.FechaRegistro = drPPostulacion.FechaRegistro;
            epPostulacionSimple.FechaModificacion = drPPostulacion.FechaModificacion;
            lstPPostulacion.Add(epPostulacionSimple);
        }
        return lstPPostulacion;
    }

    public EPPostulacionSimple VerificarPostulacion(string Id_Estudiante)
    {
        EPPostulacionSimple epPostulacionSimple = new EPPostulacionSimple();
        DTOPPostulacion dtoPPostulacion = adpPostulacion.VerificarPostulacion(Id_Estudiante);
        foreach (DTOPPostulacion.PPostulacionRow drPPostulacion in dtoPPostulacion.PPostulacion.Rows)
        {
            epPostulacionSimple = new EPPostulacionSimple();
            epPostulacionSimple.Id_Postulacion = drPPostulacion.Id_Postulacion;
            epPostulacionSimple.Id_Estudiante = drPPostulacion.Id_Estudiante;
            epPostulacionSimple.Id_Institucion = drPPostulacion.Id_Institucion;
            epPostulacionSimple.Id_Modalidad = drPPostulacion.Id_Modalidad;
            epPostulacionSimple.Id_SedeAcademica = drPPostulacion.Id_SedeAcademica;
            epPostulacionSimple.FechaAceptacion = drPPostulacion.FechaAceptacion;
            epPostulacionSimple.Estado = drPPostulacion.Estado;
            epPostulacionSimple.FechaRegistro = drPPostulacion.FechaRegistro;
            epPostulacionSimple.FechaModificacion = drPPostulacion.FechaModificacion;
        }
        return epPostulacionSimple;
    }
}