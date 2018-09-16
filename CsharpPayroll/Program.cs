using CsharpPayroll;
using System;
using System.Collections.Generic;

namespace CSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oh hey, hi");

            Staff staff = new Staff("Bob", 50);
            staff.CalculatePayment();
            Console.WriteLine(staff.ToString());

            Manager mgr1 = new Manager("natz");
            mgr1.CalculatePayment();
            Console.WriteLine(mgr1.ToString());

            Console.Read();
        }
    }
}