using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tima.DAL
{
    public interface IRepositoryClient
    {
        bool CreateClient(Client client);
        List<Client> GetAllClients();
        Client GetClientById(int id);
        Client GetClient
    }
}
