using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ShopDAW.Domain.EntityFramawork;
using ShopDAW.Domain.EntityFramework.IRepository;
using ShopDAW.Domain.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ShopDAW.Domain.EntityFramework.Repository
{
	public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity
	{

		private readonly ShopDBContext _context;

		public RepositoryBase(ShopDBContext context)
		{

			_context = context;

		}

		public async Task<List<T>> GetAllAsync()
		{
			return await _context.Set<T>().ToListAsync();
		}

		public async Task<T> GetByIdAsync(int id)
		{
			return await _context.Set<T>().FirstOrDefaultAsync(c => c.Id == id);
		}

		public async Task<List<T>> GetByCondition(Expression<Func<T, bool>> expression)
		{
			return await _context.Set<T>().Where(expression).ToListAsync();
		}

		public async Task<T> CreateAsync(T entity)
		{
			EntityEntry<T> result = await _context.Set<T>().AddAsync(entity);
			return result.Entity;
		}

		public T Update(T entity)
		{
			EntityEntry<T> result = _context.Set<T>().Update(entity);
			return result.Entity;
		}

		public T Delete(T entity)
		{
			EntityEntry<T> result = _context.Set<T>().Remove(entity);
			return result.Entity;
		}

	}
}
