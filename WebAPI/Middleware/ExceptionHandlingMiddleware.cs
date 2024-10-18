using System.Net;
using BusinessLayer.Exceptions;

namespace WebAPI.Middleware;

public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (NotFoundException ex)
        {
            await HandleExceptionAsync(context, ex, HttpStatusCode.NotFound);
        }
        catch (UserOperationException ex)
        {
            await HandleExceptionAsync(context, ex, HttpStatusCode.Conflict);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex, HttpStatusCode.InternalServerError);
        }
    }

    private Task HandleExceptionAsync(HttpContext context, Exception ex, HttpStatusCode statusCode)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)statusCode;

        var result = new
        {
            message = statusCode == HttpStatusCode.InternalServerError
                ? "An error occurred while processing your request."
                : ex.Message,
        };

        return context.Response.WriteAsJsonAsync(result);
    }
}
