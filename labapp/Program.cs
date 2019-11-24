using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labapp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Dodaj liczby");
                Console.WriteLine("2. Odejmij liczby");
                Console.WriteLine("3. * liczby liczb");
                Console.WriteLine("4. Dziel liczby");
                Console.WriteLine("5. Wyjscie");
                int menuOption = Convert.ToInt32(Console.ReadLine());
                if (menuOption == 5)
                    break;
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                if (menuOption == 1)
                    Console.WriteLine(a + b);
            }

        }
    }
}
