using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authentication.Domain.Entities;

namespace Authentication.Infrastructure.Repositories
{
    public interface ITaskRepository: IGenericRepository<Domain.Entities.Task>
    {
    }
}
