using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

        }

        static void CompoundInterest()
        {
            double[] babaAlajo = { 1000, 2000, 500, 1000, 3000, 700, 900 };

            //find the total
            double total = 0;
            for (int i = 0; i < babaAlajo.Length; i++)
            {
                total += babaAlajo[i];
                Console.WriteLine($"the principal balance of babaalajo's savings is {total}");
                Console.ReadLine();
                

            }
        }
    }
}
