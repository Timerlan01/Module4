using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tima.DAL;

namespace Tima.BLL
{
    public abstract class Service
    {
        protected readonly IRepositoryClient service = null;
        protected readonly IRepositoryAccount repository = null;
       
        private readonly string path;
        public Service(string path)
        {
            this.path = path;
            service = new RepositoryClient(path); 
            repository = new RepositoryAccount(path);
        }
    }

}
