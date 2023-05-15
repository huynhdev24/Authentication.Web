using Authentication.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Infrastructure.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public T Add(T entity)
        {
            return context
                .Add(entity)
                .Entity;
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>()
                .AsQueryable()
                .Where(predicate).ToList();
        }

        public T Get(Guid id)
        {
            return context.Find<T>(id);
        }

        public IEnumerable<T> All()
        {
            return context.Set<T>()
                .ToList();
        }

        public T Update(T entity)
        {
            return context.Update(entity)
                .Entity;
        }
    }
}
