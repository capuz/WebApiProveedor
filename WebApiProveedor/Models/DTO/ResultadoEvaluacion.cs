using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiProveedor.Models.DTO
{
    public class ResultadoEvaluacion
    {
        public ResultadoEvaluacion()
        {
            INFO = new Info();
        }
        public Info INFO { get; set; }
        public List<Evaluacion> OUTPUT { get; set; }
    }
}