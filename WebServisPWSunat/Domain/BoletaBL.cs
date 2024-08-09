using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebServisPWSunat.Data;
using WebServisPWSunat.Entidad;

namespace WebServisPWSunat.Domain
{
    public class BoletaBL
    {
        public List<DocumentoElectronicosENT> ListadoBoleta()
        {
            return new ListadoBoletaADO().GetListarlistaBoleta();
        }
    }
}