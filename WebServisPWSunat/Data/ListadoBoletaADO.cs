using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using WebServisPWSunat.Conexion;
using WebServisPWSunat.Entidad;

namespace WebServisPWSunat.Data
{
    public class ListadoBoletaADO
    {
        public List<DocumentoElectronicosENT> GetListarlistaBoleta()
        {

            List<DocumentoElectronicosENT> lista = new List<DocumentoElectronicosENT>();

            SqlConnection cnx = new SqlConnection(new ConnectionADO().GetCnx());
            SqlCommand cmd = new SqlCommand("sp_listado_visor_web_boleta", cnx);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cnx.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DocumentoElectronicosENT objboletas = new DocumentoElectronicosENT
                    {
                        id = reader.GetInt32(reader.GetOrdinal("id")),
                        NumDoc = reader.GetString(reader.GetOrdinal("NumDoc")),
                        Fecha = reader.GetString(reader.GetOrdinal("Fecha")),
                        Ruc = reader.GetString(reader.GetOrdinal("Ruc")),
                        Subtotal = reader.GetDouble(reader.GetOrdinal("Subtotal")),
                        Igv = reader.GetDouble(reader.GetOrdinal("Igv")),
                        Isc = reader.GetDouble(reader.GetOrdinal("Isc")),
                        total = reader.GetDouble(reader.GetOrdinal("total")),
                        error = reader.GetString(reader.GetOrdinal("error")),
                        enviado = reader.GetString(reader.GetOrdinal("enviado")),
                    };
                    lista.Add(objboletas);
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