using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebServisPWSunat.Domain;


namespace WebServisPWSunat.Controllers
{
    [RoutePrefix("Boletas")]
    public class BoletaController : ApiController
    {
        [HttpGet]
        [Route("listado")]
        public dynamic Get()
        {
            BoletaBL v_objlistaboleta = new BoletaBL();

            dynamic listadoboletas = v_objlistaboleta.ListadoBoleta();

            return listadoboletas;
        }
    }
}
