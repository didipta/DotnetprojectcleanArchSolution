using Project.Appliction.Interfaces;
using Project.Appliction.Services.CommonResponse;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Appliction.Services.Implementation
{
    public class ProductServices : IGenericService<Product>
    {
        private readonly IRepository<Product> _repository;

        public ProductServices(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<ApiResponse<IEnumerable<Product>>> GetAllAsync()
        {
            var products = await _repository.GetAllAsync(p => p.Brand, p => p.Category);

          if (products == null)
            {
                return new ApiResponse<IEnumerable<Product>>("No products found"); ;
            }

            return new ApiResponse<IEnumerable<Product>>(products,"Products found successfully");
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id, p => p.Brand, p => p.Category);
        }

        public async Task AddAsync(Product entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task UpdateAsync(Product entity)
        {
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }



    }
}
