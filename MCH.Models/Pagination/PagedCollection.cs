namespace MCH.Models.Pagination
{
  public class PagedCollection<T>
  {
    public PagedCollection(IEnumerable<T> items, int totalCount, int pageSize, int page)
    {
      Items= items;
      TotalCount=totalCount;
      PageSize=pageSize;
      Page=page;
    }
    public IEnumerable<T> Items { get; }
    public int TotalCount { get;}
    public int PageSize { get; }
    public int Page { get; }

    //public static async Task<PagedCollection<T>> CreateAsycn(IQueryable<T> query, BaseFilter filter)
    //{
    //  var totalCount = query.Count();
    //  var items = query
    //    .Skip(filter.Skip)
    //    .Take(filter.PageSize)
    //    .ToArrayAsync();

    //  return new(items, page, pageSize, totalCount);
    //}
  }
}
