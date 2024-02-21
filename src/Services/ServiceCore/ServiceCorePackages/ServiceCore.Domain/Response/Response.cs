using System.Net;

namespace ServiceCorePackages.ServiceCore.Domain.Response
{
    public record Response
    {
        public Response(HttpStatusCode httpStatus, bool success)
        {
            StatusCode = httpStatus;
            Success = success;
        }

        public Response(HttpStatusCode statusCode, bool success, string message) : this(statusCode, success)
        {
            Message = message;
        }

        public bool Success { get; set; }
        public string? Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}