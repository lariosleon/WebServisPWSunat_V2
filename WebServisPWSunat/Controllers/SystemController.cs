using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using WebServisPWSunat.Aplication;
using WebServisPWSunat.Domain;
//using WebServisPWSunat.Entidad;
//using Microsoft.AspNetCore.Mvc;
//using System.Web.Http;


namespace WebServisPWSunat.Controllers
{
    //[Route("[controller]")]
    [RoutePrefix("system")]
    //[ApiController]
    //[ApiController]
    //[Microsoft.AspNetCore.Mvc.Route("[controller]")]
    public class SystemController : ApiController
    {
        [HttpGet]
        [Route("listado")]
        public dynamic Get()
        {
            //string valor = null;

            //valor = "HOLA DATOS";

            //return valor;

            SystemBL v_objlistadosystem = new SystemBL();

            dynamic listadodesistemas = v_objlistadosystem.ListadoSystem();

            return listadodesistemas;
        }
    }
}
