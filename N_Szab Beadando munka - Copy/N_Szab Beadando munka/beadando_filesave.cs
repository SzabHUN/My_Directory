﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Szab_Beadando_munka
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Írjon be egy dátomot, tetszés szerint, az Évet, Hónapot, Napot '.' al elválasztva\n(ÉÉÉÉ.HH.NN)");
            
            String input = Console.ReadLine();

            int yr = Convert.ToInt32(input.Split('.')[0]), mn = Convert.ToInt32(input.Split('.')[1]), dd = Convert.ToInt32(input.Split('.')[2]);

            if (yr % 4 == 0)
                Console.WriteLine("Ez az év szökőévre esik.");
            else
                Console.WriteLine("Ez az év nem szökőévre esik.");
            
            if (mn == 12)
                if (dd == 25)
                    if (yr > 2018)
                        Console.WriteLine("Ezen a napon lesz majd karácsony napja.");
                    else
                        Console.WriteLine("Ezen a napon volt karácsony napja.");
                else if (dd > 25)
                    Console.WriteLine("sanjnos pont lekéstél róla, egy év múlva ");
                else
                    Console.WriteLine($"karácsony {25 - dd} nap mulva lesz megtartva");
            else
                Console.WriteLine($"Karácsony {12 - mn} hónap múlva lesz megtartva.");
            
           

            Console.ReadKey(true);
        }
    }
}
