using System;
using System.Collections.Generic;
using TheStore.BL;
using TheStore.BL.Models;
using TheStore.BL.Repositories;
using TheStore.BL.Repositories.SQL;
using TheStore.BL.Services;

namespace TheStore.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hello World!");

            ICustomerRepository repository = null;
            var menu = 1;
            System.Console.WriteLine("Introduce 1 si quiere trabajar con RepositoryList\no 2 si quiere trabajar con RepositorySQL");
            menu = int.Parse(System.Console.ReadLine());
            //Con esto podemos trabajar con diferentes respositorios en tiempo de ejecución. Fijemonos cómo utilizamos la 
            //interfaz ICustomerRepository para que podamos invocar los métodos y, utilizando el concepto de polimorfismo,
            //se ejecutarán los métodos de un repositorio u otro según el tipo de repositorio escogido por el cliente

            switch (menu)
            {
                case 1: repository = new CustomerRepositoryList();
                    break;
                case 2: repository = new CustomerRepositorySQL();
                    break;
            }


            var customer1 = new SilverCustomer()
            {
                Id = 5,
                Name = "Enrico",
                Addresses = new List<Address>()
                {
                    new Address()
                    {
                        Id = 1,
                        City = "Barcelona",
                        Country = "España",
                        Line1 = "Calle de prueba 111",
                        Line2 = "1-1",
                        PostalCode = "08030",
                        State = "Cataluña"
                    }
                },
                Email = "enrico.prueba@hotmail.com",
                RemainingPurchases = 10
            };
            var customer2 = new SilverCustomer()
            {
                Id = 6,
                Name = "Anais",
                Addresses = new List<Address>()
                {
                    new Address()
                    {
                        Id = 2,
                        City = "Barcelona",
                        Country = "España",
                        Line1 = "Avenida de prueba 111",
                        Line2 = "1-1",
                        PostalCode = "08030",
                        State = "Cataluña"
                    }
                },
                Email = "anais.prueba@hotmail.com",
                RemainingPurchases = 10
            };
            var customer3 = new SilverCustomer()
            {
                Id = 7,
                Name = "Angelo",
                Addresses = new List<Address>()
                {
                    new Address()
                    {
                        Id = 1,
                        City = "Turin",
                        Country = "Italia",
                        Line1 = "Via di prova 111",
                        Line2 = "1-1",
                        PostalCode = "08030",
                        State = "Cataluña"
                    }
                },
                Email = "angelo.prueba@hotmail.com",
                RemainingPurchases = 10
            };
            var customer4 = new GoldCustomer()
            {
                Id = 8,
                Name = "Arturo",
                Addresses = new List<Address>()
                {
                    new Address()
                    {
                        Id = 1,
                        City = "Marxuquera",
                        Country = "España",
                        Line1 = "Via di prova 111",
                        Line2 = "1-1",
                        PostalCode = "08030",
                        State = "Cataluña"
                    }
                },
                Email = "arturo.prueba@hotmail.com",
                Discount = 10,
                DiscountCupons=new List<string>
                {
                    "AHGDI541528nde",
                    "445djKJNDLKGY5"
                }
            };
            repository.Save(customer1);
            repository.Save(customer2);
            repository.Save(customer3);
            repository.Save(customer4);

            var customers = repository.GetAll();
            foreach (var customer in customers)
            {
                string tipoCliente = customer.GetType().ToString();
                tipoCliente = tipoCliente.Replace("TheStore.BL.Models.", "");
                System.Console.WriteLine($"el cliente {customer.Name} con id {customer.Id} es un cliente de tipo {tipoCliente}");
            }
            System.Console.ReadLine();
        }
    }
}
