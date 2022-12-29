using System.Linq.Expressions;

namespace WebProgramlamaProje.Repositories.Abstract
{
	public interface IGnericRepository
	{
		public interface IBaseRepository<T>
		{
			IQueryable<T> GetAll();
			IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
			T? FindById(int id);
			bool Create(T entity);
			bool Update(T entity);
			bool Delete(T entity);
		}
	}
}
