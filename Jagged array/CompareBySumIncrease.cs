using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_array
{
    public class CompareBySumIncrease : IComparer
    {
        public int Compare(int[] arr1, int[] arr2)
        {
            if (arr1 == null || arr2 == null)
                throw new ArgumentNullException();

            if (arr1.Sum() > arr2.Sum())
                return 1;
            else if (arr1.Sum() < arr2.Sum())
                return -1;
            else return 0;
        }
    }
}
