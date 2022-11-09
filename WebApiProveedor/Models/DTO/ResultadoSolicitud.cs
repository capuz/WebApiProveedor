using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiProveedor.Models.DTO
{
    public class ResultadoSolicitud
    {
        public ResultadoSolicitud()
        {
            INFO = new Info();
        }
        public Info INFO { get; set; }
        public List<Solicitud> OUTPUT { get; set; }
    }
}