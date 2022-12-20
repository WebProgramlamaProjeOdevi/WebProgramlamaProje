using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using WebProgramlamaProje.Entity;

namespace WebProgramlamaProje.Repositories
{
	public class GenericRepository<T> where T: class, new()
	{
		Context context = new Context();
		
		public List<T> TList()
		{
			return context.Set<T>().ToList();
		}
		public List<T> List(Expression<Func<T, bool>> where)
		{
			return context.Set<T>().Where(where).ToList();
		}
		public void TAdd(T item)
		{
			context.Set<T>().Add(item);
			context.SaveChanges();
		}
		public void TUpdate(T item)
		{
			context.Set<T>().Update(item);
			context.SaveChanges();
		}
		public void TDelete(T item)
		{
			context.Set<T>().Remove(item);
			context.SaveChanges();
		}
		public void TGetById(int id)
		{
			context.Set<T>().Find(id);
		}      
           
        public List<T> TList(string item)
		{
			return context.Set<T>().Include(item).ToList();
		}      
    }		
}
