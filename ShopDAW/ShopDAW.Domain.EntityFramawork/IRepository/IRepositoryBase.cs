using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAW.Domain.EntityFramework.IRepository
{
	public interface IRepositoryBase<T> where T : class
	{

		Task<List<T>> GetAllAsync();
		Task<T> GetByIdAsync(int id);
		Task<List<T>> GetByCondition(Expression<Func<T, bool>> expression);
		Task<T> CreateAsync(T entity);
		T Update(T entity);
		T Delete(T entity);
	}
}