using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebServisPWSunat.Domain;
using WebServisPWSunat.Entidad;

namespace WebServisPWSunat.Aplication
{
    public class SystemApp : ISystemApp
    {
        private readonly ISystemDom _ISystemDom;
        public SystemApp(ISystemDom ISystemDom)
        {
            this._ISystemDom = ISystemDom;
        }

        public async Task<IEnumerable<SystemEnt>> Obtener()
        {
            return await _ISystemDom.Obtener();
        }

    }
}