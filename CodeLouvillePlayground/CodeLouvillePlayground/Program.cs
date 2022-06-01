using System;
using System.Collections.Generic;

namespace CodeLouvillePlayground
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter in a number.");
                var t = int.Parse(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine($"An exception was thrown");
            }





            Employee employee1 = new Employee("Ross", "Anthony", "Mentor", DateTime.Now, 0, 30);
            Employee employee2 = new Employee("Trent", "M", "Boss", Convert.ToDateTime("5/31/2021"), 10, 30);

            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(employee1);
            employeeList.Add(employee2);

            foreach(Employee tempEmployeeObj in employeeList)
            {
                tempEmployeeObj.ShowName();
                tempEmployeeObj.ShowTitle();
                tempEmployeeObj.ShowPay();
            }
        }      
    }
}
