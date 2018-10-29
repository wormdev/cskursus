using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_Opgave_1_Variabler_Tal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erklær variabel
            int heltal = 10;

            //Opskriv med 1
            heltal++;

            //Print
            Console.Write(heltal);
            Console.Write(" ");

            //Nedskriv med 1
            heltal--;
            
            Console.Write(heltal);
            Console.Write(" ");

            //
            Console.ReadKey();
        }
    }
}
