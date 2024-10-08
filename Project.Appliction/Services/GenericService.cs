﻿using Project.Appliction.Interfaces;
using Project.Appliction.Services.CommonResponse;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Appliction.Services
{
    public class GenericService<T> : IGenericService<T> where T : BaseEntity
    {
        private readonly IRepository<T> _repository;

        public GenericService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<ApiResponse<IEnumerable<T>>> GetAllAsync()
        {
            var data = await _repository.GetAllAsync();
            return new ApiResponse<IEnumerable<T>>(data, "Products found successfully");
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }

}
