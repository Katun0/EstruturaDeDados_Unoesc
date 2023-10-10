using C_.sorting;
using System;
using System.Collections.Generic;

namespace C_.sorting
{
    class Program
    {
        static void Main()
        {
            // Juntando Key-Value
            Dictionary<string, List<int>> testCases = new Dictionary<string, List<int>>
            {
                { "Ordenados", GetSortedNumbers() },
                { "Invertidos", GetInvertedNumbers() },
                { "Repetidos", GetRepeatedNumbers() }
            };

            Console.WriteLine("--" + new string('-', 28));

            foreach (var testCase in testCases)
            {
                //Hash para juntar Nome da lista / Valores da Lista
                string name = testCase.Key;
                List<int> lista = testCase.Value;
                Console.WriteLine($"\nCaso do teste: {name}");
                PrintList(lista);

                //Chamando o método para ordenar a lista de valores
                Quicksort quickSort = new Quicksort();
                quickSort.quicksort(lista);

                Console.WriteLine("\nOrdenado: ");
                PrintList(lista);
            }

            Console.WriteLine("--" + new string('-', 28));
        }

        // Lista de Números desordenada
        static List<int> GetInvertedNumbers()
        {
            return new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        }

        // Lista de números já ordenados
        static List<int> GetSortedNumbers()
        {
            return new List<int> { 8, 7, 6, 5, 4, 3, 2, 1 };
        }

        // Lista de valores Repetidos
        static List<int> GetRepeatedNumbers()
        {
            return new List<int> { 3, 2, 4, 3, 1, 4, 2, 1 };
        }

        // Mostrar os resultados
        static void PrintList(List<int> lista)
        {
            foreach (var item in lista)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
