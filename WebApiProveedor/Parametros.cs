using System.Configuration;
namespace WebApiProveedor
{
    public static class Parametros
    {
        public static string USUARIOALT =ConfigurationManager.AppSettings["USUARIOALT"];
        public static string TERMINALALT = ConfigurationManager.AppSettings["TERMINALALT"];
        public static string CANALID = ConfigurationManager.AppSettings["CANALID"];
        public static string MWPECDGENT = ConfigurationManager.AppSettings["MWPECDGENT"];
        public static string MWPETIPDOC = ConfigurationManager.AppSettings["MWPETIPDOC"];
        public static string MWPEESTREL = ConfigurationManager.AppSettings["MWPEESTREL"];
        public static string MWKPCODCNL = ConfigurationManager.AppSettings["MWKPCODCNL"];
        public static string MWKPCODTPOCRU = ConfigurationManager.AppSettings["MWKPCODTPOCRU"];
    }
}