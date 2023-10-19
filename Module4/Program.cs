using System;
using System.Collections.Generic;
using Tima.BLL;
using Tima.DAL;
using Tima.DAL.Enum;

namespace Module4
{
    public class Program
    {
        public static ServiceClient service = new ServiceClient();
        static void Main(string[] args)
        {
           
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Регистрация");
            Console.WriteLine("2. Авторизация");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Client newClient = new Client();

                Console.Write("Введите иин:");
                newClient.Iin = Console.ReadLine();

                Console.Write("Введите почту:");
                newClient.Email = Console.ReadLine();

                Console.Write("Введите фамилию:");
                newClient.Fname = Console.ReadLine();

                Console.Write("Введите имя:");
                newClient.Sname = Console.ReadLine();

                Console.Write("Введите отчество:");
                newClient.Mname = Console.ReadLine();

                Console.Write("Введите логин:");
                newClient.Login = Console.ReadLine();

                Console.Write("Введите пароль");
                newClient.Password= Console.ReadLine();

                Gender gen;
                for (gen = Gender.female; gen <= Gender.male; gen++)
                {
                    Console.WriteLine($"{ (int)gen}.
                       { gen.ToString()}");
                }
               string genCh = Console.ReadLine();
                    newClient.Gender = Gender.male;

                bool result = service.Registration(newClient);
                if(result = true)
                {
                    Console.Write("Успешно создан");
                }

            }
            else if (choice == "2")
            {
                Console.Write("Введите логин:");
                string login = Console.ReadLine();

                Console.Write("Введите пароль:");
                string password = Console.ReadLine();

               
                Client client = service.Auth(login, password);
                if (client != null)
                {
                    Console.Clear();//cls
                    Console.Write("ПРиветсвую тебя {0}",client.Getshortname);
                }
                else
                {
                    Console.Write("Авторизация не прошла!");
                }

            }
            Console.ReadKey();
        }
    }
}
