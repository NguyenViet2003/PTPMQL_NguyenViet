using System;

namespace MVC2.Models
{
    public class Employee : Person
    {
        public string EmployeeId { get; set; }
        public int Age { get; set; }

        public new void EnterData()
        {
            base.EnterData();
            Console.WriteLine("Nhập EmployeeId:");
            EmployeeId = Console.ReadLine();
            Console.WriteLine("Nhập Age:");
            Age = int.Parse(Console.ReadLine());
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine($"EmployeeId: {EmployeeId}");
            Console.WriteLine($"Age: {Age}");
        }
    }
}