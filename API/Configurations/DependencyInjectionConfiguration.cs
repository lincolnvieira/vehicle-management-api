using Infrastructure.Repositories;

namespace API.Configurations
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped<VehicleRepository>();
        }
    }
}
