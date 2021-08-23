using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Descripción breve de ADPPasantia
/// </summary>
public class ADPPasantia
{
    public ADPPasantia()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }


    #region Metodos Privados
    private EDefectoAD ConstruirErrorServicio(string metodo, string excepcion, string mensaje)
    {
        EDefectoAD eDefectoAD = new EDefectoAD();
        eDefectoAD.Servicio = "SWADNETPAS";
        eDefectoAD.Clase = "ADPPasantia";
        eDefectoAD.Metodo = metodo;
        eDefectoAD.Excepcion = excepcion;
        eDefectoAD.Mensaje = mensaje;
        return eDefectoAD;
    }
    #endregion

    #region Metodos Publicos

    public void Adicionar_PPasantia(EPPasantiaSimple epPasantiaSimple)
    {
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PPasantia_I");
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Postulacion", DbType.String, epPasantiaSimple.Id_Postulacion);
            BDSWADNETPAS.AddInParameter(dbCommand, "Horas", DbType.String, epPasantiaSimple.Horas);
            //    BDSWADNETPAS.AddInParameter(dbCommand, "FechaInicioPasantia", DbType.String, epPasantiaSimple.FechaInicioPasantia);
            BDSWADNETPAS.AddInParameter(dbCommand, "Estado", DbType.String, epPasantiaSimple.Estado);
            BDSWADNETPAS.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, epPasantiaSimple.FechaRegistro);
            BDSWADNETPAS.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, epPasantiaSimple.FechaModificacion);
            BDSWADNETPAS.ExecuteNonQuery(dbCommand);
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Adicionar_PHorario", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }

    }

    public void Actualizar_PPasantia(EPPasantiaSimple epPasantiaSimple)
    {
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PPasantia_A");
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Pasantia", DbType.String, epPasantiaSimple.Id_Pasantia);
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Postulacion", DbType.String, epPasantiaSimple.Id_Postulacion);
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Horario", DbType.String, epPasantiaSimple.Horas);
            BDSWADNETPAS.AddInParameter(dbCommand, "FechaInicioPasantia", DbType.DateTime, epPasantiaSimple.FechaInicioPasantia);
            BDSWADNETPAS.AddInParameter(dbCommand, "Estado", DbType.String, epPasantiaSimple.Estado);
            BDSWADNETPAS.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, epPasantiaSimple.FechaRegistro);
            BDSWADNETPAS.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, epPasantiaSimple.FechaModificacion);
            BDSWADNETPAS.ExecuteNonQuery(dbCommand);
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Actualizar_PPasantia", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }

    }

    public void Actualizar_PPasantia_FechaInicio(EPPasantiaSimple epPasantiaSimple)
    {
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PPasantia_A_FechaInicio");
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Pasantia", DbType.String, epPasantiaSimple.Id_Pasantia);

            BDSWADNETPAS.AddInParameter(dbCommand, "FechaInicioPasantia", DbType.DateTime, epPasantiaSimple.FechaInicioPasantia);

            BDSWADNETPAS.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, epPasantiaSimple.FechaModificacion);
            BDSWADNETPAS.ExecuteNonQuery(dbCommand);
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Actualizar_PPasantia_FechaInicio", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }

    }

    public DTOPPasantia Obtener_PPasantia()
    {
        DTOPPasantia dtoPasantia = new DTOPPasantia();
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PPasantia_O");
            BDSWADNETPAS.LoadDataSet(dbCommand, dtoPasantia, "PPasantia");
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Obtener_PPasantia", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoPasantia;
    }

    public List<Pasantias> ObetenerPasantia()
    {
        List<Pasantias> pas = new List<Pasantias>();
        Pasantias p = null;
        Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
        DbCommand cmd = null;
        
        try
        {
            cmd = BDSWADNETPAS.GetStoredProcCommand("ReportePasantia");
            using (IDataReader dr = BDSWADNETPAS.ExecuteReader(cmd))
            {
                while (dr.Read())
                {
                    p = new Pasantias(int.Parse(dr[0].ToString()), int.Parse(dr[1].ToString()), int.Parse(dr[2].ToString()), dr[3].ToString());
                    pas.Add(p);
                }

                dr.Close();
            }

        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            
            
        }

        return pas;

    }
    public List<Pasantias> ObetenerPasantiaFecha(DateTime fecha1,DateTime fecha2)
    {
        List<Pasantias> pas = new List<Pasantias>();
        Pasantias p = null;
        Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
        DbCommand cmd = null;

        try
        {
            cmd = BDSWADNETPAS.GetStoredProcCommand("ReportePasantiafe");
            BDSWADNETPAS.AddInParameter(cmd, "fecha1", DbType.DateTime, fecha1);
            BDSWADNETPAS.AddInParameter(cmd, "fecha2", DbType.DateTime, fecha2);

            using (IDataReader dr = BDSWADNETPAS.ExecuteReader(cmd))
            {
                while (dr.Read())
                {
                    p = new Pasantias(int.Parse(dr[0].ToString()), int.Parse(dr[1].ToString()), int.Parse(dr[2].ToString()), dr[3].ToString());
                    pas.Add(p);
                }

                dr.Close();
            }




        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {


        }

        return pas;

    }

    public DTOPPasantia GenerarReporte()
    {
        DTOPPasantia dtoPasantia = new DTOPPasantia();
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PPasantia_O");
            BDSWADNETPAS.LoadDataSet(dbCommand, dtoPasantia, "PPasantia");
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Obtener_PPasantia", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoPasantia;
    }

    public DTOPPasantia Obtener_PPasantia_Id_Pasantia(string Id_Pasantia)
    {
        DTOPPasantia dtoPasantia = new DTOPPasantia();
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PPasantia_O_Id_Pasantia");
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Pasantia", DbType.String, Id_Pasantia);
            BDSWADNETPAS.LoadDataSet(dbCommand, dtoPasantia, "PPasantia");
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Obtener_PPasantia_Id_Pasantia", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoPasantia;
    }
    public DTOPSolicitud Obtener_Datos_Soilicitud_Id_Estudiante(string Id_Estudiante)
    {
        DTOPSolicitud dtoPSolicitud = new DTOPSolicitud();
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PSolicitud_Id_Estudiante");
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Estudiante", DbType.String, Id_Estudiante);
            BDSWADNETPAS.LoadDataSet(dbCommand, dtoPSolicitud, "v_Solicitud");
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Obtener_PPasantia_Id_Pasantia", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoPSolicitud;
    }
    public DTOPPasantia Obtener_PPasantia_Id_Postulacion(string Id_Postulacion)
    {
        DTOPPasantia dtoPasantia = new DTOPPasantia();
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PPasantia_O_Id_Postulacion");
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Postulacion", DbType.String, Id_Postulacion);
            BDSWADNETPAS.LoadDataSet(dbCommand, dtoPasantia, "PPasantia");
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Obtener_PPasantia_Id_Postulacion", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoPasantia;
    }


    public DTOPPasantia Obtener_PPasantia_Finalizado()
    {
        DTOPPasantia dtoPasantia = new DTOPPasantia();
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PPasantia_O_Estado_Finalizado");
            BDSWADNETPAS.LoadDataSet(dbCommand, dtoPasantia, "PPasantia");
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Obtener_PPasantia_Finalizado", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoPasantia;
    }
    #endregion

}