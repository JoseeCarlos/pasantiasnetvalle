using SWADNetValle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SWADNETPAS;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "SWLNPasantia" en el código, en svc y en el archivo de configuración a la vez.
public class SWLNPasantia : ISWLNPasantia
{
    #region Institucion
    public void Actualizar_PInstitucion(string Id_Institucion, string NombreResponsable, string PrimerApellidoResponsable, string SegundoApellidoResponsable, string CargoResponsable, string NombreInstitucion, string DireccionInstitucion, string TelefonoInstitucion, string CorreoInstitucion, string Id_Ciudad, string Estado, DateTime FechaRegistro, DateTime FechaModificacion)
    {
        CSolicitud cSolicitud = new CSolicitud();
        cSolicitud.Actualizar_PInstitucion(Id_Institucion, NombreResponsable, PrimerApellidoResponsable, SegundoApellidoResponsable, CargoResponsable, NombreInstitucion, DireccionInstitucion, TelefonoInstitucion, CorreoInstitucion, Id_Ciudad, Estado, FechaModificacion, FechaModificacion);
    }
    public void Adicionar_PInstitucion(string NombreResponsable, string PrimerApellidoResponsable, string SegundoApellidoResponsable, string CargoResponsable, string NombreInstitucion, string DireccionInstitucion, string TelefonoInstitucion, string CorreoInstitucion, string Id_Ciudad, string Estado, DateTime FechaRegistro, DateTime FechaModificacion)
    {
        CSolicitud cSolicitud = new CSolicitud();
        cSolicitud.Adicionar_PInstitucion(NombreResponsable, PrimerApellidoResponsable, SegundoApellidoResponsable, CargoResponsable, NombreInstitucion, DireccionInstitucion, TelefonoInstitucion, CorreoInstitucion, Id_Ciudad, Estado, FechaRegistro, FechaModificacion);
    }
    public EPInstitucionCompleja Obtener_PInstitucion_Id_Institucion(string Id_Institucion)
    {
        CSolicitud cSolicitud = new CSolicitud();
        EPInstitucionCompleja ePInstitucionCompleja = new EPInstitucionCompleja();

        ePInstitucionCompleja = cSolicitud.Obtener_PInstitucion_Id_Institucion(Id_Institucion);
        return ePInstitucionCompleja;
    }
    public List<EPInstitucionCompleja> Obtener_PInstitucion()
    {
        CSolicitud cSolicitud = new CSolicitud();
        List<EPInstitucionCompleja> ePInstitucionComplejas = new List<EPInstitucionCompleja>();
        ePInstitucionComplejas = Obtener_PInstitucion();
        return ePInstitucionComplejas;
    }


    public List<EPInstitucionCompleja2> Obtener_PInstitucionCorta()
    {
        CSolicitud cSolicitud = new CSolicitud();
        List<EPInstitucionCompleja2> ePInstitucionComplejas = new List<EPInstitucionCompleja2>();
        ePInstitucionComplejas = Obtener_PInstitucionCorta();
        return ePInstitucionComplejas;
    }
    public EPInstitucionCompleja Obtener_PInstitucion_NombreInstitucion(string NombreInstitucion)
    {
        CSolicitud cSolicitud = new CSolicitud();
        EPInstitucionCompleja ePInstitucionCompleja = new EPInstitucionCompleja();

        ePInstitucionCompleja = cSolicitud.Obtener_PInstitucion_Id_Institucion(NombreInstitucion);
        return ePInstitucionCompleja;
    }

    public string VerificarPostulacion(string Id_Estudiante)
    {
        CSolicitud cSolicitud = new CSolicitud();
        string ePInstitucionComplejas = string.Empty;
        ePInstitucionComplejas = VerificarPostulacion(Id_Estudiante);
        return ePInstitucionComplejas;
    }

    #endregion

