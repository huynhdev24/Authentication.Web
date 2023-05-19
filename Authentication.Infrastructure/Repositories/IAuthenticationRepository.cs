using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Infrastructure.Repositories
{
    public interface IAuthenticationRepository: IGenericRepository<IdentityUser>
    {
        Task<IEnumerable<IdentityUser>> GetAllUsers();
    }
}
