using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Descripción breve de ADPPostulacion
/// </summary>
public class ADPPostulacion
{
    #region Metodos Privados
    private EDefectoAD ConstruirErrorServicio(string metodo, string excepcion, string mensaje)
    {
        EDefectoAD eDefectoAD = new EDefectoAD();
        eDefectoAD.Servicio = "SWADNETPAS";
        eDefectoAD.Clase = "ADPPostulacion";
        eDefectoAD.Metodo = metodo;
        eDefectoAD.Excepcion = excepcion;
        eDefectoAD.Mensaje = mensaje;
        return eDefectoAD;
    }
    #endregion

    #region Metodos Publicos

    public void Adicionar_PPostulacion(EPPostulacionSimple epPostulacionSimple)
    {
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PPostulacion_I");
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Estudiante", DbType.String, epPostulacionSimple.Id_Estudiante);
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Institucion", DbType.String, epPostulacionSimple.Id_Institucion);
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Modalidad", DbType.String, epPostulacionSimple.Id_Modalidad);
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_SedeAcademica", DbType.String, epPostulacionSimple.Id_SedeAcademica);
            BDSWADNETPAS.AddInParameter(dbCommand, "FechaAceptacion", DbType.DateTime, epPostulacionSimple.FechaAceptacion);
            BDSWADNETPAS.AddInParameter(dbCommand, "Estado", DbType.String, epPostulacionSimple.Estado);
            BDSWADNETPAS.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, epPostulacionSimple.FechaRegistro);
            BDSWADNETPAS.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, epPostulacionSimple.FechaModificacion);
            BDSWADNETPAS.ExecuteNonQuery(dbCommand);
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Adicionar_PPostulacion", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }

    }
    public void Actualizar_PPostulacion_EstadoAprobado(string Id_Postulacion)
    {
        Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
        DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PPostulacion_A_Estado_Aprobado");
        BDSWADNETPAS.AddInParameter(dbCommand, "Id_Postulacion", DbType.String, Id_Postulacion);
        BDSWADNETPAS.ExecuteNonQuery(dbCommand);
    }
    public void Actualizar_PPostulacion_EstadoObservado(string Id_Postulacion)
    {
        Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
        DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PPostulacion_A_Estado_Observado");
        BDSWADNETPAS.AddInParameter(dbCommand, "Id_Postulacion", DbType.String, Id_Postulacion);
        BDSWADNETPAS.ExecuteNonQuery(dbCommand);
    }
    public void Actualizar_PPostulacion(EPPostulacionSimple epPostulacionSimple)
    {
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PPostulacion_A");
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Postulacion", DbType.String, epPostulacionSimple.Id_Postulacion);
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Estudiante", DbType.String, epPostulacionSimple.Id_Estudiante);
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Institucion", DbType.String, epPostulacionSimple.Id_Institucion);
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Modalidad", DbType.String, epPostulacionSimple.Id_Modalidad);
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_SedeAcademica", DbType.String, epPostulacionSimple.Id_SedeAcademica);
            BDSWADNETPAS.AddInParameter(dbCommand, "FechaAceptacion", DbType.DateTime, epPostulacionSimple.FechaAceptacion);
            BDSWADNETPAS.AddInParameter(dbCommand, "Estado", DbType.String, epPostulacionSimple.Estado);
            BDSWADNETPAS.AddInParameter(dbCommand, "FechaRegistro", DbType.DateTime, epPostulacionSimple.FechaRegistro);
            BDSWADNETPAS.AddInParameter(dbCommand, "FechaModificacion", DbType.DateTime, epPostulacionSimple.FechaModificacion);
            BDSWADNETPAS.ExecuteNonQuery(dbCommand);
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Actualizar_PPostulacion", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }

    }

    public DTOPPostulacion Obtener_PPostulacion()
    {
        DTOPPostulacion dtoPostulacion = new DTOPPostulacion();
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PPostulacion_O");
            BDSWADNETPAS.LoadDataSet(dbCommand, dtoPostulacion, "PPostulacion");
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Obtener_PPostulacion", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoPostulacion;
    }

    public DTOPPostulacion Obtener_PPostulacion_Estado(string Estado)
    {
        DTOPPostulacion dtoPostulacion = new DTOPPostulacion();
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PPostulacion_O_Estado");
            BDSWADNETPAS.AddInParameter(dbCommand, "Estado", DbType.String, Estado);
            BDSWADNETPAS.LoadDataSet(dbCommand, dtoPostulacion, "PPostulacion");
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Obtener_PPostulacion_Estado", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoPostulacion;
    }

    public DTOPPostulacion Obtener_PPostulacion_Id_Estudiante(string Id_Estudiante)
    {
        DTOPPostulacion dtoPostulacion = new DTOPPostulacion();
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PPostulacion_O_Id_Estudiante");
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Estudiante", DbType.String, Id_Estudiante);
            BDSWADNETPAS.LoadDataSet(dbCommand, dtoPostulacion, "PPostulacion");
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("PPostulacion_O_Id_Estudiante", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoPostulacion;
    }

    public DTOPPostulacion Obtener_PPostulacion_Id_Estudiante_Verificar(string Id_Estudiante)
    {

        DTOPPostulacion dtoPostulacion = new DTOPPostulacion();


        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PPostulacion_O_Id_Estudiante_Verificar");
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Estudiante", DbType.String, Id_Estudiante);
            //BDSWADNETPAS.SetParameterValue(dbCommand, id, "PPostulacion");
            BDSWADNETPAS.LoadDataSet(dbCommand, dtoPostulacion, "PPostulacion");

        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("PPostulacion_O_Id_Estudiante_Verificar", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoPostulacion;
    }
    public DTOPPostulacion Obtener_PPostulacion_Id_Postulacion(string Id_Postulacion)
    {
        DTOPPostulacion dtoPostulacion = new DTOPPostulacion();
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PPostulacion_O_Id_Postulacion");
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Postulacion", DbType.String, Id_Postulacion);
            BDSWADNETPAS.LoadDataSet(dbCommand, dtoPostulacion, "PPostulacion");
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("Obtener_PPostulacion_Id_Postulacion", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoPostulacion;
    }
    public DTOPPostulacion Obtener_PPostulacion_Id_SedeAcademica(string Id_SedeAcademica)
    {
        DTOPPostulacion dtoPostulacion = new DTOPPostulacion();
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PPostulacion_O_Id_SedeAcademica");
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_SedeAcademica", DbType.String, Id_SedeAcademica);
            BDSWADNETPAS.LoadDataSet(dbCommand, dtoPostulacion, "PPostulacion");
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("PPostulacion_O_Id_SedeAcademica", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoPostulacion;
    }


    public DTOPPostulacion VerificarPostulacion(string Id_Estudiante)
    {
        DTOPPostulacion dtoPostulacion = new DTOPPostulacion();
        try
        {
            Database BDSWADNETPAS = SBaseDatos.BDSWADNETPAS;
            DbCommand dbCommand = BDSWADNETPAS.GetStoredProcCommand("PPostulacion_Verificar");
            BDSWADNETPAS.AddInParameter(dbCommand, "Id_Estudiante", DbType.String, Id_Estudiante);
            BDSWADNETPAS.LoadDataSet(dbCommand, dtoPostulacion, "PPostulacion");
        }
        catch (Exception SQLEx)
        {
            EDefectoAD eDefectoAD = ConstruirErrorServicio("PPostulacion_Verificar", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefectoAD>(eDefectoAD);
        }
        return dtoPostulacion;
    }
    #endregion
}