    #region Modalidad
    public void Actualizar_PModalidad(string Id_Modalidad, string NombreModalidad, string Id_Emp, string Estado, DateTime FechaRegistro, DateTime FechaModificacion)
    {
        CSolicitud cSolicitud = new CSolicitud();
        cSolicitud.Actualizar_PModalidad(Id_Modalidad, NombreModalidad, Id_Emp, Estado, FechaRegistro, FechaModificacion);
    }
    public void Adicionar_PModalidad(string NombreModalidad, string Id_Emp, string Estado, DateTime FechaRegistro, DateTime FechaModificacion)
    {
        CSolicitud cSolicitud = new CSolicitud();
        cSolicitud.Adicionar_PModalidad(NombreModalidad, Id_Emp, Estado, FechaRegistro, FechaModificacion);
    }
    public List<EPModalidadSimple> Obtener_PModalidad()
    {
        CSolicitud cSolicitud = new CSolicitud();
        List<EPModalidadSimple> ePModalidadSimples = new List<EPModalidadSimple>();
        ePModalidadSimples = cSolicitud.Obtener_PModalidad();
        return ePModalidadSimples;
    }
    public EPModalidadSimple Obtener_PModalidad_Id_Modalidad(string Id_Modalidad)
    {
        CSolicitud cSolicitud = new CSolicitud();
        EPModalidadSimple ePModalidadSimples = new EPModalidadSimple();
        ePModalidadSimples = cSolicitud.Obtener_PModalidad_Id_Modalidad(Id_Modalidad);
        return ePModalidadSimples;
    }
    #endregion

    #region Postulacion
    public void Actualizar_PPostulacion_EstadoAprobado(string Id_Postulacion)
    {
        CSolicitud cSolicitud = new CSolicitud();
        cSolicitud.Actualizar_PPostulacion_EstadoAprobado(Id_Postulacion);
    }
    public void Actualizar_PPostulacion_EstadoObservado(string Id_Postulacion)
    {
        CSolicitud cSolicitud = new CSolicitud();
        cSolicitud.Actualizar_PPostulacion_EstadoObservado(Id_Postulacion);
    }
    public void Actualizar_PPostulacion(string Id_Postulacion, string Id_Estudiante, string ID_Institucion, string Id_Modalidad, string Id_SedeAcademica, string Estado, DateTime FechaRegistro, DateTime FechaModificacion)
    {
        CSolicitud cSolicitud = new CSolicitud();
        cSolicitud.Actualizar_PPostulacion(Id_Postulacion, Id_Estudiante, ID_Institucion, Id_Modalidad, Id_SedeAcademica, Estado, FechaRegistro, FechaModificacion);
    }
    public void Adicionar_PPostulacion(string Id_Estudiante, string ID_Institucion, string Id_Modalidad, string Id_SedeAcademica, DateTime FechaAceptacion, string Estado, DateTime FechaRegistro, DateTime FechaModificacion)
    {
        CSolicitud cSolicitud = new CSolicitud();
        cSolicitud.Adicionar_PPostulacion(Id_Estudiante, ID_Institucion, Id_Modalidad, Id_SedeAcademica, FechaAceptacion, Estado, FechaRegistro, FechaModificacion);
    }

    public List<EPPostulacionCompleja> Obtener_PPostulacion()
    {
        CSolicitud cSolicitud = new CSolicitud();
        List<EPPostulacionCompleja> ePPostulacionComplejas = new List<EPPostulacionCompleja>();
        ePPostulacionComplejas = cSolicitud.Obtener_PPostulacion();
        return ePPostulacionComplejas;
    }

    public List<EPPostulacionCompleja> Obtener_PPostulacion_Estado(string Estado)
    {
        CSolicitud cSolicitud = new CSolicitud();
        List<EPPostulacionCompleja> ePPostulacionComplejas = new List<EPPostulacionCompleja>();
        ePPostulacionComplejas = cSolicitud.Obtener_PPostulacion_Estado(Estado);
        return ePPostulacionComplejas;
    }

    public List<EPPasantiaSimple> Obtener_PPasantia_Finalizado(string Estado)
    {
        CSolicitud cSolicitud = new CSolicitud();
        List<EPPasantiaSimple> ePPasantia = new List<EPPasantiaSimple>();
        //ePPasantia = cSolicitud.Obtener_PPasantia_Finalizado(Estado);
        return ePPasantia;
    }

