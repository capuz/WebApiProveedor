using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiProveedor.Models.DTO
{
    public class Solicitud
    {
        public int TAS_ID { get; set; }
        public string NOM_CALLE { get; set; }
        public string NUM_CALLE { get; set; }
        public int COM_ID { get; set; }
        public int REG_ID { get; set; }
        public string COMUNA_DESC { get; set; }
        public string REGION_DESC { get; set; }
        public string ROL { get; set; }
        public int RUB_ID { get; set; }
        public int GRU_ID { get; set; }
        public string RUBRO { get; set; }
        public string GRUPO { get; set; }
        public DateTime? FECHA_ASIGNACION { get; set; }
        public decimal? LATITUD { get; set; }
        public decimal? LONGITUD { get; set; }
        public string RUT_SOLICITANTE { get; set; }
        public string NOM_SOLICITANTE { get; set; }
        public string RUT_EJECUTIVO { get; set; }
        public string NOM_EJECUTIVO { get; set; }
        public string NOM_CONTACTO { get; set; }
        public string EMAIL_CONTACTO { get; set; }
        public string FONO_CONTACTO1 { get; set; }
        public string FONO_CONTACTO2 { get; set; }
    }
}