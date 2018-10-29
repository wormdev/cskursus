using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            byte a;
            short b;
            int c;
            long d;

            a = 10;
            // a = 500;   Vil skabe en fejl fordi 500 ikke kan repræsenteres af 8 bit
            b = 10000;
            // b = 50000; Vil skabe en fejl fordi 50000 ikke kan repræsenteres af 16 bit
            c = 1000000000;
            d = 1000000000000000000;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");

            Console.WriteLine($"byte min: {System.Byte.MinValue}");
            Console.WriteLine($"byte max: {System.Byte.MaxValue}");

            Console.WriteLine($"int min: {System.Int32.MinValue}");
            Console.WriteLine($"int max: {System.Int32.MaxValue}");

            Console.WriteLine($"long min: {System.Int64.MinValue}");
            Console.WriteLine($"long max: {System.Int64.MaxValue}");

            int i = 10;
            Console.WriteLine($"i = {i}");
            Console.WriteLine($"i = {i.ToString()}");


            /*
             ---------- Output: ----------

            byte min: 0
            byte max: 255
            int min: -2147483648
            int max: 2147483647
            long min: -9223372036854775808
            long max: 9223372036854775807
            i = 10
            i = 10

            */

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
