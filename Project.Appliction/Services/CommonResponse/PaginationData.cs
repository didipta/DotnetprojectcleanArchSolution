using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Appliction.Services.CommonResponse
{
    public class PaginationData
    {
        public int CurrentPage { get; set; }         // Current page number
        public int PageSize { get; set; }            // Number of items per page
        public int TotalItems { get; set; }          // Total items across all pages
        public int TotalPages { get; set; }          // Total number of pages

        // Constructor
        public PaginationData(int currentPage, int pageSize, int totalItems)
        {
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalItems = totalItems;
            TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize);
        }
    }

}
