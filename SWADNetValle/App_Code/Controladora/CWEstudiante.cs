using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CWEstudiante
/// </summary>
public class CWEstudiante
{
    ADWEstudiante adwEstudiante;
    public CWEstudiante()
    {
        adwEstudiante = new ADWEstudiante();
    }
    public List<ENEstudiante> Obtener_NEstudiante()
    {
        ENEstudiante enEstudiante = new ENEstudiante();
        List<ENEstudiante> lstENEstudiante = new List<ENEstudiante>();
        DTONEstudiante dotNEstudiante = adwEstudiante.Obtener_NEstudiante();
        foreach (DTONEstudiante.WEstudianteRow drWEstudiante in dotNEstudiante.WEstudiante.Rows)
        {
            enEstudiante = new ENEstudiante();
            enEstudiante.Id_Estudiante = drWEstudiante.Id_Estudiante;
            enEstudiante.Id_Emp = drWEstudiante.Id_Emp;
            enEstudiante.Id_Carrera = drWEstudiante.Id_Carrera;
            enEstudiante.Id_SedeAcademica = drWEstudiante.Id_SedeAcademica;
            enEstudiante.Nombres = drWEstudiante.Nombres;
            enEstudiante.PrimerApellido = drWEstudiante.PrimerApellido;
            enEstudiante.SegundoApellido = drWEstudiante.SegundoApellido;
            enEstudiante.Telefono = drWEstudiante.Telefono;
            enEstudiante.FechaRegistro = drWEstudiante.FechaRegistro;
            enEstudiante.FechaModificacion = drWEstudiante.FechaModificacion;
            enEstudiante.Estado = drWEstudiante.Estado;
            enEstudiante.EmitidoEn = drWEstudiante.EmitidoEn;
            enEstudiante.CorreoElectronico = drWEstudiante.CorreoElectronico;
            enEstudiante.Celular = drWEstudiante.Celular;
            enEstudiante.CedulaIdentidad = drWEstudiante.CedulaIdentidad;
            lstENEstudiante.Add(enEstudiante);
        }
        return lstENEstudiante;
    }
    public ENEstudiante Obtener_NEstudiante_Id_Estudiante(string Id_Estudiante)
    {
        ENEstudiante enEstudiante = new ENEstudiante();
        DTONEstudiante dotNEstudiante = adwEstudiante.Obtener_NEstudiante_Id_Estudiante(Id_Estudiante);
        foreach (DTONEstudiante.WEstudianteRow drWEstudiante in dotNEstudiante.WEstudiante.Rows)
        {
            enEstudiante = new ENEstudiante();
            enEstudiante.Id_Estudiante = drWEstudiante.Id_Estudiante;
            enEstudiante.Id_Emp = drWEstudiante.Id_Emp;
            enEstudiante.Id_Carrera = drWEstudiante.Id_Carrera;
            enEstudiante.Id_SedeAcademica = drWEstudiante.Id_SedeAcademica;
            enEstudiante.Nombres = drWEstudiante.Nombres;
            enEstudiante.PrimerApellido = drWEstudiante.PrimerApellido;
            enEstudiante.SegundoApellido = drWEstudiante.SegundoApellido;
            enEstudiante.Telefono = drWEstudiante.Telefono;
            enEstudiante.FechaRegistro = drWEstudiante.FechaRegistro;
            enEstudiante.FechaModificacion = drWEstudiante.FechaModificacion;
            enEstudiante.Estado = drWEstudiante.Estado;
            enEstudiante.EmitidoEn = drWEstudiante.EmitidoEn;
            enEstudiante.CorreoElectronico = drWEstudiante.CorreoElectronico;
            enEstudiante.Celular = drWEstudiante.Celular;
            enEstudiante.CedulaIdentidad = drWEstudiante.CedulaIdentidad;

        }
        return enEstudiante;
    }

    public string InicioSesion_CodigoEstudiante_Contrasena_Estudiante(string Codigo_Estudiante, string Password_Estudiante)
    {

        string id = string.Empty;
        try
        {
            id = adwEstudiante.InicioSesion_CodigoEstudiante_Contrasena_Estudiante(Codigo_Estudiante, Password_Estudiante);
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
            corresponde = adwEstudiante.VerificarPasantia(Id_Estudiante);
        }
        catch (Exception ex)
        {
            throw;
        }
        return corresponde;
    }

    //public ENEstudiante BuscarEstudiante_NombreCompleto(string NombreCompleto)
    //{
    //    ENEstudiante enEstudiante = new ENEstudiante();
    //    DTONEstudiante dotNEstudiante = adwEstudiante.BuscarEstudiante_NombreCompleto(NombreCompleto);
    //    foreach (DTONEstudiante.WEstudianteRow drWEstudiante in dotNEstudiante.WEstudiante.Rows)
    //    {
    //        enEstudiante = new ENEstudiante();
    //        enEstudiante.Id_Estudiante = drWEstudiante.Id_Estudiante;


    //    }
    //    return enEstudiante;
    //}
    public List<ENEstudiante> BuscarEstudiante_NombreCompleto(string NombreCompleto)
    {
        ENEstudiante enEstudiante = new ENEstudiante();
        List<ENEstudiante> lstENEstudiante = new List<ENEstudiante>();
        DTONEstudiante dotNEstudiante = adwEstudiante.BuscarEstudiante_NombreCompleto(NombreCompleto);
        foreach (DTONEstudiante.WEstudianteRow drWEstudiante in dotNEstudiante.WEstudiante.Rows)
        {
            enEstudiante = new ENEstudiante();
            enEstudiante.Id_Estudiante = drWEstudiante.Id_Estudiante;
            enEstudiante.Id_Emp = drWEstudiante.Id_Emp;
            enEstudiante.Id_Carrera = drWEstudiante.Id_Carrera;
            enEstudiante.Id_SedeAcademica = drWEstudiante.Id_SedeAcademica;
            enEstudiante.Nombres = drWEstudiante.Nombres;
            enEstudiante.PrimerApellido = drWEstudiante.PrimerApellido;
            enEstudiante.SegundoApellido = drWEstudiante.SegundoApellido;
            enEstudiante.Telefono = drWEstudiante.Telefono;
            enEstudiante.FechaRegistro = drWEstudiante.FechaRegistro;
            enEstudiante.FechaModificacion = drWEstudiante.FechaModificacion;
            enEstudiante.Estado = drWEstudiante.Estado;
            enEstudiante.EmitidoEn = drWEstudiante.EmitidoEn;
            enEstudiante.CorreoElectronico = drWEstudiante.CorreoElectronico;
            enEstudiante.Celular = drWEstudiante.Celular;
            enEstudiante.CedulaIdentidad = drWEstudiante.CedulaIdentidad;
            lstENEstudiante.Add(enEstudiante);
        }
        return lstENEstudiante;
    }

}