    public EPPostulacionCompleja Obtener_PPostulacion_Id_Postulacion(string Id_Postulacion)
    {
        CSolicitud cSolicitud = new CSolicitud();
        EPPostulacionCompleja ePPostulacionComplejas = new EPPostulacionCompleja();
        ePPostulacionComplejas = cSolicitud.Obtener_PPostulacion_Id_Postulacion(Id_Postulacion);
        return ePPostulacionComplejas;
    }
    public EPPostulacionCompleja2 Obtener_PPostulacion_Id_Postulacion2(string Id_Postulacion)
    {
        CSolicitud cSolicitud = new CSolicitud();
        EPPostulacionCompleja2 ePPostulacionComplejas = new EPPostulacionCompleja2();
        ePPostulacionComplejas = cSolicitud.Obtener_PPostulacion_Id_Postulacion2(Id_Postulacion);
        return ePPostulacionComplejas;
    }
    public List<EPPostulacionCompleja3> BuscarEstududiante_NombreCompleto(string NombreCompleto)
    {
        CSolicitud cSolicitud = new CSolicitud();
        List<EPPostulacionCompleja3> lstEPPostulacionCompleja = new List<EPPostulacionCompleja3>();
        lstEPPostulacionCompleja = cSolicitud.BuscarEstududiante_NombreCompleto(NombreCompleto);
        return lstEPPostulacionCompleja;
    }
    #endregion

    #region Estudiante
    public List<ENEstudiante> Obtener_NEstudiante()
    {
        CObtnerNetValle cObtnerNetValle = new CObtnerNetValle();
        List<ENEstudiante> lstENEstudiantes = new List<ENEstudiante>();
        lstENEstudiantes = cObtnerNetValle.Obtener_NEstudiante();
        return lstENEstudiantes;
    }

    public ENEstudiante Obtener_NEstudiante_Id_Estudiante(string Id_Estudiante)
    {

        CObtnerNetValle cObtnerNetValle = new CObtnerNetValle();
        ENEstudiante eNEstudiantes = new ENEstudiante();
        eNEstudiantes = cObtnerNetValle.Obtener_NEstudiante_Id_Estudiante(Id_Estudiante);
        return eNEstudiantes;
    }
    public EPEstudianteCompleja Obtener_NEstudiante_NCarrera_Id_Estudiante(string Id_Estudiante)
    {

        CObtnerNetValle cObtnerNetValle = new CObtnerNetValle();
        EPEstudianteCompleja eNEstudiantes = new EPEstudianteCompleja();
        eNEstudiantes = cObtnerNetValle.Obtener_NEstudiante_NCarrera_Id_Estudiante(Id_Estudiante);
        return eNEstudiantes;
    }

    public string InicioSesion_CodigoEstudiante_Contrasena_Estudiante(string Codigo_Estudiante, string Password_Estudiante)
    {
        CObtnerNetValle cObtnerNetValle = new CObtnerNetValle();
        string id = string.Empty;
        id = cObtnerNetValle.InicioSesion_CodigoEstudiante_Contrasena_Estudiante(Codigo_Estudiante, Password_Estudiante);
        return id;
    }

    public string VerificarPasantia(string Id_Estudiante)
    {
        CObtnerNetValle cObtnerNetValle = new CObtnerNetValle();
        string corresponde = string.Empty;
        corresponde = cObtnerNetValle.VerificarPasantia(Id_Estudiante);
        return corresponde;
    }
    public List<ENEstudiante> BuscarEstudiante_NombreCompleto(string NombreCompleto)
    {
        CObtnerNetValle cObtnerNetValle = new CObtnerNetValle();
        List<ENEstudiante> lstENEstudiantes = new List<ENEstudiante>();
        lstENEstudiantes = cObtnerNetValle.BuscarEstudiante_NombreCompleto(NombreCompleto);
        return lstENEstudiantes;
    }


