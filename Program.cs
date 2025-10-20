using System;
using System.Collections.Generic;
using System.Linq;

namespace All
{
    class Program
    {
        static void Main()
        {
         
            var europe = new Region { Id = 1, Name = "Europe" };
            var asia = new Region { Id = 2, Name = "Asia" };

     
            var ukraine = new Country { Id = 1, Name = "Ukraine", Region = europe };
            var japan = new Country { Id = 2, Name = "Japan", Region = asia };

   
            var lviv = new Location { Id = 1, Address = "Shevchenka 10", City = "Lviv", Country = ukraine };
            var tokyo = new Location { Id = 2, Address = "Shibuya 5", City = "Tokyo", Country = japan };

   
            var dep20 = new Department { Id = 20, Name = "Marketing", ManagerId = 1, Location = lviv };
            var dep30 = new Department { Id = 30, Name = "Finance", ManagerId = 2, Location = lviv };
            var dep50 = new Department { Id = 50, Name = "IT", ManagerId = 3, Location = tokyo };
            var dep80 = new Department { Id = 80, Name = "Sales", ManagerId = 4, Location = tokyo };

  
            var itProg = new Job { Id = 1, Title = "IT_PROG", SalaryMin = 3000, SalaryMax = 8000 };
            var manager = new Job { Id = 2, Title = "MANAGER", SalaryMin = 5000, SalaryMax = 10000 };
            var clerk = new Job { Id = 3, Title = "CLERK", SalaryMin = 2000, SalaryMax = 4000 };


            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "David", LastName = "Clark", Job = itProg, Salary = 4200, Commission = null, Department = dep50 },
                new Employee { Id = 2, Name = "Anna", LastName = "Ivanova", Job = manager, Salary = 9000, Commission = "0.15", Department = dep80 },
                new Employee { Id = 3, Name = "John", LastName = "Smith", Job = clerk, Salary = 3100, Commission = null, Department = dep20 },
                new Employee { Id = 4, Name = "Diana", LastName = "Green", Job = itProg, Salary = 5200, Commission = "0.10", Department = dep50 },
                new Employee { Id = 5, Name = "David", LastName = "Brown", Job = clerk, Salary = 2500, Commission = null, Department = dep30 },
                new Employee { Id = 6, Name = "Ken", LastName = "Tanaka", Job = itProg, Salary = 6000, Commission = "0.05", Department = dep80 },
                new Employee { Id = 7, Name = "Nina", LastName = "Koval", Job = itProg, Salary = 4500, Commission = null, Department = dep50 },
                new Employee { Id = 8, Name = "Ann", LastName = "White", Job = manager, Salary = 8500, Commission = null, Department = dep30 },
                new Employee { Id = 9, Name = "Jonna", LastName = "Lee", Job = itProg, Salary = 4100, Commission = "0.20", Department = dep80 },
                new Employee { Id = 10, Name = "Benjamin", LastName = "Mann", Job = itProg, Salary = 5000, Commission = null, Department = dep50 }
            };

            // --- a–h 
            Console.WriteLine("a) All employees:");
            employees.ForEach(Console.WriteLine);

            Console.WriteLine("\nb) Employees named 'David':");
            employees.Where(e => e.Name == "David").ToList().ForEach(Console.WriteLine);

            Console.WriteLine("\nc) Employees with job_id 'IT_PROG':");
            employees.Where(e => e.Job?.Title == "IT_PROG").ToList().ForEach(Console.WriteLine);

            Console.WriteLine("\nd) Employees from department 50 with salary > 4000:");
            employees.Where(e => e.Department?.Id == 50 && e.Salary > 4000).ToList().ForEach(Console.WriteLine);

            Console.WriteLine("\ne) Employees from departments 20 or 30:");
            employees.Where(e => e.Department?.Id == 20 || e.Department?.Id == 30).ToList().ForEach(Console.WriteLine);

            Console.WriteLine("\nf) Employees whose name ends with 'a':");
            employees.Where(e => e.Name != null && e.Name.EndsWith("a")).ToList().ForEach(Console.WriteLine);

            Console.WriteLine("\ng) Employees from departments 50 or 80 with a commission:");
            employees.Where(e => (e.Department?.Id == 50 || e.Department?.Id == 80) && !string.IsNullOrEmpty(e.Commission)).ToList().ForEach(Console.WriteLine);

            Console.WriteLine("\nh) Employees whose name contains at least 2 'n's:");
            employees.Where(e => e.Name != null && e.Name.Count(ch => ch == 'n' || ch == 'N') >= 2).ToList().ForEach(Console.WriteLine);
        }
    }
}
