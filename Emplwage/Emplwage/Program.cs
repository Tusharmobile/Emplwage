using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emplwage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Solving Emplwage Problem");
            EmpWage employee = new EmpWage();
            employee.MonthlyEmpWage();
            Console.ReadLine();
        }
    }
}
