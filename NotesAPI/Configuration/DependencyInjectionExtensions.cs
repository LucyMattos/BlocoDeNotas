using Microsoft.AspNetCore.Cors.Infrastructure;
using NotesAPI.Business.Interface;
using NotesAPI.Business.Service;
using NotesAPI.Data.Interface;
using NotesAPI.Data.Repository;

namespace NotesAPI.Configuration
{
    public static class DependencyInjectionExtensions
    {
        public static string PolicyName => "Notes_Cors";

        public static void AddDIServices(this IServiceCollection services)
        {
            AddServices(services);
            AddRepositories(services);
            AddNotesCors(services);
        }

        private static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IBlocoDeNotasBusiness, BlocoDeNotasBusiness>();
            services.AddTransient<IBlocoDeNotasItensBusiness, BlocoDeNotasItensBusiness>();
        }

        private static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IBlocoDeNotasRepository, BlocoDeNotasRepository>();
            services.AddTransient<IBlocoDeNotasItensRepository, BlocoDeNotasItensRepository>();
        }

        public static IApplicationBuilder UseNotesCors(this IApplicationBuilder app)
        {
            return app.UseCors(PolicyName);
        }

        private static IServiceCollection AddNotesCors(this IServiceCollection services)
        {
            return services.AddCors(delegate (CorsOptions options)
            {
                options.AddPolicy(PolicyName, delegate (CorsPolicyBuilder p)
                {
                    p.AllowAnyOrigin();
                    p.AllowAnyMethod();
                    p.AllowAnyHeader();
                });
            });
        }
    }
}
