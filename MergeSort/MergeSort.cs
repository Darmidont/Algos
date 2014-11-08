using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class MergeSort
    {
        public static void Sort(List<int> intList)
        {
            Contract.Requires(null != intList);
            Contract.Requires(intList.Any());
            if (intList.Count == 1)
            {
                return;
            }

             
        }
    }
}
