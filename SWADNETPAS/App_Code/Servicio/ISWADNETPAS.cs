using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "ISWADNETPAS" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWADNETPAS
{
    #region Tabla: Postulacion

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    void Adicionar_PPostulacion(EPPostulacionSimple epPostulacion_Simple);

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    void Actualizar_PPostulacion(EPPostulacionSimple epPostulacion_Simple);
    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    void Actualizar_PPostulacion_EstadoAprobado(string Id_Postulacion);
    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    void Actualizar_PPostulacion_EstadoObservado(string Id_Postulacion);

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    List<EPPostulacionSimple> Obtener_PPostulacion();
    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    EPPasantia Obtener_Datos_Soilicitud_Id_Estudiante(string Id_Estudiante);

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    List<EPPostulacionSimple> Obtener_PPostulacion_Estado(string Estado);

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    EPPostulacionSimple Obtener_PPostulacion_Id_Postulacion(string Id_Postulacion);


    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    EPPostulacionSimple Obtener_PPostulacion_Id_Estudiante(string Id_Estudiante);


    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    List<EPPostulacionSimple> Obtener_PPostulacion_Id_Estudiante_Verificar(string Id_Estudiante);



    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    List<EPPostulacionSimple> Obtener_PPostulacion_Id_SedeAcademica(string Id_SedeAcademica);


    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    EPPostulacionSimple VerificarPostulacion(string Id_Estudiante);
    #endregion

    #region Tabla: Modalidad

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    void Actualizar_PModalidad(EPModalidadSimple epModalidadSimple);

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    void Adicionar_PModalidad(EPModalidadSimple epModalidadSimple);

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    List<EPModalidadSimple> Obtener_PModalidad();

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    EPModalidadSimple Obtener_PModalidad_Id_Modalidad(string Id_Modalidad);

    #endregion

    #region Tabla: Institucion

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    void Adicionar_PInstitucion(EPInstitucionSimple epInstitucionSimple);

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    void Actualizar_PInstitucion(EPInstitucionSimple epInstitucionSimple);

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    List<EPInstitucionSimple> Obtener_PInstitucion();

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    EPInstitucionSimple Obtener_PInstitucion_Id_Institucion(string Id_Institucion);

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    EPInstitucionSimple Obtener_PInstitucion_NombreInstitucion(string NombreInstitucion);

    #endregion


    #region Tabla: Pasantia

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    void Adicionar_PPasantia(EPPasantiaSimple epPasantiaSimple);

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    void Actualizar_PPasantia(EPPasantiaSimple epPasantiaSimple);

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    void Actualizar_PPasantia_FechaInicio(EPPasantiaSimple epPasantiaSimple);

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    List<EPPasantiaSimple> Obtener_PPasantia();

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    EPPasantiaSimple Obtener_PPasantia_Id_Pasantia(string Id_Pasantia);

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    EPPasantiaSimple Obtener_PPasantia_Id_Postulacion(string Id_Postulacion);

    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    List<EPPasantiaSimple> Obtener_PPasantia_Finalizado();
    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    List<Pasantias> ObtenerPasantia();
    [OperationContract]
    [FaultContract(typeof(EDefectoAD))]
    List<Pasantias> ObtenerPasantiaFecha(DateTime fecha1,DateTime fecha2);

    #endregion
}
