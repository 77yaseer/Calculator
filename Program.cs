using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp10;
namespace ConsoleApp10
{
   


    internal class Program
    {
        static void Main(string[] args)
        {
            clsCalculator C = new clsCalculator();

            C.Clear();

            C.Add(10);
            C.PrintResult();

            C.Add(100);
            C.PrintResult();

            C.Subtract(20);
            C.PrintResult();

            C.PrintListReselt();

            C.Divide(0);
            C.PrintResult();

            C.Divide(2);
            C.PrintResult();

            C.Multiply(3);
            C.PrintResult();

            C.Clear();
            C.PrintResult();

            Console.ReadLine();
        }
    }
}
