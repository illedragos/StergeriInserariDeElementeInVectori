using System;
using System.Collections.Generic;
using System.Text;

namespace Stergeri_Inserari_Elemente_Vectori
{
    class PrimeNumber
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= (int)Math.Floor(Math.Sqrt(number)); i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

    }
}
