using Project.Appliction.Interfaces;
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

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _repository.GetAllAsync(p => p.Brand, p => p.Category);
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
