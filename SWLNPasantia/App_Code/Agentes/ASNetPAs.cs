using SWADNETPAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ASNetPAs
/// </summary>
public class ASNetPAs
{
    #region Variables miembro
    private SWADNETPASClient swADNETPAS;
    #endregion
    public ASNetPAs()
    {

        swADNETPAS = new SWADNETPASClient();


        // swADNETPAS.InnerChannel.Faulted += new EventHandler(InnerChannel_Faulted);

    }
    #region Eventos
    #endregion
    #region Metodos Privados
    #endregion
    #region Metodos Publicos


    #region PPostulacion
    public void Adicionar_PPostulacion(EPPostulacionSimple epPostulacion_Simple)
    {
        try
        {
            swADNETPAS.Adicionar_PPostulacion(epPostulacion_Simple);
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }
    public void Actualizar_PPostulacion(EPPostulacionSimple epPostulacion_Simple)
    {
        try
        {
            swADNETPAS.Actualizar_PPostulacion(epPostulacion_Simple);
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }
    public void Actualizar_PPostulacion_EstadoAprobado(string Id_Postulacion)
    {
        try
        {
            swADNETPAS.Actualizar_PPostulacion_EstadoAprobado(Id_Postulacion);
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }

    public void Actualizar_PPostulacion_EstadoObservado(string Id_Postulacion)
    {
        try
        {
            swADNETPAS.Actualizar_PPostulacion_EstadoObservado(Id_Postulacion);
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }
    public List<EPPostulacionSimple> Obtener_PPostulacion()
    {
        List<EPPostulacionSimple> ePPostulacionSimples = new List<EPPostulacionSimple>();
        try
        {

            ePPostulacionSimples = swADNETPAS.Obtener_PPostulacion().ToList();
            return ePPostulacionSimples;
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }

    public List<EPPostulacionSimple> Obtener_PPostulacion_Estado(string Estado)
    {
        List<EPPostulacionSimple> ePPostulacionSimples = new List<EPPostulacionSimple>();
        try
        {
            ePPostulacionSimples = swADNETPAS.Obtener_PPostulacion_Estado(Estado).ToList();
            return ePPostulacionSimples;
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }

    public EPPostulacionSimple Obtener_PPostulacion_Id_Postulacion(string Id_Postulacion)
    {
        EPPostulacionSimple ePPostulacionSimples = new EPPostulacionSimple();
        try
        {
            ePPostulacionSimples = swADNETPAS.Obtener_PPostulacion_Id_Postulacion(Id_Postulacion);
            return ePPostulacionSimples;
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }

    public EPPostulacionSimple Obtener_PPostulacion_Id_Estudiante(string Id_Estudiante)
    {
        EPPostulacionSimple ePPostulacionSimples = new EPPostulacionSimple();
        try
        {
            ePPostulacionSimples = swADNETPAS.Obtener_PPostulacion_Id_Estudiante(Id_Estudiante);
            return ePPostulacionSimples;
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }



    public List<EPPostulacionSimple> Obtener_PPostulacion_Id_SedeAcademica(string Id_SedeAcademica)
    {
        List<EPPostulacionSimple> ePPostulacionSimples = new List<EPPostulacionSimple>();
        try
        {

            ePPostulacionSimples = swADNETPAS.Obtener_PPostulacion_Id_SedeAcademica(Id_SedeAcademica).ToList();
            return ePPostulacionSimples;
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }

    public List<EPPostulacionSimple> Obtener_PPostulacion_Id_Estudiante_Verificar(string Id_Estudiante)
    {

        List<EPPostulacionSimple> ePPostulacionSimples = new List<EPPostulacionSimple>();
        try
        {
            ePPostulacionSimples = swADNETPAS.Obtener_PPostulacion_Id_Estudiante_Verificar(Id_Estudiante).ToList();
            return ePPostulacionSimples;
        }
        catch (Exception eX)
        {

            throw eX;
        }

    }


    public EPPostulacionSimple VerificarPostulacion(string Id_Estudiante)
    {
        EPPostulacionSimple ePPostulacionSimples = new EPPostulacionSimple();
        try
        {
            ePPostulacionSimples = swADNETPAS.VerificarPostulacion(Id_Estudiante);
            return ePPostulacionSimples;
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }

    #endregion

    #region PModalidad
    public void Actualizar_PModalidad(EPModalidadSimple epModalidadSimple)
    {
        try
        {
            swADNETPAS.Actualizar_PModalidad(epModalidadSimple);
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }
    public void Adicionar_PModalidad(EPModalidadSimple epModalidadSimple)
    {
        try
        {
            swADNETPAS.Adicionar_PModalidad(epModalidadSimple);
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }
    public List<EPModalidadSimple> Obtener_PModalidad()
    {
        try
        {
            List<EPModalidadSimple> ePModalidadSimples = new List<EPModalidadSimple>();
            ePModalidadSimples = swADNETPAS.Obtener_PModalidad().ToList();
            return ePModalidadSimples;
        }
        catch (Exception Ex)
        {

            throw Ex;
        }

    }
    public EPModalidadSimple Obtener_PModalidad_Id_Modalidad(string Id_Modalidad)
    {
        try
        {
            EPModalidadSimple ePModalidadSimple = new EPModalidadSimple();
            ePModalidadSimple = swADNETPAS.Obtener_PModalidad_Id_Modalidad(Id_Modalidad);
            return ePModalidadSimple;
        }
        catch (Exception Ex)
        {

            throw Ex;
        }

    }
    #endregion

    #region PInstitucion
    public void Adicionar_PInstitucion(EPInstitucionSimple epInstitucionSimple)
    {
        try
        {
            swADNETPAS.Adicionar_PInstitucion(epInstitucionSimple);
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }
    public void Actualizar_PInstitucion(EPInstitucionSimple epInstitucionSimple)
    {
        try
        {
            swADNETPAS.Actualizar_PInstitucion(epInstitucionSimple);
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }
    public List<EPInstitucionSimple> Obtener_PInstitucion()
    {
        try
        {
            List<EPInstitucionSimple> ePInstitucionSimples = new List<EPInstitucionSimple>();
            ePInstitucionSimples = swADNETPAS.Obtener_PInstitucion().ToList();
            return ePInstitucionSimples;
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }
    public EPInstitucionSimple Obtener_PInstitucion_Id_Institucion(string Id_Institucion)
    {
        try
        {
            EPInstitucionSimple ePInstitucionSimple = new EPInstitucionSimple();
            ePInstitucionSimple = swADNETPAS.Obtener_PInstitucion_Id_Institucion(Id_Institucion);
            return ePInstitucionSimple;
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }

    public EPInstitucionSimple Obtener_PInstitucion_NombreInstitucion(string NombreInstitucion)
    {
        try
        {
            EPInstitucionSimple ePInstitucionSimple = new EPInstitucionSimple();
            ePInstitucionSimple = swADNETPAS.Obtener_PInstitucion_Id_Institucion(NombreInstitucion);
            return ePInstitucionSimple;
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }
    #endregion

   
    #region PPasantia
    public void Adicionar_PPasantia(EPPasantiaSimple epPasantiaSimple)
    {
        try
        {
            swADNETPAS.Adicionar_PPasantia(epPasantiaSimple);
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }
    public void Actualizar_PPasantia(EPPasantiaSimple epPasantiaSimple)
    {
        try
        {
            swADNETPAS.Actualizar_PPasantia(epPasantiaSimple);
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }

    public void Actualizar_PPasantia_FechaInicio(EPPasantiaSimple epPasantiaSimple)
    {
        try
        {
            swADNETPAS.Actualizar_PPasantia_FechaInicio(epPasantiaSimple);
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }
    public List<EPPasantiaSimple> Obtener_PPasantia()
    {
        try
        {
            List<EPPasantiaSimple> ePPasantiaSimples = new List<EPPasantiaSimple>();
            ePPasantiaSimples = swADNETPAS.Obtener_PPasantia().ToList();
            return ePPasantiaSimples;
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }

    public List<Pasantias> ObtenerPasantias()
    {
        try
        {
            List<Pasantias> ls = new List<Pasantias>();
            ls = swADNETPAS.ObtenerPasantia().ToList();
            return ls;
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }

    public List<Pasantias> ObtenerPasantiasFecha(DateTime fecha1,DateTime fecha2)
    {
        try
        {
            List<Pasantias> ls = new List<Pasantias>();
            ls = swADNETPAS.ObtenerPasantiaFecha(fecha1,fecha2).ToList();
            return ls;
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }
    public EPPasantiaSimple Obtener_PPasantia_Id_Pasantia(string Id_Pasantia)
    {
        try
        {
            EPPasantiaSimple ePPasantiaSimple = new EPPasantiaSimple();
            ePPasantiaSimple = swADNETPAS.Obtener_PPasantia_Id_Pasantia(Id_Pasantia);
            return ePPasantiaSimple;
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }
    public EPPasantia Obtener_Datos_Soilicitud_Id_Estudiante(string Id_Estudiante)
    {
        try
        {
            EPPasantia ePPasantia = new EPPasantia();
            ePPasantia = swADNETPAS.Obtener_Datos_Soilicitud_Id_Estudiante(Id_Estudiante);
            return ePPasantia;
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }
    public EPPasantiaSimple Obtener_PPasantia_Id_Postulacion(string Id_Postulacion)
    {
        try
        {
            EPPasantiaSimple ePPasantiaSimple = new EPPasantiaSimple();
            ePPasantiaSimple = swADNETPAS.Obtener_PPasantia_Id_Postulacion(Id_Postulacion);
            return ePPasantiaSimple;
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }

    public List<EPPasantiaSimple> Obtener_PPasantia_Finalizado()
    {
        List<EPPasantiaSimple> epPasantiaSimple = new List<EPPasantiaSimple>();
        try
        {
            //epPasantiaSimple = swADNETPAS.Obtener_PPasantia_Finalizado().ToList();
            return epPasantiaSimple;
        }
        catch (Exception eX)
        {

            throw eX;
        }
    }
    #endregion


    #endregion
}