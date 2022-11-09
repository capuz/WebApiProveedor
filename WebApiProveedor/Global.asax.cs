using System.Net;
using System.Web.Http;

namespace WebApiProveedor
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            if (!Utils.ConfigWrapper.Value<bool>("ServerCertificateValidation"))
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
        }
    }
}
