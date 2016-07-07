using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_array
{
    public class Adapter<T> : IComparer<T[]>
    {
        private SortJaggedArray<T>.KindSortingDelegate del;

        public Adapter(SortJaggedArray<T>.KindSortingDelegate del)
        {
            this.del = del;
        }

        public int Compare(T[] x, T[] y)
        {
            return del(x, y);
        }
    }
}
