using MCH.Models.DTOs.Person;
using MCH.Models.Filters;
using MCH.Models.Pagination;

namespace MCH.Contracts.Services
{
  public interface IPersonService
  {
    Task<PagedCollection<PersonShowDTO>> GetPersonsAsync(PersonFilter filter);
  }
}
