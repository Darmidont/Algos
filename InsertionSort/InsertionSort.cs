using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;


namespace InsertionSort
{
    public static class InsertionSort
    {
        public static void Sort(List<int> intList)
        {
            Contract.Requires(null != intList);
            if (intList.Count < 2)
            {
                return;
            }


        }
    }
}
