using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    //employee class with properties: id, fName, lName
    class Employee
    {
        public int id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //10 employees, 2 Joes
            List<Employee> employees = new List<Employee>
            {
                new Employee { id = 1, fName = "Joe", lName = "Smith" },
                new Employee { id = 2, fName = "Jane", lName = "Doe" },
                new Employee { id = 3, fName = "Joe", lName = "Brown" },
                new Employee { id = 4, fName = "Kriszha", lName = "Real" },
                new Employee { id = 5, fName = "Yujin", lName = "Ahn" },
                new Employee { id = 6, fName = "Minju", lName = "Kim" },
                new Employee { id = 7, fName = "Yena", lName = "Choi" },
                new Employee { id = 8, fName = "Chaewon", lName = "Kim" },
                new Employee { id = 9, fName = "Eunbi", lName = "Kwon" },
                new Employee { id = 10, fName = "Tiffany", lName = "Hwang" }
            };

            //list of employees with fName "Joe"
            List<Employee> joeList = new List<Employee>();
            foreach (Employee emp in employees)
            {
                if (emp.fName == "Joe")
                {
                    joeList.Add(emp);
                }
            }

            Console.WriteLine("Employees with fName 'Joe' (using foreach loop):");
            foreach (Employee joe in joeList)
            {
                Console.WriteLine($"{joe.fName} {joe.lName}, id: {joe.id}");
            }

            //lambda - employees with fName "Joe"
            List<Employee> joeListLambda = employees.Where(emp => emp.fName == "Joe").ToList();

            Console.WriteLine("\nEmployees with fName 'Joe' (using lambda expression):");
            joeListLambda.ForEach(joe => Console.WriteLine($"{joe.fName} {joe.lName}, id: {joe.id}"));

            //lambda - employees with id greater than 5
            List<Employee> idGreaterThanFive = employees.Where(emp => emp.id > 5).ToList();

            Console.WriteLine("\nEmployees with id greater than 5:");
            idGreaterThanFive.ForEach(emp => Console.WriteLine($"{emp.fName} {emp.lName}, id: {emp.id}"));

            Console.ReadLine();
        }
    }
}
