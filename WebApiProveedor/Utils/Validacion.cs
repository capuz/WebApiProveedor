using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace WebApiProveedor.Utils
{
    public static class Validacion
    {
        public static bool Email(string email)
        {
            if (string.IsNullOrEmpty(email) || email.Trim().Length == 0)
                return false;
            else
                return new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,6}$").IsMatch(email);
        }

        public static void FechaUf(string fecha)
        {
            try
            {
                DateTime.ParseExact(fecha, "dd-MM-yyyy", new CultureInfo("es-CL"));
            }
            catch (Exception)
            {
                throw new Exception(string.Format("Fecha '{0}' no cumple el formato solicitado", fecha));
            }
        }
    }
}