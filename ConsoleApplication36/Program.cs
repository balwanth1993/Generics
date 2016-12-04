using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<int, Employee> dict = new Dictionary<int, Employee>();
            Employee emp1 = new Employee() { Id = 1, Name = "Balwanth", Gender = "Male" };
            Employee emp2 = new Employee() { Id = 2, Name = "Mary", Gender = "Female" };
            Employee emp3 = new Employee() { Id = 3, Name = "Sam", Gender = "Unknown" };

            dict.Add(emp1.Id, emp1);
            dict.Add(emp2.Id, emp2);
            dict.Add(emp3.Id, emp3);

            Employee emplo = dict[1];
            Console.WriteLine("Id = {0} , Name = {1} , Gender={2}", emplo.Id, emplo.Name, emplo.Gender);

            foreach (KeyValuePair<int,Employee > employee in dict)
            {
                Employee empl = employee.Value;
                Console.WriteLine("Id = {0} , Name = {1} , Gender={2}", empl.Id,empl.Name,empl.Gender);
            }
        }
    }
    public class Employee
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Gender { set; get; }
    }
}