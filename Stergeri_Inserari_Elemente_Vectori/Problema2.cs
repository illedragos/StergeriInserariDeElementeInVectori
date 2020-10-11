using System;
using System.Collections.Generic;
using System.Text;

namespace Stergeri_Inserari_Elemente_Vectori
{
    class Problema2
    {
        public static void Rezolvare(int[] arr)
        {
            //2. Sa se steargă dintr-un vector toate elementele care sunt numere prime.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vector inainte de eliminare nr prime:");
            Console.WriteLine("[" + String.Join(",", arr) + "]");


            List<int> nums = new List<int>(arr);
            for (int i = 0; i < nums.Count; i++)
            {
                if(PrimeNumber.IsPrime(nums[i])==true)
                {
                    nums.RemoveAt(i);
                    i--;
                }

            }
            arr = nums.ToArray();


            Console.WriteLine("Vector dupa elimnare nr prime");
            Console.WriteLine("[" + String.Join(",", arr) + "]");
        }
    }
}
