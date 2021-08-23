using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "SWADNETPAS" en el código, en svc y en el archivo de configuración a la vez.
public class SWADNETPAS : ISWADNETPAS
{
    #region Tabla: Postulacion

    public void Actualizar_PPostulacion(EPPostulacionSimple epPostulacionSimple)
    {
        CPPostulacion cpPostulacion = new CPPostulacion();
        cpPostulacion.Actualizar_PPostulacion(epPostulacionSimple);
    }

    public void Adicionar_PPostulacion(EPPostulacionSimple epPostulacionSimple)
    {
        CPPostulacion cpPostulacion = new CPPostulacion();
        cpPostulacion.Adicionar_PPostulacion(epPostulacionSimple);
    }
    public void Actualizar_PPostulacion_EstadoAprobado(string Id_Postulacion)
    {
        CPPostulacion cpPostulacion = new CPPostulacion();
        cpPostulacion.Actualizar_PPostulacion_EstadoAprobado(Id_Postulacion);
    }
    public void Actualizar_PPostulacion_EstadoObservado(string Id_Postulacion)
    {
        CPPostulacion cpPostulacion = new CPPostulacion();
        cpPostulacion.Actualizar_PPostulacion_EstadoObservado(Id_Postulacion);
    }
    public List<EPPostulacionSimple> Obtener_PPostulacion()
    {
        CPPostulacion cpPostulacion = new CPPostulacion();
        List<EPPostulacionSimple> lstEPPostulacionSimple = new List<EPPostulacionSimple>();
        lstEPPostulacionSimple = cpPostulacion.Obtener_PPostulacion();
        return lstEPPostulacionSimple;
    }

    public List<EPPostulacionSimple> Obtener_PPostulacion_Estado(string Estado)
    {
        CPPostulacion cpPostulacion = new CPPostulacion();
        List<EPPostulacionSimple> lstEPPostulacionSimple = new List<EPPostulacionSimple>();
        lstEPPostulacionSimple = cpPostulacion.Obtener_PPostulacion_Estado(Estado);
        return lstEPPostulacionSimple;
    }


    public EPPostulacionSimple Obtener_PPostulacion_Id_Postulacion(string Id_Postulacion)
    {
        CPPostulacion cpPostulacion = new CPPostulacion();
        EPPostulacionSimple epPostulacionSimple = new EPPostulacionSimple();
        epPostulacionSimple = cpPostulacion.Obtener_PPostulacion_Id_Postulacion(Id_Postulacion);
        return epPostulacionSimple;
    }
    public EPPostulacionSimple Obtener_PPostulacion_Id_Estudiante(string Id_Estudiante)
    {
        CPPostulacion cpPostulacion = new CPPostulacion();
        EPPostulacionSimple epPostulacionSimple = new EPPostulacionSimple();
        epPostulacionSimple = cpPostulacion.Obtener_PPostulacion_Id_Estudiante(Id_Estudiante);
        return epPostulacionSimple;
    }
    public List<EPPostulacionSimple> Obtener_PPostulacion_Id_Estudiante_Verificar(string Id_Estudiante)
    {

        CPPostulacion cpPostulacion = new CPPostulacion();
        List<EPPostulacionSimple> ePPostulacionSimple = new List<EPPostulacionSimple>();
        ePPostulacionSimple = cpPostulacion.Obtener_PPostulacion_Id_Estudiante_Verificar(Id_Estudiante);
        return ePPostulacionSimple;
    }
    public List<EPPostulacionSimple> Obtener_PPostulacion_Id_SedeAcademica(string Id_SedeAcademica)
    {
        CPPostulacion cpPostulacion = new CPPostulacion();
        List<EPPostulacionSimple> lstEPPostulacionSimple = new List<EPPostulacionSimple>();
        lstEPPostulacionSimple = cpPostulacion.Obtener_PPostulacion_Estado(Id_SedeAcademica);
        return lstEPPostulacionSimple;
    }

    public EPPostulacionSimple VerificarPostulacion(string Id_Estudiante)
    {
        CPPostulacion cpPostulacion = new CPPostulacion();
        EPPostulacionSimple epPostulacionSimple = new EPPostulacionSimple();
        epPostulacionSimple = cpPostulacion.VerificarPostulacion(Id_Estudiante);
        return epPostulacionSimple;
    }
    #endregion

    #region Tabla: Modalidad

    public void Actualizar_PModalidad(EPModalidadSimple epModalidadSimple)
    {
        CPModalidad cpModalidad = new CPModalidad();
        cpModalidad.Actualizar_PModalidad(epModalidadSimple);
    }

    public void Adicionar_PModalidad(EPModalidadSimple epModalidadSimple)
    {
        CPModalidad cpModalidad = new CPModalidad();
        cpModalidad.Adicionar_PModalidad(epModalidadSimple);
    }

    public List<EPModalidadSimple> Obtener_PModalidad()
    {
        CPModalidad cpModalidad = new CPModalidad();
        List<EPModalidadSimple> lstEPModalidadSimple = new List<EPModalidadSimple>();
        lstEPModalidadSimple = cpModalidad.Obtener_PModalidad();
        return lstEPModalidadSimple;
    }

