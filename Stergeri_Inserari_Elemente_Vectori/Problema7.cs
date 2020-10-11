using System;
using System.Collections.Generic;
using System.Text;

namespace Stergeri_Inserari_Elemente_Vectori
{
    class Problema7
    {
        public static void Rezolvare(int []arr)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Elementele sirului sunt:");
            Console.WriteLine("[" + String.Join(",", arr) + "]");

            List<int> nums = new List<int>(arr);
            for (int i = 0; i < nums.Count; i++)
            {
                double radical = Math.Sqrt(nums[i]);
                double after = radical - Math.Truncate(radical);
                if (after==0)
                {
                        nums.Insert(i, (int)radical);
                        i++;  
                }

            }
            arr = nums.ToArray();

            Console.WriteLine("Elementele sirului dupa inserarea radacinii patrate :");
            Console.WriteLine("[" + String.Join(",", arr) + "]");
        }

    }
}
