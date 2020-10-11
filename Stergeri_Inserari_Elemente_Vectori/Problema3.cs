using System;
using System.Collections.Generic;
using System.Text;

namespace Stergeri_Inserari_Elemente_Vectori
{
    class Problema3
    {
        public static void Rezolvare(int[] arr)
        {
            //3. Sa se steargă dintr-un vector toate elementele care sunt pare
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Vector inainte de eliminare nr pare:");
            Console.WriteLine("[" + String.Join(",", arr) + "]");


            List<int> nums = new List<int>(arr);
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i]%2==0)
                {
                    nums.RemoveAt(i);
                    i--;
                }

            }
            arr = nums.ToArray();


            Console.WriteLine("Vector dupa elimnare nr pare");
            Console.WriteLine("[" + String.Join(",", arr) + "]");

        }



    }
}
