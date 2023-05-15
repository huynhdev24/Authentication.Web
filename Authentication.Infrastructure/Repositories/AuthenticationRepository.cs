using Authentication.Domain;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Infrastructure.Repositories
{
    public class AuthenticationRepository: GenericRepository<IdentityUser>, IAuthenticationRepository
    {
        public AuthenticationRepository(ApplicationDbContext context) : base(context) { }

        public IEnumerable<IdentityUser> getAllUsers()
        {
            return base.All().ToList();
        }
    }
}
