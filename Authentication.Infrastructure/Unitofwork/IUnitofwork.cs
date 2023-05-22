using Authentication.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Infrastructure.Unitofwork
{
    public interface IUnitofwork: IDisposable
    {
        IAuthenticationRepository Authentication { get; }
        ITodoRepository Todo { get; }
        ITaskRepository Task { get; }
        void SaveChanges();
    }
}
