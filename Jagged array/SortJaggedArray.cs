using System;
using System.Collections.Generic;

namespace Jagged_array
{
    public class SortJaggedArray<T>
    {
        public delegate int KindSortingDelegate(T[] a, T[] b);

        public static T[][] SortArrayByIncrease(T[][] arr, KindSortingDelegate compare)
        {
            IComparer<T[]> comparer = new Adapter<T>(compare);
            return  BubbleSort(arr, 1, comparer);
        }

        public static T[][] SortArrayByDecrease(T[][] arr, KindSortingDelegate compare)
        {
            IComparer<T[]> comparer = new Adapter<T>(compare);
            return BubbleSort(arr, -1, comparer);
        }

        public static T[][] SortArrayByDecrease(T[][] arr, IComparer<T[]> comparer)
        {
            return BubbleSort(arr, -1, comparer);
        }
         public static T[][] SortArrayByIncrease(T[][] arr, IComparer<T[]> comparer)
        {
            return BubbleSort(arr, 1, comparer);
        }

        public static T[][] BubbleSort(T[][] arr, int MaxMin, IComparer<T[]> comparer)
        {
            foreach (var a in arr)
            {
                if (a == null)
                    throw new ArgumentNullException();
            }
            if (comparer == null)
                throw new ArgumentNullException();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (comparer.Compare(arr[i], arr[j]) == MaxMin)
                    {
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
            }
            return arr;
        }

        private static void Swap(ref T[] arr1, ref T[] arr2)
        {
            var temp = arr1;
            arr1 = arr2;
            arr2 = temp;
        }
    }
}
