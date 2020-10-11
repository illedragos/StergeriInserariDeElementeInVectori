using System;
using System.Collections.Generic;
using System.Text;

namespace Stergeri_Inserari_Elemente_Vectori
{
    class Problema10
    {
        public static void Rezolvare(int n)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int[] arr = GenerateRandomArray.Random(n);

            for(int i=0;i<n;i++)
            {
                int x = arr[0];
                for(int k = 1; k < n; k++)
                {
                    arr[k - 1] = arr[k];
                }
                arr[n - 1] = x;
                Console.WriteLine("[" + String.Join(",", arr) + "]");
            }

        }


    }
}
