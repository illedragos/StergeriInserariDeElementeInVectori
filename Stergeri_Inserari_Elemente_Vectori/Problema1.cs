using System;
using System.Collections.Generic;
using System.Text;

namespace Stergeri_Inserari_Elemente_Vectori
{
    class Problema1
    {
        public static void Rezolvare(int[]arr)
        {
            //1. Să se steargă dintr-un sir elementul aflat pe o pozitie dată.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vectorul de numere aleatore este:");
            Console.WriteLine("[" + String.Join(",", arr) + "]");

            Console.WriteLine("Introduceti pozitia elementului pentru a-l sterge (0-9)");
            int pozitie = int.Parse(Console.ReadLine());
            if (pozitie >= 0 && pozitie <= 9)
            {

                List<int> nums = new List<int>(arr);
                nums.RemoveAt(pozitie);
                arr = nums.ToArray();

                Console.WriteLine("["+String.Join(",", arr)+"]");
            }
            else
            {
                Console.WriteLine("Nu exista aceasta pozitie in vector");
            }
        }

    }
}
