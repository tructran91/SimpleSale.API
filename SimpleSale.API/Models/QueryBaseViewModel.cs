using SimpleSale.Application.DTOs;

namespace SimpleSale.API.Models
{
    public class QueryBaseViewModel
    {
        public string? SearchKeyword { get; set; }

        public string? SortColumn { get; set; }

        public SortDirection SortDirection { get; set; }

        public int? PageSize { get; set; }

        public int? PageNumber { get; set; }
    }
}
