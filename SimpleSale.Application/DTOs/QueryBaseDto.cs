namespace SimpleSale.Application.DTOs
{
    public class QueryBaseDto
    {
        public string? SearchKeyword { get; set; }

        public string? SortColumn { get; set; }

        public SortDirection SortDirection { get; set; }

        public int PageSize { get; set; }

        public int PageNumber { get; set; }
    }

    public enum SortDirection
    {
        Ascending,
        Descending
    }
}
