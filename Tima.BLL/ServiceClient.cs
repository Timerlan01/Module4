﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Tima.DAL;

namespace Tima.BLL
{
    public class ServiceClient : Service
    {
        private readonly RepositoryClient service = null;
        private readonly string path;
        public ServiceClient(string path)
            :base(path)
        {
            this.path = path;
            service = new RepositoryClient(path);
        }
        public bool Registration(Client client)
        {
           
            bool result = service.CreateClient(client);

            return result;
        }
        public Client Auth(string login, string password)
        {
            if (login == "" || password == "")
                return null;
            RepositoryClient service = new RepositoryClient();
            Client client = service.GetClient(login, password);
            return client;
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       