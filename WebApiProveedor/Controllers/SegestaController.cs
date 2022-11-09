using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiProveedor.Models;
using WebApiProveedor.Models.DTO;

namespace WebApiProveedor.Controllers
{
    public class SegestaController : ApiController
    {
        private readonly Select select;
        public SegestaController()
        {
            select = new Select();
        }

        [Route("api/ws01/{estado}/{rutProveedor}")]
        [HttpGet]
        public ResultadoSolicitud Ws01(int estado, string rutProveedor)
        {
            return select.Ws01(estado, rutProveedor);
        }
        [Route("api/ws02/{idSolicitud}")]
        [HttpGet]
        public ResultadoSolicitud Ws02(int idSolicitud)
        {
            return select.Ws02(idSolicitud);
        }
        [Route("api/ws02b/{idSolicitud}/{rutProveedor}")]
        [HttpGet]
        public ResultadoSolicitud Ws02b(int idSolicitud, string rutProveedor)
        {
            return select.Ws02(idSolicitud, rutProveedor);
        }
        [Route("api/ws11/{mes}/{anio}")]
        [HttpGet]
        public ResultadoEvaluacion Ws11(int mes, int anio)
        {
            return select.Ws11(mes, anio);
        }
        [Route("api/ws03")]
        [HttpPost]
        public Info Ws03([FromBody]string value)
        {
            return new Info();
        }
        [Route("api/ws04")]
        [HttpPost]
        public Info Ws04([FromBody]string value)
        {
            return new Info();
        }
        [Route("api/ws05")]
        [HttpPost]
        public Info Ws05([FromBody]string value)
        {
            return new Info();
        }
        [Route("api/ws06")]
        [HttpPost]
        public Info Ws06([FromBody]string value)
        {
            return new Info();
        }
        [Route("api/ws07")]
        [HttpPost]
        public Info Ws07([FromBody]string value)
        {
            return new Info();
        }
        [Route("api/ws08")]
        [HttpPost]
        public Info Ws08([FromBody]string value)
        {
            return new Info();
        }
        [Route("api/ws09")]
        [HttpPost]
        public Info Ws09([FromBody]string value)
        {
            return new Info();
        }
        [Route("api/ws10")]
        [HttpPost]
        public Info Ws10([FromBody]string value)
        {
            return new Info();
        }
    }
}