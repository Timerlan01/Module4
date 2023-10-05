using System;
using System.Collections.Generic;
using Tima.DAL;

namespace Module4
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServiceClient service = new ServiceClient();
            
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Регистрация");
            Console.WriteLine("2. Авторизация");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Client newClient = new Client();

                Console.WriteLine("Введите иин:");
                newClient.Iin = Console.ReadLine();

                Console.WriteLine("Введите почту:");
                newClient.Email = Console.ReadLine();

                Console.WriteLine("Введите фамилию:");
                string Fname = Console.ReadLine();

                Console.WriteLine("Введите имя:");
                string Sname = Console.ReadLine();

                Console.WriteLine("Введите отчество:");
                string Mname = Console.ReadLine();

                service.CreateClient(newClient);

            }
            else if (choice == "2")
            {
                Console.WriteLine("Введите логин:");
                string login = Console.ReadLine();

                Console.WriteLine("Введите пароль:");
                string password = Console.ReadLine();

                Console.WriteLine("Авторизация успешна.");

                Client findClient = service.GetClient(login, password);


            }

            Client client = new Client();
            client.Iin = "04101050105";
            client.Email = "alimbekovtimerlan@gmail.com";
            client.Fname = "Alimbekov";
            client.Sname = "Timerlan";
            client.Mname = "Tursunovych";

            client.CreateDate = new DateTime(2004, 10, 10);
           
            /// service.CreateClient(client);
            List<Client> clients = service.GetAllClients();
            foreach (Client item in clients)
            {
                Console.WriteLine("{0}. {1}", item.Id, item.Getshortname);
            }

        }
    }
}
