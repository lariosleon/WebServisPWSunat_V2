using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebServisPWSunat.Data;
using WebServisPWSunat.Entidad;

namespace WebServisPWSunat.Domain
{
    public class SystemDom : ISystemDom
    {
        private readonly ISystemDat _ISystemDat;
        public SystemDom(ISystemDat ISystemDat)
        {
            this._ISystemDat = ISystemDat;
        }
        public async Task<IEnumerable<SystemEnt>> Obtener()
        {
            return await _ISystemDat.Obtener();
        }
    }
}