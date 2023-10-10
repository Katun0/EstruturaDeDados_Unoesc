using System;
using System.Runtime.CompilerServices;

namespace C_.sorting
{
    public class Quicksort
    {
        // Método para ordenação QuickSort
        public void quicksort(List<int> roster, int start = 0, int stop = -1)
        {
            if (stop == -1)
                stop = roster.Count - 1;
            
            // Chamada Recursiva para ordenar
            if (start < stop)
            {
                int pi = partition(roster, start, stop);
                quicksort(roster, start, pi - 1);
                quicksort(roster, pi + 1, stop);
            }
        }

        // Método de Partição
        public int partition(List<int> roster, int start, int stop)
        {
            // Encontra Pivô e Índice
            int pivot = roster[stop];
            int i = start;

            for (int j = start; j < stop; j++)
            {
                if (roster[j] >= pivot)
                {
                    (roster[j], roster[i]) = (roster[i], roster[j]);
                    i++;
                }
            }

            (roster[i], roster[stop]) = (roster[stop], roster[i]);
            return i;
        }
    }
}
