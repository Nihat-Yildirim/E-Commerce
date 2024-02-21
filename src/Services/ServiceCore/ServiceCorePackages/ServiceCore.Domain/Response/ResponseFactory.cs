using System.Net;

namespace ServiceCorePackages.ServiceCore.Domain.Response
{
    public static class ResponseFactory
    {
        public static Response Success(HttpStatusCode statusCode)
            => new(statusCode, true);

        public static Response Success(HttpStatusCode statusCode, string message)
            => new(statusCode, true, message);

        public static Response Fail(HttpStatusCode statusCode)
            => new(statusCode, false);

        public static Response Fail(HttpStatusCode statusCode, string message)
            => new(statusCode, false, message);

        public static DataResponse<TData> Success<TData>(HttpStatusCode statusCode)
            => new(default, statusCode, true);

        public static DataResponse<TData> Success<TData>(HttpStatusCode statusCode, TData? data)
            => new(data, statusCode, true);

        public static DataResponse<TData> Success<TData>(HttpStatusCode statusCode, string message)
            => new(default, statusCode, true, message);

        public static DataResponse<TData> Success<TData>(HttpStatusCode statusCode, TData? data, string message)
            => new(data, statusCode, true, message);

        public static DataResponse<TData> Fail<TData>(HttpStatusCode statusCode)
            => new(statusCode, false);

        public static DataResponse<TData> Fail<TData>(HttpStatusCode statusCode, string message)
            => new(statusCode, false, message);
    }
}