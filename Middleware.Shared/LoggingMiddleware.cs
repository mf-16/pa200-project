using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Middleware;

public class LoggingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<LoggingMiddleware> _logger;
    private readonly string _source;

    public LoggingMiddleware(RequestDelegate next, ILogger<LoggingMiddleware> logger, string source)
    {
        _next = next;
        _logger = logger;
        _source = source;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        _logger.LogInformation(
            $"Source: {_source} received request: {context.Request.Method} {context.Request.Path} {context.Request.QueryString}"
        );
        await _next(context);
    }
}
