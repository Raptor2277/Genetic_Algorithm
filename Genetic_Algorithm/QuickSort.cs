using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class Quicksort
    {
        private Quicksort() { }

        public static void Sort(Chromosone[] array)
        {
            sort(array, 0, array.Length - 1);
        }

        public static void sort(Chromosone[] array, int first, int last)
        {
            if (first < last)
            {
                int pivot = partition(array, first, last);

                sort(array, first, pivot - 1);

                sort(array, pivot + 1, last);
            }
        }

        private static int partition(Chromosone[] array, int first, int last)
        {
            Chromosone pivot = array[first];
            int up = first;
            int down = last;

            while (up < down)
            {
                while (up < last && array[up] >= pivot) up++;
                while (array[down] < pivot) down--;
                if (up < down) swap(array, up, down);
            }

            swap(array, first, down);

            return down;
        }

        private static void swap(Chromosone[] array, int index, int index2)
        {
            Chromosone temp = array[index];
            array[index] = array[index2];
            array[index2] = temp;
        }
    }
}
