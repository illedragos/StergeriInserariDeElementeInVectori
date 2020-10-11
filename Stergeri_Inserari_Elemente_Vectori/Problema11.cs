using System;
using System.Collections.Generic;
using System.Text;

namespace Stergeri_Inserari_Elemente_Vectori
{
    class Problema11
    {
        public static void Rezolvare(int[]arr)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[" + String.Join(",", arr) + "]");

            List<int> nums = new List<int>(arr);
            int nr = 0;

            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    nr++;
                    nums.RemoveAt(i);
                    nums.RemoveAt(i);
                    i = 0;
                }
            }


            Console.WriteLine("Numarul de zile =" + nr);
            arr = nums.ToArray();
            Console.WriteLine("[" + String.Join(",", arr) + "]");

        }
    }
}
