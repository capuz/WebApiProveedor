using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using WebApiProveedor.Models.DTO;

namespace WebApiProveedor.Models
{
    public class Select
    {
        private SqlConnection OpenConnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            return con;
        }

        public ResultadoSolicitud Ws01(int estado, string rutProveedor)
        {
            var result = new ResultadoSolicitud();
            string query = @"SELECT t.TAS_ID, d.DIREC_DIRECCION AS NOM_CALLE, d.DIREC_NUMERO AS NUM_CALLE, d.COM_ID,regcom.COM_DESCRIPCION COMUNA_DESC , d.REG_ID,regcom.REG_DESCRIPCION REGION_DESC, 
                        (SELECT dbo.[ConcatenaRol](t.TAS_ID ,', ')) AS ROL,r.RUB_ID,r.RUB_DESC RUBRO, g.GRU_ID,g.GRU_DESC GRUPO, tf.FEC_SIST_ASIGNACION AS FECHA_ASIGNACION, d.DIREC_LAT AS LATITUD, 
                        d.DIREC_LON AS LONGITUD, t.TAS_RUT_CLIENTE AS RUT_SOLICITANTE, t.TAS_NOMBRE_CLIENTE AS NOM_SOLICITANTE, t.TAS_RUT_EJECUTIVO AS RUT_EJECUTIVO, 
                        t.TAS_NOMBRE_CONTACTO AS NOM_CONTACTO, t.TAS_EMAIL_CONTACTO AS EMAIL_CONTACTO, t.TAS_TELEFONO_CONTACTO_1 AS FONO_CONTACTO1, 
                         t.TAS_TELEFONO_CONTACTO_2 AS FONO_CONTACTO2
                        FROM  BD_TASACION AS t 
                        JOIN BD_RUBRO AS r on t.RUB_ID =r.RUB_ID
                        JOIN BD_GRUPO AS g on t.GRU_ID =g.GRU_ID
                        JOIN BD_DIRECCION AS d ON t.DIREC_ID = d.DIREC_ID 
                        JOIN BCO_Vista_RegionComuna regcom on (d.REG_ID = regcom.REG_ID and d.COM_ID =regcom.COM_ID )
                        JOIN BD_FECHAS_TASACION AS tf ON t.TAS_ID = tf.TAS_ID
                        WHERE      (t.TAS_RUT_PROVEEDOR=@rutProveedor and t.TAS_ESTADO = @estado)";

            try
            {
                using (SqlConnection cnn = this.OpenConnection())
                {
                    result.OUTPUT = cnn.Query<Solicitud>(query, new { rutProveedor = rutProveedor, estado = estado }).AsList();
                }
            }
            catch (SqlException ex)
            {
                result.INFO.DESC_TERMINO = ex.Message;
                result.INFO.COD_TERMINO = ex.Number;
            }
            catch (Exception ex)
            {
                result.INFO.DESC_TERMINO = ex.Message;
                result.INFO.COD_TERMINO = -1;
            }

            return result;

        }
        public ResultadoSolicitud Ws02(int idSolicitud, string rutProveedor = null)
        {
            var result = new ResultadoSolicitud();
            string query = @"SELECT t.TAS_ID, d.DIREC_DIRECCION AS NOM_CALLE, d.DIREC_NUMERO AS NUM_CALLE, d.COM_ID,regcom.COM_DESCRIPCION COMUNA_DESC , d.REG_ID,regcom.REG_DESCRIPCION REGION_DESC, 
                        (SELECT dbo.[ConcatenaRol](t.TAS_ID ,', ')) AS ROL,r.RUB_ID,r.RUB_DESC RUBRO, g.GRU_ID,g.GRU_DESC GRUPO, tf.FEC_SIST_ASIGNACION AS FECHA_ASIGNACION, d.DIREC_LAT AS LATITUD, 
                        d.DIREC_LON AS LONGITUD, t.TAS_RUT_CLIENTE AS RUT_SOLICITANTE, t.TAS_NOMBRE_CLIENTE AS NOM_SOLICITANTE, t.TAS_RUT_EJECUTIVO AS RUT_EJECUTIVO, 
                        t.TAS_NOMBRE_CONTACTO AS NOM_CONTACTO, t.TAS_EMAIL_CONTACTO AS EMAIL_CONTACTO, t.TAS_TELEFONO_CONTACTO_1 AS FONO_CONTACTO1, 
                         t.TAS_TELEFONO_CONTACTO_2 AS FONO_CONTACTO2
                        FROM  BD_TASACION AS t 
                        JOIN BD_RUBRO AS r on t.RUB_ID =r.RUB_ID
                        JOIN BD_GRUPO AS g on t.GRU_ID =g.GRU_ID
                        JOIN BD_DIRECCION AS d ON t.DIREC_ID = d.DIREC_ID 
                        JOIN BCO_Vista_RegionComuna regcom on (d.REG_ID = regcom.REG_ID and d.COM_ID =regcom.COM_ID )
                        JOIN BD_FECHAS_TASACION AS tf ON t.TAS_ID = tf.TAS_ID
                        WHERE   (@rutProveedor is null or t.TAS_RUT_PROVEEDOR=@rutProveedor) and (t.TAS_ID = @idSolicitud )";
            try
            {
                using (SqlConnection cnn = this.OpenConnection())
                {
                    result.OUTPUT = cnn.Query<Solicitud>(query, new { rutProveedor = rutProveedor, idSolicitud = idSolicitud }).AsList();
                }
            }
            catch (SqlException ex)
            {
                result.INFO.DESC_TERMINO = ex.Message;
                result.INFO.COD_TERMINO = ex.Number;
            }
            catch (Exception ex)
            {
                result.INFO.DESC_TERMINO = ex.Message;
                result.INFO.COD_TERMINO = -1;
            }

            return result;
        }
        public ResultadoEvaluacion Ws11(int mes, int anio)
        {
            var result = new ResultadoEvaluacion();
            //!consultar obtención datos

            try
            {
                using (SqlConnection cnn = this.OpenConnection())
                {
                    result.OUTPUT = new List<Evaluacion>();
                }
            }
            catch (SqlException ex)
            {
                result.INFO.DESC_TERMINO = ex.Message;
                result.INFO.COD_TERMINO = ex.Number;
            }
            catch (Exception ex)
            {
                result.INFO.DESC_TERMINO = ex.Message;
                result.INFO.COD_TERMINO = -1;
            }

            return result;
        }
    }
}