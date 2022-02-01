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
            EmpWage dMart = new EmpWage("DMart", 20, 2, 10);
            EmpWage reliance = new EmpWage("Reliance", 10, 4, 10);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}
