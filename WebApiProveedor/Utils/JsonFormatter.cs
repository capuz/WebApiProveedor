using System;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;

namespace WebApiProveedor.Utils
{
    public class JsonFormatter : JsonMediaTypeFormatter
    {
        public JsonFormatter()
        {
            this.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }
        /// <summary>
        /// setea la salida de WebApi a formato json
        /// </summary>
        /// <param name="type"></param>
        /// <param name="headers"></param>
        /// <param name="mediaType"></param>
        public override void SetDefaultContentHeaders(Type type, HttpContentHeaders headers, MediaTypeHeaderValue mediaType)
        {
            base.SetDefaultContentHeaders(type, headers, mediaType);
            headers.ContentType = new MediaTypeHeaderValue("application/json");
        }
    }
}