using Microsoft.OpenApi.Models;

namespace SimpleArchitecture.Api.Extensions
{
    public static class ProgramRegistrations
    {
        public static IServiceCollection SimpleArchSwaggerConf(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "SimpleArchitecture.API",
                    Contact = new()
                    {
                        Email = "iamshivamgp@gmail.com",
                        Url = new Uri("https://linkedin.com/in/shivamguptaaa"),
                        Name = "Simple Architecture"
                    }
                });
                options.CustomSchemaIds(type => type.FullName); //Add this to process model names as Full names i.e. name includes parent class
                options.UseApiEndpoints();
            });

            return services;
        }
    }
}