    public EPModalidadSimple Obtener_PModalidad_Id_Modalidad(string Id_Modalidad)
    {
        CPModalidad cpModalidad = new CPModalidad();
        EPModalidadSimple epModalidadSimple = new EPModalidadSimple();
        epModalidadSimple = cpModalidad.Obtener_PModalidad_Id_Modalidad(Id_Modalidad);
        return epModalidadSimple;
    }

    #endregion

    #region Tabla: Institucion

    public void Actualizar_PInstitucion(EPInstitucionSimple epInstitucionSimple)
    {
        CPInstitucion cpInstitucion = new CPInstitucion();
        cpInstitucion.Actualizar_PInstitucion(epInstitucionSimple);
    }

    public void Adicionar_PInstitucion(EPInstitucionSimple epInstitucionSimple)
    {
        CPInstitucion cpInstitucion = new CPInstitucion();
        cpInstitucion.Adicionar_PInstitucion(epInstitucionSimple);
    }

    public List<EPInstitucionSimple> Obtener_PInstitucion()
    {
        CPInstitucion cpInstitucion = new CPInstitucion();
        List<EPInstitucionSimple> lstEPInstitucionSimple = new List<EPInstitucionSimple>();
        lstEPInstitucionSimple = cpInstitucion.Obtener_PInstitucion();
        return lstEPInstitucionSimple;
    }

    public EPInstitucionSimple Obtener_PInstitucion_Id_Institucion(string Id_Institucion)
    {
        CPInstitucion cpInstitucion = new CPInstitucion();
        EPInstitucionSimple epInstitucionSimple = new EPInstitucionSimple();
        epInstitucionSimple = cpInstitucion.Obtener_PInstitucion_Id_Institucion(Id_Institucion);
        return epInstitucionSimple;
    }
    public EPInstitucionSimple Obtener_PInstitucion_NombreInstitucion(string NombreInstitucion)
    {
        CPInstitucion cpInstitucion = new CPInstitucion();
        EPInstitucionSimple epInstitucionSimple = new EPInstitucionSimple();
        epInstitucionSimple = cpInstitucion.Obtener_PInstitucion_Id_Institucion(NombreInstitucion);
        return epInstitucionSimple;
    }



    #endregion


    #region Tabla: Pasantia

    public void Actualizar_PPasantia(EPPasantiaSimple epPasantiaSimple)
    {
        CPPasantia cpPasantia = new CPPasantia();
        cpPasantia.Actualizar_PPasantia(epPasantiaSimple);
    }

    public void Adicionar_PPasantia(EPPasantiaSimple epPasantiaSimple)
    {
        CPPasantia cpPasantia = new CPPasantia();
        cpPasantia.Adicionar_PPasantia(epPasantiaSimple);
    }
    public void Actualizar_PPasantia_FechaInicio(EPPasantiaSimple epPasantiaSimple)
    {
        CPPasantia cpPasantia = new CPPasantia();
        cpPasantia.Actualizar_PPasantia_FechaInicio(epPasantiaSimple);
    }

    public List<EPPasantiaSimple> Obtener_PPasantia()
    {
        CPPasantia cpPasantia = new CPPasantia();
        List<EPPasantiaSimple> lstEPPasantiaSimple = new List<EPPasantiaSimple>();
        lstEPPasantiaSimple = cpPasantia.Obtener_PPasantia();
        return lstEPPasantiaSimple;
    }

    public EPPasantiaSimple Obtener_PPasantia_Id_Pasantia(string Id_Pasantia)
    {
        CPPasantia cpPasantia = new CPPasantia();
        EPPasantiaSimple epPasantiaSimple = new EPPasantiaSimple();
        epPasantiaSimple = cpPasantia.Obtener_PPasantia_Id_Pasantia(Id_Pasantia);
        return epPasantiaSimple;
    }

    public EPPasantiaSimple Obtener_PPasantia_Id_Postulacion(string Id_Postulacion)
    {
        CPPasantia cpPasantia = new CPPasantia();
        EPPasantiaSimple epPasantiaSimple = new EPPasantiaSimple();
        epPasantiaSimple = cpPasantia.Obtener_PPasantia_Id_Postulacion(Id_Postulacion);
        return epPasantiaSimple;
    }


    public EPPasantia Obtener_Datos_Soilicitud_Id_Estudiante(string Id_Estudiante)
    {
        CPPasantia cpPasantia = new CPPasantia();
        EPPasantia ePPasantia = new EPPasantia();
        ePPasantia = cpPasantia.Obtener_Datos_Soilicitud_Id_Estudiante(Id_Estudiante);
        return ePPasantia;
    }




    public List<EPPasantiaSimple> Obtener_PPasantia_Finalizado()
    {
        CPPasantia cpPasantia = new CPPasantia();
        List<EPPasantiaSimple> lstPPasantia = new List<EPPasantiaSimple>();
        lstPPasantia = cpPasantia.Obtener_PPasantia_Finalizado();
        return lstPPasantia;
    }

    public List<Pasantias> ObtenerPasantia()
    {
        ADPPasantia dp = new ADPPasantia();

        List<Pasantias> ls = dp.ObetenerPasantia();
        return ls;
    }

    public List<Pasantias> ObtenerPasantiaFecha(DateTime fecha1, DateTime fecha2)
    {
        ADPPasantia dp = new ADPPasantia();
        List<Pasantias> ls = dp.ObetenerPasantiaFecha(fecha1,fecha2);
        return ls;

    }



    #endregion
}
