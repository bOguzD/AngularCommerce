using System;
using Microsoft.OpenApi.Models;

namespace API.Extensions
{
    public static class SwaggerServiceExtensions 
    {
        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services){
            services.AddSwaggerGen(x => {
                x.SwaggerDoc("v1", new OpenApiInfo {Title ="API", Version ="v1"});
            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerDocumention(this IApplicationBuilder app){
            
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
                c.RoutePrefix ="";
            });

            return app;
        }
    }
}
