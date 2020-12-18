using DataServices.WebAPI.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace DataServices.WebAPI.Extensions
{
    /// <summary>
    /// AppExtensions
    /// </summary>
    public static class AppExtensions
    {
        /// <summary>
        /// UseSwaggerExtension
        /// </summary>
        /// <param name="app"></param>
        public static void UseSwaggerExtension(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "DataServices.WebAPI");
            });
        }
        /// <summary>
        /// UseErrorHandlingMiddleware
        /// </summary>
        /// <param name="app"></param>
        public static void UseErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
