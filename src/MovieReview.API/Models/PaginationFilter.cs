namespace MovieReview.API.Models
{
    public class PaginationFilter
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public PaginationFilter()
        {
            PageIndex = 1;
            PageSize = 10;
        }
        public PaginationFilter(int pageIndex, int pageSize)
        {
            PageIndex = pageIndex < 1 ? 1 : pageIndex;
            PageSize = pageSize > 10 ? 10 : pageSize;
        }
    }
}
