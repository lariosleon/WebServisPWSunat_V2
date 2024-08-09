using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebServisPWSunat.Domain;

namespace WebServisPWSunat.Controllers
{
    [RoutePrefix("Facturas")]
    public class FacturaController : ApiController
    {
        [HttpGet]
        [Route("listado")]
        public dynamic Get()
        {
            FacturasBL v_objlistafactura = new FacturasBL();

            dynamic listadofacturas = v_objlistafactura.ListadoFacturas();

            return listadofacturas;
        }
    }
}
