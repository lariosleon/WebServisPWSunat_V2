using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebServisPWSunat.Conexion
{
    public class ConnectionADO
    {
        public string GetCnx()
        {
            string strgCnx = ConfigurationManager.ConnectionStrings["SQL_SERVER"].ConnectionString;

            if (object.ReferenceEquals(strgCnx, string.Empty))
            {
                return string.Empty;
            }
            else
            {
                return strgCnx;
            }
        }
        public string GetRest()
        {
            string strgCnx = ConfigurationManager.ConnectionStrings["REST"].ConnectionString;

            if (object.ReferenceEquals(strgCnx, string.Empty))
            {
                return string.Empty;
            }
            else
            {
                return strgCnx;
            }
        }
    }
}