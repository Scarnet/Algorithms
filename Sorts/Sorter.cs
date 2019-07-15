using System;
using System.Collections.Generic;
using System.Text;

namespace Sorts
{
    public static class Sorter<T> where T : IComparable
    {
        private static T[] Shuffel(T[] arr)
        {
            var rand = new Random();
            int n = arr.Length -1;
            for(int i=0; i < arr.Length; i++)
            {
                int randIndex = rand.Next(0, n);
                Swap(arr, i, randIndex);
            }
            return arr;
        }


        public static T[] QuickSort(T[] arr)
        {
            arr = Shuffel(arr);
            Sort(arr, 0, arr.Length - 1);
            return arr;
        }

        private static void Sort(T[] arr, int low, int high)
        {
            if (high <= low)
                return;

            int j = Partition(arr, low, high);
            Sort(arr, low, j - 1);
            Sort(arr, j + 1, high);
        }

        private static int Partition(T[] arr, int low, int high)
        {
            var key = arr[low];
            int i = low + 1;
            int j = high;
        
            while(true)
            {
                while(arr[i].CompareTo(key) < 0 && i < high)
                    i++;

                while (arr[j].CompareTo(key) > 0 && j > low)
                    j--;


                if (i >= j)
                    break;

                Swap(arr, i, j);
            }

            Swap(arr, low, j);
            return j;
        }

        private static T[] Swap(T[] arr, int firstIndex, int secondIndex)
        {
            var temp = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = temp;
            return arr;
        }
    }
}
