using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServisPWSunat.Entidad
{
    public class RespuestEnt<T>
    {
        public Boolean Exito { get; set; }
        public string Mensaje { get; set; }
        public T Response { get; set; }
    }
}