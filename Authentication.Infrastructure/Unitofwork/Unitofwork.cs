using Authentication.Domain;
using Authentication.Domain.Entities;
using Authentication.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Infrastructure.Unitofwork
{
    public class Unitofwork: IUnitofwork
    {
        private ApplicationDbContext context;

        public Unitofwork(ApplicationDbContext context)
        {
            this.context = context;
            Authentication = new AuthenticationRepository(this.context);
            Todo = new TodoRepository(this.context);
            Task = new TaskRepository(this.context);
        }

        public IAuthenticationRepository Authentication
        {
            get;
            private set;
        }

        public ITodoRepository Todo
        {
            get;
            private set;
        }

        public ITaskRepository Task
        {
            get;
            private set;
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
