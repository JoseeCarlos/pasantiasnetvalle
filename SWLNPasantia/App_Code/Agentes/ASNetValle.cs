using SWADNetValle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ASNetValle
/// </summary>
public class ASNetValle
{
    #region Variables Miembro
    private SWADNetValleClient swADNetValle;
    #endregion
    public ASNetValle()
    {
        try
        {
            swADNetValle = new SWADNetValleClient();
        }
        catch (Exception ex)
        {

            throw ex;
        }

    }
    #region Eventos
    #endregion

    #region Metodos Privados
    #endregion

    #region Metodos Publicos

    #region NCarrera

    public ENCarrera Obtener_NCarrera_Id_Carrera(string Id_Carrera)
    {
        ENCarrera enCarrera = new ENCarrera();
        try
        {
            enCarrera = swADNetValle.Obtener_NCarrera_Id_Carrera(Id_Carrera);
        }
        catch (Exception eX)
        {
            throw eX;
        }
        return enCarrera;
    }

    #endregion

    #region NCiudad

    public List<ENCiudad> Obtener_ENCiudad()
    {
        ENCiudad enCiudad = new ENCiudad();
        List<ENCiudad> lstENCiudad = new List<ENCiudad>();
        try
        {
            lstENCiudad = swADNetValle.Obtener_NCiudad().ToList();
        }
        catch (Exception eX)
        {
            throw eX;
        }
        return lstENCiudad;
    }

    public ENCiudad Obtener_NCiudad_Id_Ciudad(string Id_Ciudad)
    {
        ENCiudad enCiudad = new ENCiudad();
        try
        {
            enCiudad = swADNetValle.Obtener_NCiudad_Id_Ciudad(Id_Ciudad);
        }
        catch (Exception eX)
        {
            throw eX;
        }
        return enCiudad;
    }

