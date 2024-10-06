using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Appliction.Services.CommonResponse
{
    public class ApiResponse<T> 
    {
        public T Data { get; set; }                 // Main response data (could be a list, single object, etc.)
        public bool Success { get; set; } = true;    // Indicates if the operation was successful
        public string Message { get; set; }          // Custom message (optional)
        public PaginationData Pagination { get; set; }  // Pagination metadata (optional)

        // Constructor for non-paginated response
        public ApiResponse(T data, string message = null)
        {
            Data = data;
            Message = message;
        }

        // Constructor for paginated response
        public ApiResponse(T data, PaginationData pagination, string message = null)
        {
            Data = data;
            Pagination = pagination;
            Message = message;
        }

        // Constructor for error responses
        public ApiResponse(string errorMessage)
        {
            Success = false;
            Message = errorMessage;
        }
    }

}
