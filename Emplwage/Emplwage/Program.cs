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
            Console.WriteLine("Welcom to the Employee Wage Problem");

            EmpWage.computeEmpwage("DMart", 20, 2, 10);
            EmpWage.computeEmpwage("Reliance", 10, 4, 20);
        }
    }
}
