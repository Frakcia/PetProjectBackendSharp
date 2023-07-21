using System.ComponentModel.DataAnnotations.Schema;

namespace MCH.Domain.Entity
{
  public class Person
  {
    public Guid Id { get; set; }
    public string LastName { get; set; }
    public string? PreviousLastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }

    [NotMapped]
    public string FullName => $"{LastName} {FirstName} {MiddleName}";

    public int SiteId { get; set; }
    public Site Site { get; set; }
    public bool IsActive { get; set; }
  }
}
