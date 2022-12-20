using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using WebProgramlamaProje.Entity;

namespace WebProgramlamaProje.Repositories
{
	public class API<T> where T: class, new()
	{
		Context context = new Context();

		public List<T> TList()
		{
			return context.Set<T>().ToList();
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
