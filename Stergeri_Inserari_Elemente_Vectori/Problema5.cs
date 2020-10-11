using System;
using System.Collections.Generic;
using System.Text;

namespace Stergeri_Inserari_Elemente_Vectori
{
    class Problema5
    {
        public static void Rezolvare(int[] arr)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Elementele sirului sunt:");
            Console.WriteLine("[" + String.Join(",", arr) + "]");

            Console.WriteLine("Dati pozitia pe care doriti sa adaugati elementul");
            int pozitie = int.Parse(Console.ReadLine());

            Console.WriteLine("Dati elementul care doriti sa il adaugati");
            int numar = int.Parse(Console.ReadLine());

            if (pozitie >= 0 && pozitie <= 9)
            {

                List<int> nums = new List<int>(arr);
                nums.Insert(pozitie, numar);
                arr = nums.ToArray();

                Console.WriteLine("Elementele sirului dupa inserare sunt:");
                Console.WriteLine("[" + String.Join(",", arr) + "]");
            }
            else
            {
                Console.WriteLine("Nu exista aceasta pozitie");
            }
        }
    }
}
