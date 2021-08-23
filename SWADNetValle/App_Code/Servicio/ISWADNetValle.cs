using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "ISWADNetValle" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWADNetValle
{
    #region Tabla: Ciudad
    [OperationContract]
    List<ENCiudad> Obtener_NCiudad();
    [OperationContract]
    ENCiudad Obtener_NCiudad_Id_Ciudad(string Id_Ciudad);
    [OperationContract]
    List<Ciudad> ObtenerCiudad();
    [OperationContract]
    List<Facultad> ObtenerFacultad();
    [OperationContract]
    List<Facultad> ObtenerFacultasFa(string facultad);

    #endregion
    #region Tabla: Carrera

    [OperationContract]
    ENCarrera Obtener_NCarrera_Id_Carrera(string Id_Carrera);

    #endregion
    #region Tabla: Empleado
    [OperationContract]
    List<ENEmpleadoSimple> Obtener_NEmpleadoSimple();
    [OperationContract]
    ENEmpleadoSimple Obtener_NEmpleado_Id_Empleado(string Id_Empleado);
    #endregion
    #region Tabla: Estudiante
    [OperationContract]
    List<ENEstudiante> Obtener_NEstudiante();
    [OperationContract]
    ENEstudiante Obtener_NEstudiante_Id_Estudiante(string Id_Estudiante);
    [OperationContract]
    string InicioSesion_CodigoEstudiante_Contrasena_Estudiante(string Codigo_Estudiante, string Password_Estudiante);
    [OperationContract]
    string VerificarPasantia(string Id_Estudiante);

    [OperationContract]
    List<ENEstudiante> BuscarEstudiante_NombreCompleto(string NombreCompleto);
    #endregion
    #region Tabla: SedeAcademica
    [OperationContract]
    List<ENSedeAcademica> Obtener_NSedeAcademica();
    [OperationContract]
    ENSedeAcademica Obtener_NSedeAcademica_Id_SedeAcademica(string Id_SedeAcademica);
    #endregion
    #region Tabla: Cargo

    [OperationContract]
    ENCargo Obtener_NCargo_Id_Cargo(string Id_Cargo);

    #endregion
    #region Tabla: Facultad
    [OperationContract]
    List<ENFacultad> Obtener_NFacultad();


    [OperationContract]
    ENFacultad Obtener_NFacultad_Id_Facultad(string Id_Facultad);

    #endregion
    #region Tabla: DirectorCarrera

    [OperationContract]
    ENDirectorCarrera Obtener_NDirectorCarrera_Id_DirectorCarrera(string Id_DirectorCarrera);

    #endregion
}
