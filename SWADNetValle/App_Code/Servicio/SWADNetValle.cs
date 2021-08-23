using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "SWADNetValle" en el código, en svc y en el archivo de configuración a la vez.
public class SWADNetValle : ISWADNetValle
{
    #region Tabla: Ciudad
    public List<ENCiudad> Obtener_NCiudad()
    {
        CWCiudad cWCiudad = new CWCiudad();
        List<ENCiudad> enCiudad = new List<ENCiudad>();
        enCiudad = cWCiudad.Obtener_NCiudad();
        return enCiudad;
    }

    public ENCiudad Obtener_NCiudad_Id_Ciudad(string Id_Ciudad)
    {
        CWCiudad cWCiudad = new CWCiudad();
        ENCiudad enCiudad = new ENCiudad();
        enCiudad = cWCiudad.Obtener_NCiudad_Id_Ciudad(Id_Ciudad);
        return enCiudad;
    }
    #endregion
    #region Tabla: Empleado
    public List<ENEmpleadoSimple> Obtener_NEmpleadoSimple()
    {
        CWEmpleado cWEmpleado = new CWEmpleado();
        List<ENEmpleadoSimple> eNEmpleadoSimples = new List<ENEmpleadoSimple>();
        eNEmpleadoSimples = cWEmpleado.Obtener_NEmpleadoSimple();
        return eNEmpleadoSimples;
    }

    public ENEmpleadoSimple Obtener_NEmpleado_Id_Empleado(string Id_Empleado)
    {
        CWEmpleado cWEmpleado = new CWEmpleado();
        ENEmpleadoSimple eNEmpleadoSimples = new ENEmpleadoSimple();
        eNEmpleadoSimples = cWEmpleado.Obtener_NEmpleado_Id_Empleado(Id_Empleado);
        return eNEmpleadoSimples;
    }
    #endregion
    #region Tabla: Estudiante
    public List<ENEstudiante> Obtener_NEstudiante()
    {
        CWEstudiante cWEstudiante = new CWEstudiante();
        List<ENEstudiante> eNEstudiantes = new List<ENEstudiante>();
        eNEstudiantes = cWEstudiante.Obtener_NEstudiante();
        return eNEstudiantes;
    }

    public ENEstudiante Obtener_NEstudiante_Id_Estudiante(string Id_Estudiante)
    {
        CWEstudiante cWEstudiante = new CWEstudiante();
        ENEstudiante eNEstudiantes = new ENEstudiante();
        eNEstudiantes = cWEstudiante.Obtener_NEstudiante_Id_Estudiante(Id_Estudiante);
        return eNEstudiantes;
    }

    public string InicioSesion_CodigoEstudiante_Contrasena_Estudiante(string Codigo_Estudiante, string Password_Estudiante)
    {
        CWEstudiante cWEstudiante = new CWEstudiante();
        string id;
        id = cWEstudiante.InicioSesion_CodigoEstudiante_Contrasena_Estudiante(Codigo_Estudiante, Password_Estudiante);
        return id;
    }

    public string VerificarPasantia(string Id_Estudiante)
    {
        CWEstudiante cWEstudiante = new CWEstudiante();
        string corresponde;
        corresponde = cWEstudiante.VerificarPasantia(Id_Estudiante);
        return corresponde;
    }


    public List<ENEstudiante> BuscarEstudiante_NombreCompleto(string NombreCompleto)
    {
        CWEstudiante cWEstudiante = new CWEstudiante();
        List<ENEstudiante> eNEstudiantes = new List<ENEstudiante>();
        eNEstudiantes = cWEstudiante.BuscarEstudiante_NombreCompleto(NombreCompleto);
        return eNEstudiantes;




    }
    #endregion
    #region Tabla: SedeAcademica
    public List<ENSedeAcademica> Obtener_NSedeAcademica()
    {
        CWSedeAcademica cWSedeAcademica = new CWSedeAcademica();
        List<ENSedeAcademica> eNSedeAcademicas = new List<ENSedeAcademica>();
        eNSedeAcademicas = cWSedeAcademica.Obtener_NSedeAcademica();
        return eNSedeAcademicas;
    }

    public ENSedeAcademica Obtener_NSedeAcademica_Id_SedeAcademica(string Id_SedeAcademica)
    {
        CWSedeAcademica cWSedeAcademica = new CWSedeAcademica();
        ENSedeAcademica eNSedeAcademicas = new ENSedeAcademica();
        eNSedeAcademicas = cWSedeAcademica.Obtener_NSedeAcademica_Id_SedeAcademica(Id_SedeAcademica);
        return eNSedeAcademicas;
    }
    #endregion
    #region Tabla: Carrera


    public ENCarrera Obtener_NCarrera_Id_Carrera(string Id_Carrera)
    {
        CWCarrera cWCarrera = new CWCarrera();
        ENCarrera enCarrera = new ENCarrera();
        enCarrera = cWCarrera.Obtener_NCarrera_Id_Carrera(Id_Carrera);
        return enCarrera;
    }
    #endregion
    #region Tabla: Cargo


    public ENCargo Obtener_NCargo_Id_Cargo(string Id_Cargo)
    {
        CWCargo cWCargo = new CWCargo();
        ENCargo enCargo = new ENCargo();
        enCargo = cWCargo.Obtener_NCargo_Id_Cargo(Id_Cargo);
        return enCargo;
    }
    #endregion
    #region Tabla: Facultad

    public List<ENFacultad> Obtener_NFacultad()
    {
        CWFacultad cWFacultad = new CWFacultad();
        List<ENFacultad> enFacultad = new List<ENFacultad>();
        enFacultad = cWFacultad.Obtener_NFacultad();
        return enFacultad;
    }
    public ENFacultad Obtener_NFacultad_Id_Facultad(string Id_Facultad)
    {
        CWFacultad cWFacultad = new CWFacultad();
        ENFacultad enFacultad = new ENFacultad();
        enFacultad = cWFacultad.Obtener_NFacultad_Id_Facultad(Id_Facultad);
        return enFacultad;
    }
    #endregion
    #region Tabla: DirectorCarrera


    public ENDirectorCarrera Obtener_NDirectorCarrera_Id_DirectorCarrera(string Id_DirectorCarrera)
    {
        CWDirectorCarrera cWDirectorCarrera = new CWDirectorCarrera();
        ENDirectorCarrera enDirectorCarrera = new ENDirectorCarrera();
        enDirectorCarrera = cWDirectorCarrera.Obtener_NDirectorCarrera_Id_DirectorCarrera(Id_DirectorCarrera);
        return enDirectorCarrera;
    }

    public List<Ciudad> ObtenerCiudad()
    {
        ADWCiudad ci = new ADWCiudad();
        List<Ciudad> lci = ci.ObetenerCiudad().ToList();
        return lci;
    }

    public List<Facultad> ObtenerFacultad()
    {
        ADWFacultad fa = new ADWFacultad();
        List<Facultad> lf = fa.ObetenerFacultad();
        return lf;
    }

    public List<Facultad> ObtenerFacultasFa(string facultad)
    {
        ADWFacultad fa = new ADWFacultad();
        List<Facultad> lf = fa.ObetenerFacultadFa(facultad);
        return lf;
    }
    #endregion
}
