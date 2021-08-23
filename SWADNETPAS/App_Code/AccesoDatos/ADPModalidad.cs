using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Descripción breve de ADPModalidad
/// </summary>
public class ADPModalidad
{
    #region Metodos Privados
    private EDefectoAD ConstruirErrorServicio(string metodo, string excepcion, string mensaje)
    {
        EDefectoAD eDefectoAD = new EDefectoAD();
        eDefectoAD.Servicio = "SWADNETPAS";
        eDefectoAD.Clase = "ADPModalidad";
        eDefectoAD.Metodo = metodo;
        eDefectoAD.Excepcion = excepcion;
        eDefectoAD.Mensaje = mensaje;
        return eDefectoAD;
    }
    #endregion

    #region Metodos Publicos

    public void Adicionar_PModalidad(EPModalidadSimple epModalidadSimple)
    {
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PModalidad_I");
            BDSWADNETPAS.AddInParameter(dbCommand, "NombreModalidad", DbType.String, epModalidadSimple.NombreModalidad);
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Emp", DbType.String, epModalidadSimple.Id_Emp);
            BDSWADNETPAS.AddInParameter(dbCommand, "Estado", DbType.String, epModalidadSimple.Estado);
            BDSWADNETPAS.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, epModalidadSimple.FechaRegistro);
            BDSWADNETPAS.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, epModalidadSimple.FechaModificacion);
            BDSWADNETPAS.ExecuteNonQuery(dbCommand);
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Adicionar_PModalidad", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }

    }

    public void Actualizar_PModalidad(EPModalidadSimple epModalidadSimple)
    {
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PModalidad_A");
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Modalidad", DbType.String, epModalidadSimple.Id_Modalidad);
            BDSWADNETPAS.AddInParameter(dbCommand, "NombreModalidad", DbType.String, epModalidadSimple.NombreModalidad);
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Emp", DbType.String, epModalidadSimple.Id_Emp);
            BDSWADNETPAS.AddInParameter(dbCommand, "Estado", DbType.String, epModalidadSimple.Estado);
            BDSWADNETPAS.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, epModalidadSimple.FechaRegistro);
            BDSWADNETPAS.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, epModalidadSimple.FechaModificacion);
            BDSWADNETPAS.ExecuteNonQuery(dbCommand);
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Actualizar_PModalidad", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }

    }

    public DTOPModalidad Obtener_PModalidad()
    {
        DTOPModalidad dtoModalidad = new DTOPModalidad();
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PModalidad_O");
            BDSWADNETPAS.LoadDataSet(dbCommand, dtoModalidad, "PModalidad");
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Obtener_PModalidad", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoModalidad;
    }

    public DTOPModalidad Obtener_PModalidad_Id_Modalidad(string Id_Modalidad)
    {
        DTOPModalidad dtoModalidad = new DTOPModalidad();
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PModalidad_O_Id_Modalidad");
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Modalidad", DbType.String, Id_Modalidad);
            BDSWADNETPAS.LoadDataSet(dbCommand, dtoModalidad, "PModalidad");
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Obtener_PModalidad_Id_Modalidad", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoModalidad;
    }

    #endregion
}