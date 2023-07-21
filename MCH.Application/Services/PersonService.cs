using Mapster;
using MCH.Contracts.Services;
using MCH.Infrastructure;
using MCH.Models.DTOs.Person;
using MCH.Models.Filters;
using MCH.Models.Pagination;
using Microsoft.EntityFrameworkCore;

namespace MCH.Application.Services
{
  public class PersonService : IPersonService
  {
    private readonly AppDbContext _dbContext;

    public PersonService(AppDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<PagedCollection<PersonShowDTO>> GetPersonsAsync(PersonFilter filter)
    {
      var personsQuery = _dbContext.Persons
        .Include(e=> e.Site)
        .Select(e => e.Adapt<PersonShowDTO>());

      if (!string.IsNullOrWhiteSpace(filter.SearchString))
      {
        personsQuery = personsQuery.Where(e=> e.FullName.Contains(filter.SearchString));
      }

      var totalCount = personsQuery.Count();
      personsQuery = personsQuery
         .Skip(filter.Skip)
         .Take(filter.PageSize);

      return new PagedCollection<PersonShowDTO>(await personsQuery.ToArrayAsync(), totalCount, filter.PageSize, filter.Page);
    }
  }
}
