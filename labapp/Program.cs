﻿using System;
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
                int menuOption = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1. Dodaj liczby");

                Console.WriteLine("4. Dziel liczby");
                Console.WriteLine("5. Wyjscie");
                Console.WriteLine("2. Odejmij liczby");
                Console.WriteLine("3. * liczby liczb");

                int a = Convert.ToInt32(Console.ReadLine());


<<<<<<< HEAD
=======
                int menuOption = Convert.ToInt32(Console.ReadLine());

                if (menuOption == 5)
                    break;
>>>>>>> dcc2935... Exit option is now implemented
            }

        }
    }
}
