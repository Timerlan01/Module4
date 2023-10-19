using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
namespace Tima.DAL
{
    public class RepositoryClient
    {
        private readonly string path;
        public RepositoryClient(string path)
        {
            this.path = path;
        }

        public RepositoryClient()
        {
        }

        public bool CreateClient(Client client)
        {
            using (var db = new LiteDatabase(@"C:\Temp\MyData.db"))
            {
                var clients = db.GetCollection<Client>("Client");
                clients.Insert(client);
            }
            return true;
        }
        public List<Client> GetAllClients()
        {
            using (var db = new LiteDatabase(@"C:\Temp\MyData.db"))
            {
                return db.GetCollection<Client>("Client")
                .FindAll()
                    .ToList();

            }

        }
        public Client GetClientById(int id)
        {
            Client client = null;
            using (var db = new LiteDatabase(@"C:\Temp\MyData.db"))
            {
                {
                  client = db.GetCollection<Client>()
                  .FindById(id);
                }
            }
            return client;
        }

        public Client GetClient(string login, string password)
        {
            using (var db = new LiteDatabase(@"C:\Temp\MyData.db"))
            {
                return db.GetCollection<Client>("Client")
                .FindAll().First(f => f.Login == login && f.Password == password);
            }
        }
    }
}
