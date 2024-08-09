using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebServisPWSunat.Entidad;

namespace WebServisPWSunat.Aplication
{
    public interface ISystemApp
    {
        Task<IEnumerable<SystemEnt>> Obtener();
    }
}