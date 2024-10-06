using Project.Appliction.Services.CommonResponse;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Appliction.Interfaces
{
    public interface IGenericService<T> where T : BaseEntity
    {
        Task<ApiResponse<IEnumerable<T>>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
