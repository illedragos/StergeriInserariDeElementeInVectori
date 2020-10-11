using System;

namespace Stergeri_Inserari_Elemente_Vectori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Alege problema care dorestis a o rezolvi");
            Console.WriteLine("1. Sa se stearga dintr-un sir elementul aflat pe o pozitie data.");
            Console.WriteLine("2. Sa se steargă dintr-un vector toate elementele care sunt numere prime.");
            Console.WriteLine("3. Sa se steargă dintr-un vector toate elementele pare.");
            Console.WriteLine("4. Se citeste un sir cu n elemente, numere întregi. " +
                "Sa se stearga elementele care se repeta, pastrandu-se doar primul de la stânga la dreapta.");
            Console.WriteLine("5. Sa se insereze pe o pozitie data intr-un sir o valoare precizata.");
            Console.WriteLine("6. Sa se insereze intr-un sir după fiecare element par dublul sau.");
            Console.WriteLine("7. Sa se insereze intr-un sir inaintea fiecarui element patrat perfect radacina sa patrata.");
            Console.WriteLine("8. Se dau n numere intregi. Sa se insereze intre oricare doua numere de aceeasi paritate media lor aritmetica.");
            Console.WriteLine("9. Se dau n numere intregi. Sa se insereze intre oricare două numere de aceeasi paritate media lor aritmetică. " +
                "Sa se realizeze acest procedeu pana nu se mai pot adauga noi elemente.");
            Console.WriteLine("10. Determinati toate permutarile circulare spre stanga ale unui vector dat.");
            Console.WriteLine("11. Gigel a gasit un sir cu n numere naturale. In fiecare zi Gigel parcurge sirul si când gaseste o pereche de elemente " +
                "consecutive egale o elimina din sir si se oprește. Determinati în cate zile va elimina Gigel elemente din sir si care sunt valorile " +
                "din sir după eliminari.");

            int optiune = int.Parse(Console.ReadLine());
            if (optiune >= 1 && optiune <= 11)
            {
                switch (optiune)
                {
                    case 1:
                        Console.WriteLine("Ai ales problema 1");
                        int[] arr1 = GenerateRandomArray.Random(10);
                        Problema1.Rezolvare(arr1);
                        break;
                    case 2:
                        Console.WriteLine("Ai ales problema 2");
                        int[] arr2 = GenerateRandomArray.Random(10);
                        Problema2.Rezolvare(arr2);
                        break;
                    case 3:
                        Console.WriteLine("Ai ales problema 3");
                        int[] arr3 = GenerateRandomArray.Random(10);
                        Problema3.Rezolvare(arr3);
                        break;
                    case 4:
                        Console.WriteLine("Ai ales problema 4");
                        Problema4.Rezolvare();
                        break;
                    case 5:
                        Console.WriteLine("Ai ales problema 5");
                        int[] arr5 = GenerateRandomArray.Random(10); 
                        Problema5.Rezolvare(arr5);
                        break;
                    case 6:
                        Console.WriteLine("Ai ales problema 6");
                        int[] arr6 = GenerateRandomArray.Random(10);
                        Problema6.Rezolvare(arr6);
                        break;
                    case 7:
                        Console.WriteLine("Ai ales problema 7");
                        int[] arr7 = GenerateRandomArray.Random(10);
                        Problema7.Rezolvare(arr7);
                        break;
                    case 8:
                        Console.WriteLine("Ai ales problema 8");
                        Console.WriteLine("Dati numarul n pentru generarea numerelor aleatore");
                        int n8 = int.Parse(Console.ReadLine());
                        Problema8.Rezolvare(n8);
                        break;
                    case 9:
                        Console.WriteLine("Ai ales problema 9");
                        Console.WriteLine("Problema nerezolvata");
                        break;
                    case 10:
                        Console.WriteLine("Ai ales problema 10");
                        Console.WriteLine("Dati numarul dimensiunea vectorului");
                        int n10 = int.Parse(Console.ReadLine());
                        Problema10.Rezolvare(n10);
                        break;
                    case 11:
                        Console.WriteLine("Ai ales problema 11");
                        //int[] arr11 = GenerateRandomArray.Random(20);
                        int[] arr11 = { 1, 1, 3, 4, 6, 6, 7, 8, 9, 10, 10,11,11 };
                        Problema11.Rezolvare(arr11);
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Optiune invalida");
            }




            
            
        }
    }
}