    public EPEstudianteDirectorCarreraCompleja Obtener_NEstudiante_NDirectorCarrera_Id_Estudiante(string Id_Estudiante)
    {

        CObtnerNetValle cObtnerNetValle = new CObtnerNetValle();
        EPEstudianteDirectorCarreraCompleja eNEstudiantes = new EPEstudianteDirectorCarreraCompleja();
        eNEstudiantes = Obtener_NEstudiante_NDirectorCarrera_Id_Estudiante(Id_Estudiante);
        return eNEstudiantes;
    }
    #endregion

    #region Pasantia
    public DateTime Verificar_FechaInicio_Id_Estudiante(string Id_Estudiante)
    {
        DateTime fechaInicio = DateTime.Now;
        CSolicitud cSolicitud = new CSolicitud();
        fechaInicio = cSolicitud.Verificar_FechaInicio_Id_Estudiante(Id_Estudiante);


        return fechaInicio;
    }
    public bool Verificar_FechaInicio_Id_Estudiante_bool(string Id_Estudiante)
    {
        bool fechaInicio = false;
        CSolicitud cSolicitud = new CSolicitud();
        fechaInicio = cSolicitud.Verificar_FechaInicio_Id_Estudiante_Bool(Id_Estudiante);


        return fechaInicio;
    }

    public void Actualizar_PPasantia_FechaInicio(EPPasantiaSimple epPasantiaSimple)
    {
        CSolicitud cSolicitud = new CSolicitud();

        cSolicitud.Actualizar_PPasatia_FechaInicio(epPasantiaSimple.Id_Pasantia, epPasantiaSimple.FechaInicioPasantia, epPasantiaSimple.FechaModificacion);
    }

    public EPSolicitud Obtener_Datos_Soilicitud_Id_Estudiante(string Id_Estudiante)
    {
        CSolicitud cSolicitud = new CSolicitud();
        EPSolicitud ePSolicitud = new EPSolicitud();
        ePSolicitud = cSolicitud.Obtener_Datos_Soilicitud_Id_Estudiante(Id_Estudiante);
        return ePSolicitud;
    }

    public void Adicionar_PPasantia(string Id_Postulacion, string Horas, string Estado, DateTime FechaRegistro, DateTime FechaModificacion)
    {
        CSolicitud cSolicitud = new CSolicitud();
        EPPasantiaSimple epPasantiaSimple = new EPPasantiaSimple();
        epPasantiaSimple.Id_Postulacion = Id_Postulacion;
        epPasantiaSimple.Estado = Estado;
        epPasantiaSimple.Horas = Horas;
        epPasantiaSimple.FechaRegistro = FechaRegistro;
        epPasantiaSimple.FechaModificacion = FechaModificacion;
        cSolicitud.Adicionar_PPasantia(Id_Postulacion, Horas, Estado, FechaRegistro, FechaModificacion);
    }

    public List<PasantiasCompleja> ObtenerPasantias()
    {
        CSolicitud sl = new CSolicitud();
        List<PasantiasCompleja> ls = sl.ObtenerPasantias();
        return ls;
    }

    public List<PasantiasCompleja> ObtenerPasantiasFecha(DateTime fecha1, DateTime fecha2)
    {
        CSolicitud sl = new CSolicitud();
        List<PasantiasCompleja> ls = sl.ObtenerPasantiasFecha(fecha1,fecha2);
        return ls;
    }

    public List<FacultadCom> ObtenerFacultas()
    {
        CObtnerNetValle ne = new CObtnerNetValle();
        List<FacultadCom> lf = ne.Obtenerfacultad().ToList();
        return lf;
    }

    public List<FacultadCom> ObtenerFacultasFa(string facultad)
    {
        CObtnerNetValle ne = new CObtnerNetValle();
        List<FacultadCom> lf = ne.ObtenerfacultadFa(facultad).ToList();
        return lf;
    }

    public List<CiudadCom> ObtenerCiudad()
    {
        CObtnerNetValle ne = new CObtnerNetValle();
        List<CiudadCom> lc = ne.ObtenerCiudad();
        return lc;
    }

    #endregion
}
