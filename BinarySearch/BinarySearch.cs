using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class BinarySearch
    {
        public static int Search(List<int> array, int value)
        {
            int inf = 0;
            int sup = array.Count - 1;

            while (inf <= sup)
            {
                int index = (inf + sup) >> 1;

                int mid = array[index];

                if (value == mid)
                    return index;
                if (mid < value)
                    inf = index + 1;
                else
                    sup = index - 1;
            }
            return -1;
        }
    }
}