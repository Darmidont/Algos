using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;

namespace Algos
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertionSort.InsertionSort.Sort(null);
           // List<int> intList = ListHelper.GetList<int>(77);
            var intList = ListHelper.GetRandomList(10, true, 0, 15);

            Console.WriteLine("End a program");
            Console.ReadLine();
        }
    }

    
}
