using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouvillePlayground
{
    public class Employee
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        private int _salary { get; set; }
        public int Age { get; set; }

        public Employee(string FirstName, string LName, string Title, DateTime Start, int Salary, int Age)
        {
            this.FName = FirstName;
            this.LName = LName;
            this.FullName = $"{this.FName} {this.LName}";
            this.Start = Start;
            this.Title = Title;
            this._salary = Salary;
            this.Age = Age;
        }

        public void ShowName()
        {
            Console.WriteLine($"{this.FullName} and I started on {this.Start}");
        }

        public void DoWork()
        {
            Console.WriteLine("I am working");
        }

        public void DoWork(string workingTask)
        {
            Console.WriteLine($"I am working on {workingTask}");
        }

        public void ShowTitle()
        {
            Console.WriteLine($"My Title is {this.Title}");
        }

        public void ShowPay()
        {
            Console.WriteLine($"My pay is: {_salary}");
        }

    }


}
