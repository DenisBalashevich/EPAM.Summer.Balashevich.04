using System;
using System.Collections.Generic;

namespace Jagged_array
{
    public class SortJaggedArray<T>
    {
        public delegate int KindSortingDelegate(T[] a, T[] b);

        public static void BubbleSort(T[][] arr, IComparer<T[]> comparer)
        {
            foreach (var a in arr)
            {
                if (ReferenceEquals(arr, null))
                    throw new ArgumentNullException();
            }
            if (ReferenceEquals(comparer, null))
                throw new ArgumentNullException();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (comparer.Compare(arr[i], arr[j]) > 0 )
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
        }

        public static void BubbleSort(T[][] arr, KindSortingDelegate comparer)
        {
            if (ReferenceEquals(comparer, null))
                throw new ArgumentNullException();
            BubbleSort(arr, new Adapter<T>(comparer));
        }
  
        private static void Swap(ref T[] arr1, ref T[] arr2)
        {
            var temp = arr1;
            arr1 = arr2;
            arr2 = temp;
        }
    }
}
