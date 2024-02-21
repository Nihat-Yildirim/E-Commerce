using System.Net;

namespace ServiceCorePackages.ServiceCore.Domain.Response
{
    public record DataResponse<TData> : Response
    {
        public DataResponse(TData? data, HttpStatusCode statusCode, bool success) : base(statusCode, success)
        {
            Data = data;
        }

        public DataResponse(TData? data, HttpStatusCode statusCode, bool success, string message) : base(statusCode, success, message)
        {
            Data = data;
        }

        public DataResponse(HttpStatusCode statusCode, bool success) : base(statusCode, success)
        {

        }

        public DataResponse(HttpStatusCode statusCode, bool success, string message) : base(statusCode, success, message)
        {

        }

        public TData? Data { get; set; }
    }
}