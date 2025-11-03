
using UNI.Repository;
using UNI.Services;

namespace UNI.WebApi
{
    public static class ExtensionServices
    {
        public static void ConfigureSql(this IServiceCollection service, IConfiguration configure)
        {
            service.AddDbContext<UNIDbContext>(x => {
                x.UseNpgsql(configure.GetConnectionString("PostgresqlDbContext"));
            });
        }

        public static void ConfigureAddScopd(this IServiceCollection service)
        {
            service.AddScoped<UNIDapperContext>();
            service.AddScoped<IUnitofWork, UnitofWork>();
            service.AddScoped<IServiceManager, ServicesManager>();
        }

        public static void ConfigureMapper(this IServiceCollection service)
        {
            service.AddAutoMapper(cfg =>
            {
                cfg.AddProfile(new MapperInitial());
            });
        }
    }
}
