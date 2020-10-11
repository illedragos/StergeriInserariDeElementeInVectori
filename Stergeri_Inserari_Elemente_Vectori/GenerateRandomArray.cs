using System;
using System.Collections.Generic;
using System.Text;

namespace Stergeri_Inserari_Elemente_Vectori
{
    class GenerateRandomArray
    {
        public static int[] Random(int len)
        {
            int[] arr = new int[len];
            Random randNum = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randNum.Next(1, 100);
            }

            return arr;
        }
    }
}
