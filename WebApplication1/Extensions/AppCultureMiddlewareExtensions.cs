using WebApplication1.Extensions;

namespace WebApplication1.Extentions;

public static class AppCultureMiddlewareExtensions
{
    public static IApplicationBuilder UseAppCulture(
        this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<AppCultureMiddleware>();
    }
}