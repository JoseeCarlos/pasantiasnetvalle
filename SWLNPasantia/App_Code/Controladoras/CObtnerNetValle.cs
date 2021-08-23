using SWADNetValle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CObtnerNetValle
/// </summary>
public class CObtnerNetValle
{
    #region Variables Miembro
    private ASNetValle asNetValle;

    #endregion

    #region Contructor

    public CObtnerNetValle()
    {
        asNetValle = new ASNetValle();
    }
    #endregion

    #region Metodos Publicos 
    #region NEstudiante

    public List<CiudadCom> ObtenerCiudad()
    {
        List<CiudadCom> ls = new List<CiudadCom>();
        CiudadCom pas = new CiudadCom();
        List<Ciudad> pasan = new List<Ciudad>();
        try
        {
            pasan = asNetValle.ObtenerCiudad();

            foreach (var item in pasan)
            {
                pas = new CiudadCom(item.IdSedeAcademica, item.NombreSede);
                ls.Add(pas);
            }
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return ls;

    }

    public List<FacultadCom> Obtenerfacultad()
    {
        List<FacultadCom> ls = new List<FacultadCom>();
        FacultadCom pas = new FacultadCom();
        List<Facultad> pasan = new List<Facultad>();
        try
        {
            pasan = asNetValle.ObtenerFacultad();

            foreach (var item in pasan)
            {
                pas = new FacultadCom(item.IdEstudiante, item.NombreFacultad);
                

                ls.Add(pas);
            }
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return ls;

    }
    public List<FacultadCom> ObtenerfacultadFa(string facultad)
    {
        List<FacultadCom> ls = new List<FacultadCom>();
        FacultadCom pas = new FacultadCom();
        List<Facultad> pasan = new List<Facultad>();
        try
        {
            pasan = asNetValle.ObtenerFacultadFa(facultad);

            foreach (var item in pasan)
            {
                pas = new FacultadCom(item.IdEstudiante, item.NombreFacultad, item.NombeCarrera);


                ls.Add(pas);
            }
        }
        catch (Exception ex)
        {

            throw ex;
        }
        return ls;

    }
    public List<ENEstudiante> Obtener_NEstudiante()
    {
        ENEstudiante enEstudiante = new ENEstudiante();
        List<ENEstudiante> lstENEstudiante = new List<ENEstudiante>();
        try
        {
            lstENEstudiante = asNetValle.Obtener_NEstudiante().ToList();
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
            enEstudiante = asNetValle.Obtener_NEstudiante_Id_Estudiante(Id_Estudiante);
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
            id = asNetValle.InicioSesion_CodigoEstudiante_Contrasena_Estudiante(Codigo_Estudiante, Password_Estudiante);
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
            corresponde = asNetValle.VerificarPasantia(Id_Estudiante);
        }
        catch (Exception ex)
        {
            throw;
        }
        return corresponde;
    }

    public EPEstudianteCompleja Obtener_NEstudiante_NCarrera_Id_Estudiante(string Id_Estudiante)
    {
        EPEstudianteCompleja enEstudianteCarrera = new EPEstudianteCompleja();
        ENEstudiante eNEstudiante = new ENEstudiante();
        ENCarrera eNCarrera = new ENCarrera();
        try
        {
            eNEstudiante = asNetValle.Obtener_NEstudiante_Id_Estudiante(Id_Estudiante);
            eNCarrera = asNetValle.Obtener_NCarrera_Id_Carrera(eNEstudiante.Id_Carrera);
            enEstudianteCarrera.Id_Estudiante = eNEstudiante.Id_Estudiante;
            enEstudianteCarrera.NombreCompleto = eNEstudiante.Nombres + " " + eNEstudiante.PrimerApellido + " " + eNEstudiante.SegundoApellido;
            enEstudianteCarrera.CarnetIdentidad = eNEstudiante.CedulaIdentidad;
            enEstudianteCarrera.NombreCarrera = eNCarrera.NombreCarrera;



        }
        catch (Exception eX)
        {
            throw eX;
        }
        return enEstudianteCarrera;
    }

    public List<ENEstudiante> BuscarEstudiante_NombreCompleto(string NombreCompleto)
    {
        ENEstudiante enEstudiante = new ENEstudiante();
        List<ENEstudiante> lstENEstudiante = new List<ENEstudiante>();
        try
        {
            lstENEstudiante = asNetValle.BuscarEstudiante_NombreCompleto(NombreCompleto).ToList();
        }
        catch (Exception eX)
        {
            throw eX;
        }
        return lstENEstudiante;
    }


    public EPEstudianteDirectorCarreraCompleja Obtener_NEstudiante_NDirectorCarrera_Id_Estudiante(string Id_Estudiante)
    {
        EPEstudianteDirectorCarreraCompleja enEstudianteDirectorCarrera = new EPEstudianteDirectorCarreraCompleja();
        ENEstudiante eNEstudiante = new ENEstudiante();
        ENEmpleadoSimple eNEmpleadoSimple = new ENEmpleadoSimple();
        ENCarrera eNCarrera = new ENCarrera();
        ENCargo eNCargo = new ENCargo();
        ENFacultad eNFacultad = new ENFacultad();
        ENDirectorCarrera eNDirectorCarrera = new ENDirectorCarrera();

        try
        {
            eNEstudiante = asNetValle.Obtener_NEstudiante_Id_Estudiante(Id_Estudiante);
            eNCarrera = asNetValle.Obtener_NCarrera_Id_Carrera(eNEstudiante.Id_Carrera);
            eNFacultad = asNetValle.Obtener_NFacultad_Id_Facultad(eNCarrera.Id_Facultad);
            eNDirectorCarrera = asNetValle.Obtener_NDirectorCarrera_Id_DirectorCarrera(eNCarrera.Id_Carrera);
            eNEmpleadoSimple = asNetValle.Obtener_NEmpleado_Id_Empleado(eNDirectorCarrera.Id_Emp);
            eNCargo = asNetValle.Obtener_NCargo_Id_Cargo(eNEmpleadoSimple.Id_Cargo);



            enEstudianteDirectorCarrera.Id_Estudiante = eNEstudiante.Id_Estudiante;
            enEstudianteDirectorCarrera.NombreCompleto = eNEstudiante.Nombres + eNEstudiante.PrimerApellido + eNEstudiante.SegundoApellido;
            enEstudianteDirectorCarrera.CarnetIdentidad = eNEstudiante.CedulaIdentidad;
            enEstudianteDirectorCarrera.NombreCarrera = eNCarrera.NombreCarrera;
            enEstudianteDirectorCarrera.NombreCompletoDirector = eNEmpleadoSimple.Nombres + eNEmpleadoSimple.PrimerApellido + eNEmpleadoSimple.SegundoApellido;
            enEstudianteDirectorCarrera.CargoDirectorCarrera = eNCargo.NombreCargo;
            enEstudianteDirectorCarrera.NombreFacultad = eNFacultad.NombreFacultad;


        }
        catch (Exception eX)
        {
            throw eX;
        }
        return enEstudianteDirectorCarrera;
    }
    #endregion

    #region NCarrera
    //public ENCarrera Obtener_NCarrera_Id_Carrera(string Id_Carrera)
    //{
    //    ENCarrera enCarrera = new ENCarrera();
    //    try
    //    {
    //        enCarrera = asNetValle.Obtener_NCarrera_Id_Carrera(Id_Carrera);
    //    }
    //    catch (Exception eX)
    //    {
    //        throw eX;
    //    }
    //    return enCarrera;
    //}
    #endregion



    #endregion
}