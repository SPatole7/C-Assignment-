using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp2
{
    class ListCollection
    {
        public static void Main()
        {
            List<EmpDetails> empDetails = new List<EmpDetails>()
            {
                new EmpDetails { ID = 101, Name = "Frank" },
                new EmpDetails { ID = 102, Name = "Lilly" },
                new EmpDetails { ID = 103, Name = "Jack" },
                new EmpDetails { ID = 104, Name = "Joseph" },
                new EmpDetails { ID = 105, Name = "Larvin" },
                new EmpDetails { ID = 106, Name = "Farhan" }
            };
            //Step 2: Create an instance of Predicate<EmpDetails> delegate and pass the 
            //ethod name as an argument to the delegate constriuctor

            //Predicate<EmpDetails> predicateEmp = new Predicate<EmpDetails>(FindDetails);

            //Step 3: Now pass the delegate instance as argument for Find() method

            //using Ananonymous method --
            //EmpDetails employee = empDetails.Find(
            //    delegate(EmpDetails emp)
            //{
            //    return emp.ID == 103;
            //});

            // Using Lamda Expression
            EmpDetails employee = empDetails.Find(x => x.Name == "Jack");
            Console.WriteLine("ID = {0} \nName = {1}", employee.ID, employee.Name);

            int count = empDetails.Count(x => x.Name.StartsWith("J"));
            Console.WriteLine("Count = " + count);

            IEnumerable<string> names = empDetails.Select(emp => "Name = " + emp.Name);
            foreach(string empname in names)
            {
                Console.WriteLine(empname);
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            //Func Delegates
            Func<EmpDetails, string> selector = emp => "Id = " + emp.ID + "  Name = " + emp.Name;
            IEnumerable<string> details = empDetails.Select(selector);
            foreach(string det in details)
            {
                Console.WriteLine(det);
            }
        }


        //Step 1 : create a method whose signature matches 
        //with signature of Predicate<EmpDetails> delegate
        //public static bool FindDetails(EmpDetails emp)
        //{
        //    return emp.ID == 103;
        //}

        public class EmpDetails
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }
}
