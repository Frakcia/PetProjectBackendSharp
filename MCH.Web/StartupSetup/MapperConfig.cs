using Mapster;
using MCH.Domain.Entity;
using MCH.Models.DTOs.Person;

namespace MCH.Web.StartupSetup
{
  public static class MapperConfig
  {
    public static IServiceCollection AddMapper(this IServiceCollection services)
    {
      TypeAdapterConfig<Person, PersonShowDTO>
        .ForType()
        .Map(dest => dest.FullName, src => src.FullName)
        .Map(dest => dest.SiteName, src => src.Site.Name);

      return services;
    }
  }
}
