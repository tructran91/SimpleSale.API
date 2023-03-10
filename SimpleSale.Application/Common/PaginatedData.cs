namespace SimpleSale.Application.Common
{
    /// <summary>
    /// https://jasonwatmore.com/post/2018/10/17/c-pure-pagination-logic-in-c-aspnet
    /// </summary>
    /// <typeparam name="TData"></typeparam>
    public class PaginatedData<TData>
    {
        public IEnumerable<TData> Data { get; set; }

        // 150
        public int TotalItems { get; private set; }

        // 7
        public int CurrentPage { get; private set; }

        // 15
        public int PageSize { get; private set; }

        // 10
        public int TotalPages { get; private set; }

        // 5
        public int StartPage { get; private set; }

        // 9
        public int EndPage { get; private set; }

        // 90
        public int StartIndex { get; private set; }

        // 104
        public int EndIndex { get; private set; }

        // [ 5, 6, 7, 8, 9 ]
        public IEnumerable<int> Pages { get; private set; }

        public PaginatedData(IEnumerable<TData> data, int totalItems, int currentPage = 1, int pageSize = 10, int maxPages = 10)
        {
            // calculate total pages
            var totalPages = (int)Math.Ceiling(totalItems / (decimal)pageSize);

            // ensure current page isn't out of range
            if (currentPage < 1)
            {
                currentPage = 1;
            }
            else if (currentPage > totalPages)
            {
                currentPage = totalPages;
            }

            int startPage, endPage;
            if (totalPages <= maxPages)
            {
                // total pages less than max so show all pages
                startPage = 1;
                endPage = totalPages;
            }
            else
            {
                // total pages more than max so calculate start and end pages
                var maxPagesBeforeCurrentPage = (int)Math.Floor(maxPages / (decimal)2);
                var maxPagesAfterCurrentPage = (int)Math.Ceiling(maxPages / (decimal)2) - 1;
                if (currentPage <= maxPagesBeforeCurrentPage)
                {
                    // current page near the start
                    startPage = 1;
                    endPage = maxPages;
                }
                else if (currentPage + maxPagesAfterCurrentPage >= totalPages)
                {
                    // current page near the end
                    startPage = totalPages - maxPages + 1;
                    endPage = totalPages;
                }
                else
                {
                    // current page somewhere in the middle
                    startPage = currentPage - maxPagesBeforeCurrentPage;
                    endPage = currentPage + maxPagesAfterCurrentPage;
                }
            }

            // calculate start and end item indexes
            var startIndex = (currentPage - 1) * pageSize;
            var endIndex = Math.Min(startIndex + pageSize - 1, totalItems - 1);

            // create an array of pages that can be looped over
            var pages = Enumerable.Range(startPage, endPage + 1 - startPage);

            // update object instance with all pager properties required by the view

            Data = data;
            TotalItems = totalItems;
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalPages = totalPages;
            StartPage = startPage;
            EndPage = endPage;
            StartIndex = startIndex;
            EndIndex = endIndex;
            Pages = pages;
        }
    }
}