    public List<Ciudad> ObtenerCiudad()
    {
        try
        {
            List<Ciudad> ls = new List<Ciudad>();
            ls = swADNetValle.ObtenerCiudad().ToList();
            return ls;
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }

    public List<Facultad> ObtenerFacultad()
    {
        try
        {
            List<Facultad> ls = new List<Facultad>();
            ls = swADNetValle.ObtenerFacultad().ToList();
            return ls;
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }

    public List<Facultad> ObtenerFacultadFa(string facultad)
    {
        try
        {
            List<Facultad> ls = new List<Facultad>();
            ls = swADNetValle.ObtenerFacultasFa(facultad).ToList();
            return ls;
        }
        catch (Exception Ex)
        {

            throw Ex;
        }
    }

    #endregion

    #region NEmpleado

    public List<ENEmpleadoSimple> Obtener_NEmpleadoSimple()
    {
        ENEmpleadoSimple enEmpleadoSimple = new ENEmpleadoSimple();
        List<ENEmpleadoSimple> lstENEmpleadoSimple = new List<ENEmpleadoSimple>();
        try
        {
            lstENEmpleadoSimple = swADNetValle.Obtener_NEmpleadoSimple().ToList();
        }
        catch (Exception eX)
        {
            throw eX;
        }
        return lstENEmpleadoSimple;
    }

    public ENEmpleadoSimple Obtener_NEmpleado_Id_Empleado(string Id_Empleado)
    {
        ENEmpleadoSimple enEmpleadoSimple = new ENEmpleadoSimple();
        try
        {
            enEmpleadoSimple = swADNetValle.Obtener_NEmpleado_Id_Empleado(Id_Empleado);
        }
        catch (Exception eX)
        {
            throw eX;
        }
        return enEmpleadoSimple;
    }

    #endregion

    #region NEstudiante

    public List<ENEstudiante> Obtener_NEstudiante()
    {
        ENEstudiante enEstudiante = new ENEstudiante();
        List<ENEstudiante> lstENEstudiante = new List<ENEstudiante>();
        try
        {
            lstENEstudiante = swADNetValle.Obtener_NEstudiante().ToList();
        }
        catch (Exception eX)
        {
            throw eX;
        }
        return lstENEstudiante;
    }

    public ENEstudiante Obtener_NEstudiante_Id_Estudiante(string Id_Estudiante)
    {
        ENEstudiante enEstudiante = new ENEstudiante();
        try
        {
            enEstudiante = swADNetValle.Obtener_NEstudiante_Id_Estudiante(Id_Estudiante);
        }
        catch (Exception eX)
        {
            throw eX;
        }
        return enEstudiante;
    }

    public string InicioSesion_CodigoEstudiante_Contrasena_Estudiante(string Codigo_Estudiante, string Password_Estudiante)
    {
        string id = string.Empty;
        try
        {
            id = swADNetValle.InicioSesion_CodigoEstudiante_Contrasena_Estudiante(Codigo_Estudiante, Password_Estudiante);
        }
        catch (Exception ex)
        {
            throw;
        }
        return id;
    }

    public string VerificarPasantia(string Id_Estudiante)
    {
        string corresponde = string.Empty;
        try
        {
            corresponde = swADNetValle.VerificarPasantia(Id_Estudiante);
        }
        catch (Exception ex)
        {
            throw;
        }
        return corresponde;
    }

    public List<ENEstudiante> BuscarEstudiante_NombreCompleto(string NombreCompleto)
    {
        ENEstudiante enEstudiante = new ENEstudiante();
        List<ENEstudiante> lstENEstudiante = new List<ENEstudiante>();
        try
        {
            lstENEstudiante = swADNetValle.BuscarEstudiante_NombreCompleto(NombreCompleto).ToList();
        }
        catch (Exception eX)
        {
            throw eX;
        }
        return lstENEstudiante;
    }
    #endregion

    #region NSedeAcademica

    public List<ENSedeAcademica> Obtener_NSedeAcademica()
    {
        ENSedeAcademica enSedeAcademica = new ENSedeAcademica();
        List<ENSedeAcademica> lstENSedeAcademica = new List<ENSedeAcademica>();
        try
        {
            lstENSedeAcademica = swADNetValle.Obtener_NSedeAcademica().ToList();
        }
        catch (Exception eX)
        {
            throw eX;
        }
        return lstENSedeAcademica;
    }

    public ENSedeAcademica Obtener_NSedeAcademica_Id_SedeAcademica(string Id_SedeAcademica)
    {
        ENSedeAcademica enSedeAcademica = new ENSedeAcademica();
        try
        {
            enSedeAcademica = swADNetValle.Obtener_NSedeAcademica_Id_SedeAcademica(Id_SedeAcademica);
        }
        catch (Exception eX)
        {
            throw eX;
        }
        return enSedeAcademica;
    }

    #endregion

    #region NCargo

    public ENCargo Obtener_NCargo_Id_Cargo(string Id_Cargo)
    {
        ENCargo enCargo = new ENCargo();
        try
        {
            enCargo = swADNetValle.Obtener_NCargo_Id_Cargo(Id_Cargo);
        }
        catch (Exception eX)
        {
            throw eX;
        }
        return enCargo;
    }

    #endregion

    #region NFacultad


    public List<ENFacultad> Obtener_ENFacultad()
    {
        ENFacultad enFacultad = new ENFacultad();
        List<ENFacultad> lstENFacultad = new List<ENFacultad>();
        try
        {
            lstENFacultad = swADNetValle.Obtener_NFacultad().ToList();
        }
        catch (Exception eX)
        {
            throw eX;
        }
        return lstENFacultad;
    }



    public ENFacultad Obtener_NFacultad_Id_Facultad(string Id_Facultad)
    {
        ENFacultad enFacultad = new ENFacultad();
        try
        {
            enFacultad = swADNetValle.Obtener_NFacultad_Id_Facultad(Id_Facultad);
        }
        catch (Exception eX)
        {
            throw eX;
        }
        return enFacultad;
    }

    #endregion

    #region NDirectorCarrera

    public ENDirectorCarrera Obtener_NDirectorCarrera_Id_DirectorCarrera(string Id_DirectorCarrera)
    {
        ENDirectorCarrera enDirectorCarrera = new ENDirectorCarrera();
        try
        {
            enDirectorCarrera = swADNetValle.Obtener_NDirectorCarrera_Id_DirectorCarrera(Id_DirectorCarrera);
        }
        catch (Exception eX)
        {
            throw eX;
        }
        return enDirectorCarrera;
    }

    #endregion

    #endregion

}