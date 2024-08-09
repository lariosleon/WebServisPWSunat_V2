using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebServisPWSunat.Data;
using WebServisPWSunat.Entidad;

namespace WebServisPWSunat.Domain
{
    public class SystemBL
    {
        public List<SystemEnt> ListadoSystem()
        {
            return new ListadoADO().GetListarlistaSystem();
        }
    }
}