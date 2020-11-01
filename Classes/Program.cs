using Classes.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args) // behavior: davranış
        {
            Person insan; // declaration
            insan = new Person(); // insan obje haline gelir.
            insan.Run();
            CustomerService customerService = new CustomerService(); // new leme işlemine initialization denir = oluşturmak // customerService: object, instance denir.
            customerService.Add();
            customerService.Update();
            customerService.Delete();
            var productService = new ProductService();
            productService.Add();
            productService.Update();
            productService.Delete();
            EmployeeService employeeService = new EmployeeService();
            employeeService.List();
            Customer customer = new Customer();
            customer.SetName("Özcan");
            Console.WriteLine(customer.GetName());
            customer.Surname = "Nakkaş";
            Console.WriteLine(customer.Surname);
            customer.Age = 35;
            Console.WriteLine(customer.Age);
            // customer.country yerine encapsulation yapılmalı.
            Customer customer2 = new Customer() // ; koyulmaz
            {
                Id = 2,
                Surname = "Nakkaş",
                Age = 35,
                City = "Ankara"
            };
            customer2.SetName("Özcan");
            var customer3 = new Customer()
            {
                Id = 3,
                Surname = "DeNiro",
                Age = 75,
                City = "Los Angeles"
            };
            customer3.SetName("Robert");
            string customerInfo = "ID: " + customer3.Id + "\n";
            customerInfo += "Name: " + customer3.GetName() + "\n";
            customerInfo += "Surname: " + customer3.Surname + "\n";
            customerInfo += "Age: " + customer3.Age + "\n";
            customerInfo += "City: " + customer3.City;

            // null bağı kopartır
            customer3 = null;
            string ad = null; // ad=    ""; ile aynı şey değil.
            Console.WriteLine(ad);
            int[] sayilar = null;

            Console.WriteLine(customerInfo);

            Console.ReadLine();
        }
    }

    class Person
    {
        public void Run() // behavior: davranış
        {
            Console.WriteLine("Running...");
        }
    }

    class CustomerService
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void Update()
        {
            Console.WriteLine("Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted");
        }
    }

    class ProductService
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void Update()
        {
            Console.WriteLine("Updated");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted");
        }
    }
}
