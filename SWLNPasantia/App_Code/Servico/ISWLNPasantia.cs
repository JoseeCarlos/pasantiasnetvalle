using SWADNETPAS;
using SWADNetValle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "ISWLNPasantia" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWLNPasantia
{
    #region Postulacion
    [OperationContract]
    void Adicionar_PPostulacion(string Id_Estudiante, string ID_Institucion, string Id_Modalidad, string Id_SedeAcademica, DateTime FechaAceptacion, string Estado, DateTime FechaRegistro, DateTime FechaModificacion);
    [OperationContract]
    void Actualizar_PPostulacion_EstadoAprobado(string Id_Postulacion);
    [OperationContract]
    void Actualizar_PPostulacion_EstadoObservado(string Id_Postulacion);
    [OperationContract]
    void Actualizar_PPostulacion(string Id_Postulacion, string Id_Estudiante, string ID_Institucion, string Id_Modalidad, string Id_SedeAcademica, string Estado, DateTime FechaRegistro, DateTime FechaModificacion);
    [OperationContract]
    List<EPPostulacionCompleja> Obtener_PPostulacion();
    [OperationContract]
    List<EPPostulacionCompleja> Obtener_PPostulacion_Estado(string Estado);
    [OperationContract]
    EPPostulacionCompleja Obtener_PPostulacion_Id_Postulacion(string Id_Postulacion);
    [OperationContract]
    EPPostulacionCompleja2 Obtener_PPostulacion_Id_Postulacion2(string Id_Postulacion);

    [OperationContract]
    List<EPPostulacionCompleja3> BuscarEstududiante_NombreCompleto(string NombreCompleto);

    [OperationContract]
    string VerificarPostulacion(string Id_Estudiante);
    #endregion

    #region Modalidad
    [OperationContract]
    void Actualizar_PModalidad(string Id_Modalidad, string NombreModalidad, string Id_Emp, string Estado, DateTime FechaRegistro, DateTime FechaModificacion);
    [OperationContract]
    void Adicionar_PModalidad(string NombreModalidad, string Id_Emp, string Estado, DateTime FechaRegistro, DateTime FechaModificacion);
    [OperationContract]
    List<EPModalidadSimple> Obtener_PModalidad();
    [OperationContract]
    EPModalidadSimple Obtener_PModalidad_Id_Modalidad(string Id_Modalidad);

    #endregion

    #region Institucion
    [OperationContract]
    void Adicionar_PInstitucion(string NombreResponsable, string PrimerApellidoResponsable, string SegundoApellidoResponsable, string CargoResponsable, string NombreInstitucion, string DireccionInstitucion, string TelefonoInstitucion, string CorreoInstitucion, string Id_Ciudad, string Estado, DateTime FechaRegistro, DateTime FechaModificacion);

    [OperationContract]
    void Actualizar_PInstitucion(string Id_Institucion, string NombreResponsable, string PrimerApellidoResponsable, string SegundoApellidoResponsable, string CargoResponsable, string NombreInstitucion, string DireccionInstitucion, string TelefonoInstitucion, string CorreoInstitucion, string Id_Ciudad, string Estado, DateTime FechaRegistro, DateTime FechaModificacion);

    [OperationContract]
    List<EPInstitucionCompleja> Obtener_PInstitucion();

    [OperationContract]
    EPInstitucionCompleja Obtener_PInstitucion_Id_Institucion(string Id_Institucion);

    [OperationContract]
    EPInstitucionCompleja Obtener_PInstitucion_NombreInstitucion(string NombreInstitucion);

    [OperationContract]
    List<EPInstitucionCompleja2> Obtener_PInstitucionCorta();

    #endregion

    #region Estudiante

    [OperationContract]
    List<ENEstudiante> Obtener_NEstudiante();

    [OperationContract]
    ENEstudiante Obtener_NEstudiante_Id_Estudiante(string Id_Estudiante);

    [OperationContract]
    EPEstudianteCompleja Obtener_NEstudiante_NCarrera_Id_Estudiante(string Id_Estudiante);

    [OperationContract]
    string InicioSesion_CodigoEstudiante_Contrasena_Estudiante(string Codigo_Estudiante, string Password_Estudiante);
    [OperationContract]
    string VerificarPasantia(string Id_Estudiante);
    [OperationContract]
    EPEstudianteDirectorCarreraCompleja Obtener_NEstudiante_NDirectorCarrera_Id_Estudiante(string Id_Estudiante);
    #endregion

    #region Pasantia
    [OperationContract]
    DateTime Verificar_FechaInicio_Id_Estudiante(string Id_Estudiante);
    [OperationContract]
    void Adicionar_PPasantia(string Id_Postulacion, string Horas, string Estado, DateTime FechaRegistro, DateTime FechaModificacion);
    [OperationContract]
    bool Verificar_FechaInicio_Id_Estudiante_bool(string Id_Estudiante);
    [OperationContract]
    EPSolicitud Obtener_Datos_Soilicitud_Id_Estudiante(string Id_Estudiante);
    [OperationContract]
    void Actualizar_PPasantia_FechaInicio(EPPasantiaSimple epPasantiaSimple);

    [OperationContract]
    List<PasantiasCompleja> ObtenerPasantias();
    [OperationContract]
    List<PasantiasCompleja> ObtenerPasantiasFecha(DateTime fecha1,DateTime fecha2);
    [OperationContract]
    List<FacultadCom> ObtenerFacultas();
    [OperationContract]
    List<FacultadCom> ObtenerFacultasFa(string facultad);
    [OperationContract]
    List<CiudadCom> ObtenerCiudad();
    #endregion
}
