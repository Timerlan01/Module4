using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
namespace Tima.DAL
{
    public class ServiceClient
    {
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
            return null;
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
