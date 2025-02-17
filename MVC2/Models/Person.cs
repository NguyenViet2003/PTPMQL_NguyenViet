using System;

namespace MVC2.Models
{
    public class Person
    {
        public string PersonId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }

        public void EnterData()
        {
            Console.WriteLine("Nhập PersonId:");
            PersonId = Console.ReadLine();
            Console.WriteLine("Nhập FullName:");
            FullName = Console.ReadLine();
            Console.WriteLine("Nhập Address:");
            Address = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine($"PersonId: {PersonId}");
            Console.WriteLine($"FullName: {FullName}");
            Console.WriteLine($"Address: {Address}");
        }
    }
}