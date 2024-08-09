using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServisPWSunat.Entidad
{
    public class DocumentoElectronicosENT
    {
        public Int32 id { get; set; }
        public string NumDoc { get; set; }
        public string Fecha { get; set; }
        public string Ruc { get; set; }
        public double Subtotal { get; set; }
        public double Igv { get; set; }
        public double total { get; set; }
        public string error { get; set; }
        public string enviado { get; set; }
    }
}