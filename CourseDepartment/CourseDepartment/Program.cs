using System;
using CourseDepartment.Entities.Enums;
using CourseDepartment.Entities;

namespace CourseDepartment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enteder department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            string workerLevel = Console.ReadLine();
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
            Department dept = new Department(deptName, "D001");
            Worker worker = new Worker(workerName, Enum.Parse<WorkerLevel>(workerLevel), baseSalary, dept);
            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter contract #{i} data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month):C}");
            Console.WriteLine(
                "\nPress any key to exit..."
            );
            Console.ReadKey();
            Console.WriteLine(
                "\nExiting..."
            );
            Console.WriteLine(
                "Goodbye!"
            );


        }
    }
}