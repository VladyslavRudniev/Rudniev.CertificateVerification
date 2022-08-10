using CertificateService.EF;

namespace CertificateService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options => 
            {
                options.AddPolicy(name: "AllowOrigin",
                builder =>
                {
                    builder.WithOrigins("http://localhost:8080")
                    .WithHeaders("content-type")
                    .WithMethods("POST", "GET")
                    .AllowCredentials();
                });
            });
            builder.Services.AddDbContext<ApplicationDbContext>();
            builder.Services.AddControllers();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors("AllowOrigin");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.Run();
        }
    }
}