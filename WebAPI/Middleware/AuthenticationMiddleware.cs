namespace WebAPI.Middleware;

public class AuthenticationMiddleware
{
    private readonly RequestDelegate _next;
    private const string TokenKey = "token";

    public AuthenticationMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        if (context.Request.Headers["Authorization"] != ("Bearer " + TokenKey))
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("Unauthorized");
            return;
        }
        await _next(context);
    }
}