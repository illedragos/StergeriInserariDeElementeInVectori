using System;
using System.Collections.Generic;
using System.Text;

namespace Stergeri_Inserari_Elemente_Vectori
{
    class Problema8
    {
        public static void Rezolvare(int  n)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int[] arr = GenerateRandomArray.Random(n);
            Console.WriteLine("Sirul inaintea inserarii mediei");
            Console.WriteLine("[" + String.Join(",", arr) + "]");
            List<int> nums = new List<int>(arr);
            
            for(int i=0;i<nums.Count-1;i++)
            {
                if((nums[i]%2==0&&nums[i+1]%2==0)|| (nums[i] % 2 != 0 && nums[i + 1] % 2 != 0))
                {
                    int media = (nums[i] + nums[i + 1]) / 2;
                    nums.Insert(i+1, media);
                    i++;
                }
            }

            arr = nums.ToArray();

            Console.WriteLine("Sirul dupa inserarea mediei");
            Console.WriteLine("[" + String.Join(",", arr) + "]");

        }
    }
}
