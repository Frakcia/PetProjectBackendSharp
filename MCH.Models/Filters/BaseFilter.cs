namespace MCH.Models.Filters
{
  public class BaseFilter
  {
    public int Page { get; set; }
    public int PageSize { get; set; }
    public string SearchString { get; set; }
   // public SortOrder SortOrder { get; set; }
    //public string? SortColumn { get; set; }
    public int Skip => (Page - 1) * PageSize;
  }
}
