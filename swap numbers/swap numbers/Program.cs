using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"Before Swap: a = {a}, b = {b}");

            // Swapping using addition and subtraction
            a = a + b;  
            b = a - b;  
            a = a - b;  

            Console.WriteLine($"After Swap: a = {a}, b = {b}");
        }
    }
}
