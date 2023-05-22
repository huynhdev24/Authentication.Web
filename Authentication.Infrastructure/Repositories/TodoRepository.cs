using Authentication.Domain;
using Authentication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Infrastructure.Repositories
{
    public class TodoRepository: GenericRepository<Todo>, ITodoRepository
    {
        public TodoRepository(ApplicationDbContext context) : base(context) { }
    }
}
