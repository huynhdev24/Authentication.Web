using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authentication.Domain;
using Authentication.Domain.Entities;

namespace Authentication.Infrastructure.Repositories
{
    public class TaskRepository: GenericRepository<Domain.Entities.Task>, ITaskRepository
    {
        public TaskRepository(ApplicationDbContext context) : base(context) { }
    }
}
