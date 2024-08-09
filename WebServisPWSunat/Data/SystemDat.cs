using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebServisPWSunat.Conexion;
using WebServisPWSunat.Entidad;

namespace WebServisPWSunat.Data
{
    public class SystemDat : ISystemDat
    {
        public async Task<IEnumerable<SystemEnt>> Obtener()
        {
            SystemEnt obj = null;
            SystemEnt objfactura = new SystemEnt();
            /* detalleFactura objencabezado = null*/
            ;
            List<SystemEnt> lista = new List<SystemEnt>();

            SqlConnection cnx = new SqlConnection(new ConnectionADO().GetRest());
            SqlCommand cmd = new SqlCommand("sp_listado_hiopost", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cnx.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SystemEnt objsistemas = new SystemEnt
                    {
                        id = reader.GetInt32(reader.GetOrdinal("id")),
                        description = reader.GetString(reader.GetOrdinal("description")),
                        state = reader.GetString(reader.GetOrdinal("state")),
                    };
                    lista.Add(objsistemas);
                }

            }
            catch (SqlException ex)
            {
                string txtodelmensajeerror = (string.Join(" ", (ex.Message.Trim()).Replace("'", " ")));
                using (SqlConnection connectionOtto = new SqlConnection(new ConnectionADO().GetCnx()))
                {
                    connectionOtto.Open();

                    // Actualizar 'comprobante_estado' a 1 para indicar que el registro ha sido procesado
                    string queryActualizarEstado = $"UPDATE comprobantes SET comprobante_sync = 2";
                    using (SqlCommand commandActualizarEstado = new SqlCommand(queryActualizarEstado, connectionOtto))
                    {
                        commandActualizarEstado.ExecuteNonQuery();
                    }

                }

                Console.WriteLine($"Error al procesar en DBFrest: {ex.Message}");
            }
            return lista;

        }
            public List<SystemEnt> Obtener2()
        {
            SystemEnt obj = null;
            SystemEnt objfactura = new SystemEnt();
            /* detalleFactura objencabezado = null*/
            ;
            List<SystemEnt> lista = new List<SystemEnt>();

            SqlConnection cnx = new SqlConnection(new ConnectionADO().GetRest());
            SqlCommand cmd = new SqlCommand("sp_listado_hiopost", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            try 
            {
                cnx.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SystemEnt objsistemas = new SystemEnt
                    {
                        id = reader.GetInt32(reader.GetOrdinal("id")),
                        description = reader.GetString(reader.GetOrdinal("description")),
                        state = reader.GetString(reader.GetOrdinal("state")),
                    };
                    lista.Add(objsistemas);
                }

            }
            catch (SqlException ex)
            {
                string txtodelmensajeerror = (string.Join(" ", (ex.Message.Trim()).Replace("'", " ")));
                using (SqlConnection connectionOtto = new SqlConnection(new ConnectionADO().GetCnx()))
                {
                    connectionOtto.Open();

                    // Actualizar 'comprobante_estado' a 1 para indicar que el registro ha sido procesado
                    string queryActualizarEstado = $"UPDATE comprobantes SET comprobante_sync = 2";
                    using (SqlCommand commandActualizarEstado = new SqlCommand(queryActualizarEstado, connectionOtto))
                    {
                        commandActualizarEstado.ExecuteNonQuery();
                    }

                }

                Console.WriteLine($"Error al procesar en DBFrest: {ex.Message}");
            }
            return lista;
        }
    }
}