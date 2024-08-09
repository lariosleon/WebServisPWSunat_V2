﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebServisPWSunat.Entidad;

namespace WebServisPWSunat.Domain
{
    public interface ISystemDom
    {
        Task<IEnumerable<SystemEnt>> Obtener();
    }
}