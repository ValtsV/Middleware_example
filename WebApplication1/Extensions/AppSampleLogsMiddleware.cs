namespace WebApplication1.Extensions;

public class AppSampleLogsMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        
            await context.Response.WriteAsync("My middleware");
            await next(context);
    }
}