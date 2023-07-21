using MCH.Application.Services;
using MCH.Contracts.Services;

namespace MCH.Web.StartupSetup
{
  public static class DependencyInjectionConfig
  {
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
      services.AddScoped<IPersonService, PersonService>();

      return services;
    }
  }
}
