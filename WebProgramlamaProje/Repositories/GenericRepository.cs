using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using WebProgramlamaProje.Entity;

namespace WebProgramlamaProje.Repositories
{
    public class GenericRepository<T> where T : class, new()
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

        public T Find(Expression<Func<T, bool>> where)
        {
            return context.Set<T>().FirstOrDefault(where);
        }

        public int TAdd(T item)
        {
            context.Set<T>().Add(item);
            return context.SaveChanges();
        }
        public int TUpdate(T item)
        {
            context.Set<T>().Update(item);
            return context.SaveChanges();
        }
        public int TDelete(T item)
        {
            context.Set<T>().Remove(item);
            return context.SaveChanges();
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
