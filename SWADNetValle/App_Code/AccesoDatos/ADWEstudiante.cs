using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADWEstudiante
/// </summary>
public class ADWEstudiante
{
    public DTONEstudiante Obtener_NEstudiante()
    {
        DTONEstudiante dtoNEstudiante = new DTONEstudiante();
        try
        {
            Database DBSWADNETVALLE = SBaseDatos.BDSWADNETValle;
            DbCommand dbCommand = DBSWADNETVALLE.GetStoredProcCommand("NEstudiante_O");
            DBSWADNETVALLE.LoadDataSet(dbCommand, dtoNEstudiante, "WEstudiante");
        }
        catch (Exception ex)
        {
            throw;
        }
        return dtoNEstudiante;
    }

    public DTONEstudiante Obtener_NEstudiante_Id_Estudiante(string Id_Estudiante)
    {
        DTONEstudiante dtoNEstudiante = new DTONEstudiante();
        try
        {
            Database DBSWADNETVALLE = SBaseDatos.BDSWADNETValle;
            DbCommand dbCommand = DBSWADNETVALLE.GetStoredProcCommand("NEstudiante_O_Id_Estudiante");
            DBSWADNETVALLE.AddInParameter(dbCommand, "Id_Estudiante", DbType.String, Id_Estudiante);
            DBSWADNETVALLE.LoadDataSet(dbCommand, dtoNEstudiante, "WEstudiante");
        }
        catch (Exception ex)
        {
            throw;
        }
        return dtoNEstudiante;
    }

    public string InicioSesion_CodigoEstudiante_Contrasena_Estudiante(string Codigo_Estudiante, string Password_Estudiante)
    {
        string id = string.Empty;
        try
        {
            Database DBSWADNETVALLE = SBaseDatos.BDSWADNETValle;
            DbCommand dbCommand = DBSWADNETVALLE.GetStoredProcCommand("NLoginEstudiante_CodigoEstudiante_Contrasena");
            DBSWADNETVALLE.AddInParameter(dbCommand, "CodigoEstudiante", DbType.String, Codigo_Estudiante);
            DBSWADNETVALLE.AddInParameter(dbCommand, "Contrasena", DbType.String, Password_Estudiante);

            DBSWADNETVALLE.SetParameterValue(dbCommand, id, "Id_Estudiante");
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
            Database DBSWADNETVALLE = SBaseDatos.BDSWADNETValle;
            DbCommand dbCommand = DBSWADNETVALLE.GetStoredProcCommand("NVerificarPasantia");
            DBSWADNETVALLE.AddInParameter(dbCommand, "Id_Estudiante", DbType.String, Id_Estudiante);
            DBSWADNETVALLE.SetParameterValue(dbCommand, corresponde, "Id_Estudiante");
        }
        catch (Exception ex)
        {
            throw;
        }
        return corresponde;
    }
    public DTONEstudiante BuscarEstudiante_NombreCompleto(string NombreCompleto)
    {
        DTONEstudiante dtoNEstudiante = new DTONEstudiante();
        try
        {
            Database DBSWADNETVALLE = SBaseDatos.BDSWADNETValle;
            DbCommand dbCommand = DBSWADNETVALLE.GetStoredProcCommand("NBuscar_Estudiante_NombreCompleto");
            DBSWADNETVALLE.AddInParameter(dbCommand, "NombreCompleto", DbType.String, NombreCompleto);
            DBSWADNETVALLE.LoadDataSet(dbCommand, dtoNEstudiante, "WEstudiante");
        }
        catch (Exception ex)
        {
            throw;
        }
        return dtoNEstudiante;
    }

}