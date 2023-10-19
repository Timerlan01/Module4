using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tima.DAL
{
    public class RepositoryAccount
    {
        private string path;

        public RepositoryAccount(string path)
        {
            this.path = path;
        }

        public bool CreateAccount(Account account)
        {
            using (var db = new LiteDatabase(@"C:\Temp\MyData.db"))
            {
                var clients = db.GetCollection<Account>("Account");
                clients.Insert(account);
            }
            return true;
        }
        /// <summary>
        /// Метод возвращает список счетов клиентов
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public List<Account> GetAccount(int clientId)
        {
            using (var db = new LiteDatabase(@"C:\Temp\MyData.db"))
            {
                return db.GetCollection<Account>("Account")
                .FindAll().Where(f => f.ClientId == clientId)
                .ToList();



            }
        }
    }
}