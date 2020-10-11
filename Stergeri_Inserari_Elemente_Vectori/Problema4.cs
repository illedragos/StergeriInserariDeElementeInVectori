using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Stergeri_Inserari_Elemente_Vectori
{
    class Problema4
    {
        //4. Se citeste un sir cu n elemente, numere întregi.Sa se stearga elementele care se repeta, pastrandu-se doar primul de la stânga la dreapta."
        public static void Rezolvare()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Dati numarul de elemente");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elementele");
            List<int> lst = new List<int>();
            for(int i=0;i<n;i++)
            {
                lst.Add(int.Parse(Console.ReadLine()));
            }

            List<int> uniqueLst = lst.Distinct().ToList();

            Console.WriteLine("Elementele unice din sir sunt:");
            uniqueLst.ForEach(Console.WriteLine);

        }

    }
}
