using System;

namespace Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 9, 6, 5, 2, 5, 3 };
            arr = Sorter<int>.QuickSort(arr);
            Console.Write("{");
            foreach(var item in arr)
            {
                Console.Write($"{item}, ");
            }
            Console.ReadKey();
        }
    }
}
