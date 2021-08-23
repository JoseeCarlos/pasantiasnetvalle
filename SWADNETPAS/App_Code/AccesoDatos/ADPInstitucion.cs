using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Descripción breve de ADPInstitucion
/// </summary>
public class ADPInstitucion
{
    #region Metodos Privados
    private EDefectoAD ConstruirErrorServicio(string metodo, string excepcion, string mensaje)
    {
        EDefectoAD eDefectoAD = new EDefectoAD();
        eDefectoAD.Servicio = "SWADNETPAS";
        eDefectoAD.Clase = "ADPInstitucion";
        eDefectoAD.Metodo = metodo;
        eDefectoAD.Excepcion = excepcion;
        eDefectoAD.Mensaje = mensaje;
        return eDefectoAD;
    }
    #endregion

    #region Metodos Publicos

    public void Adicionar_PInstitucion(EPInstitucionSimple epInstitucionSimple)
    {
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PInstitucion_I");
            BDSWADNETPAS.AddInParameter(dbCommand, "NombreResponsable", DbType.String, epInstitucionSimple.NombreResponsable);
            BDSWADNETPAS.AddInParameter(dbCommand, "PrimerApellidoResponsable", DbType.String, epInstitucionSimple.PrimerApellidoResponsable);
            BDSWADNETPAS.AddInParameter(dbCommand, "SegundoApellidoResponsable", DbType.String, epInstitucionSimple.SegundoApellidoResponsable);
            BDSWADNETPAS.AddInParameter(dbCommand, "CargoResponsable", DbType.String, epInstitucionSimple.CargoResponsable);
            BDSWADNETPAS.AddInParameter(dbCommand, "NombreInstitucion", DbType.String, epInstitucionSimple.NombreInstitucion);
            BDSWADNETPAS.AddInParameter(dbCommand, "DireccionInstitucion", DbType.String, epInstitucionSimple.DireccionInstitucion);
            BDSWADNETPAS.AddInParameter(dbCommand, "TelefonoInstitucion", DbType.String, epInstitucionSimple.TelefonoInstitucion);
            BDSWADNETPAS.AddInParameter(dbCommand, "CorreoInstitucion", DbType.String, epInstitucionSimple.CorreoInstitucion);
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Ciudad", DbType.String, epInstitucionSimple.Id_Ciudad);
            BDSWADNETPAS.AddInParameter(dbCommand, "Estado", DbType.String, epInstitucionSimple.Estado);
            BDSWADNETPAS.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, epInstitucionSimple.FechaRegistro);
            BDSWADNETPAS.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, epInstitucionSimple.FechaModificacion);
            BDSWADNETPAS.ExecuteNonQuery(dbCommand);
        }
        catch (Exception ex)
        {
            //EDefectoAD eDefectoAD = ConstruirErrorServicio("Adicionar_PInstitucion", SQLEx.ToString(), SQLEx.Message);
            //throw new FaultException<EDefectoAD>(eDefectoAD);
            throw ex;
        }

    }

    public void Actualizar_PInstitucion(EPInstitucionSimple epInstitucionSimple)
    {
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PInstitucion_A");
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Institucion", DbType.String, epInstitucionSimple.Id_Institucion);
            BDSWADNETPAS.AddInParameter(dbCommand, "NombreResponsable", DbType.String, epInstitucionSimple.NombreResponsable);
            BDSWADNETPAS.AddInParameter(dbCommand, "PrimerApellidoResponsable", DbType.String, epInstitucionSimple.PrimerApellidoResponsable);
            BDSWADNETPAS.AddInParameter(dbCommand, "SegundoApellidoResponsable", DbType.String, epInstitucionSimple.SegundoApellidoResponsable);
            BDSWADNETPAS.AddInParameter(dbCommand, "CargoResponsable", DbType.String, epInstitucionSimple.CargoResponsable);
            BDSWADNETPAS.AddInParameter(dbCommand, "NombreInstitucion", DbType.String, epInstitucionSimple.NombreInstitucion);
            BDSWADNETPAS.AddInParameter(dbCommand, "DireccionInstitucion", DbType.String, epInstitucionSimple.DireccionInstitucion);
            BDSWADNETPAS.AddInParameter(dbCommand, "TelefonoInstitucion", DbType.String, epInstitucionSimple.TelefonoInstitucion);
            BDSWADNETPAS.AddInParameter(dbCommand, "CorreoInstitucion", DbType.String, epInstitucionSimple.CorreoInstitucion);
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Ciudad", DbType.String, epInstitucionSimple.Id_Ciudad);
            BDSWADNETPAS.AddInParameter(dbCommand, "Estado", DbType.String, epInstitucionSimple.Estado);
            BDSWADNETPAS.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, epInstitucionSimple.FechaRegistro);
            BDSWADNETPAS.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, epInstitucionSimple.FechaModificacion);
            BDSWADNETPAS.ExecuteNonQuery(dbCommand);
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Actualizar_PInstitucion", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }

    }

    public DTOPInstitucion Obtener_PInstitucion()
    {
        DTOPInstitucion dtoInstitucion = new DTOPInstitucion();
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PInstitucion_O");
            BDSWADNETPAS.LoadDataSet(dbCommand, dtoInstitucion, "PInstitucion");
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Obtener_PInstitucion", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoInstitucion;
    }

    public DTOPInstitucion Obtener_PInstitucion_Id_Institucion(string Id_Institucion)
    {
        DTOPInstitucion dtoModalidad = new DTOPInstitucion();
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PInstitucion_O_Id_Institucion");
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Institucion", DbType.String, Id_Institucion);
            BDSWADNETPAS.LoadDataSet(dbCommand, dtoModalidad, "PInstitucion");
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Obtener_PInstitucion_Id_Institucion", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoModalidad;
    }
    public DTOPInstitucion Obtener_PInstitucion_NombreInstitucion(string NombreInstitucion)
    {
        DTOPInstitucion dtoInstitucion = new DTOPInstitucion();
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PInstitucion_O_NombreInstitucion");
            BDSWADNETPAS.AddInParameter(dbCommand, "NombreInstitucion", DbType.String, NombreInstitucion);
            BDSWADNETPAS.LoadDataSet(dbCommand, dtoInstitucion, "PInstitucion");
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Obtener_PInstitucion_NombreInstitucion", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoInstitucion;
    }
    #endregion
}