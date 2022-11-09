using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiProveedor.Models.DTO
{
    public class Info
    {
        public Info()
        {
            DESC_TERMINO = "OK";
            COD_TERMINO = 0;
        }
        public int COD_TERMINO { get; set; }
        public string DESC_TERMINO { get; set; }
    }
}