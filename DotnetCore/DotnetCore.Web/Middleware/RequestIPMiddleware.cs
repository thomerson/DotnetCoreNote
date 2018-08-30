using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace DotnetCore.Web
{
    /// <summary>
    /// 请求IP中间件
    /// </summary>
    public class RequestIPMiddleware
    {
        private readonly RequestDelegate _next; //定义请求委托
        private readonly ILogger _logger; //定义日志

        public RequestIPMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<RequestIPMiddleware>();
        }


    }
}
