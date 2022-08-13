using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class EmployeeListCollection
    {
        public static void Main()
        {
            Console.Write("Enter number of Employees to be added : ");
            int empnum = Convert.ToInt32(Console.ReadLine());

            //Creating a List of Employees
            List<EmployeeList> employeeLists = new List<EmployeeList>();

            //INserting employee details 
            for (int i = 0; i < empnum; i++)
            {
                Console.Write("Employee ID :");
                int ID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Employee Name :");
                string Name = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Employee Gender :");
                string Gender = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Employee Salary :");
                decimal Salary = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Employee Department :");
                string Department = Console.ReadLine();
                Console.WriteLine();
                EmployeeList emp = new EmployeeList()
                {
                    EmpID = ID,
                    EmpName = Name,
                    EmpGender = Gender,
                    Salary = Salary,
                    Department = Department
                };
                employeeLists.Add(emp);
            }
            foreach (EmployeeList employee in employeeLists)
            {
                Console.WriteLine("-----Printing Employee Details-----");
                Console.WriteLine($"ID = {employee.EmpID}\n Name = {employee.EmpName}\n Gender = {employee.EmpGender}\n" +
                    $"Salary = {employee.Salary}\n Department = {employee.Department}");
            }
            Console.ReadLine();
        }
    }
    public class EmployeeList
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string EmpGender { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

    }
}
