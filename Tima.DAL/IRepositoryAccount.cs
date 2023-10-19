using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tima.DAL
{
    public interface IRepositoryAccount
    {
        bool CreateAccount(Account account);
        List<Account> GetAccounts(int clientid);
    }
}
