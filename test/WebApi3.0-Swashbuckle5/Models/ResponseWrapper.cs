using System.Net;

namespace WebApi30_Swashbuckle5.Models
{
    public class ResponseWrapper<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public T Body { get; set; }
    }
}