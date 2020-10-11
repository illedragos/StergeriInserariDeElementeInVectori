using System;
using System.Collections.Generic;
using System.Text;

namespace Stergeri_Inserari_Elemente_Vectori
{
    class Problema6
    {
        public static void Rezolvare(int[] arr)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Elementele sirului sunt:");
            Console.WriteLine("[" + String.Join(",", arr) + "]");

            List<int> nums = new List<int>(arr);
            for (int i= 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    nums.Insert(i+1, nums[i]*2);
                    i++;
                }

            }
            arr = nums.ToArray();

            Console.WriteLine("Elementele sirului dupa inserarea dublului nr pare sunt:");
            Console.WriteLine("[" + String.Join(",", arr) + "]");
        }

    }
}
