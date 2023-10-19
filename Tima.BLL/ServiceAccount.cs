using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tima.DAL;

namespace Tima.BLL
{
    public class ServiceAccount : Service
    {
        public ServiceAccount (string path)
             : base(path)
        {

        }
        public List<Account> GetClientAccounts(int clientId)
        {
            List<Account> accounts = repository.GetAccount(clientId);
            return accounts;
        }
    }
}
