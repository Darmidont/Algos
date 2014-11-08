using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public static class ListHelper
    {
        public static List<T> GetList<T>(int length) where T : struct
        {
            Contract.Requires(length > 0);
            var tList = new List<T>();
            for (int i = 0; i < length; i++)
            {
                tList.Add(new T());
            }

            return tList;
        }

        public static List<int> GetRandomList(int length, bool isUnique = true, int minVal = 0, int maxValue = 10000)
        {
            Contract.Requires(length > 0);
            Contract.Requires(maxValue > minVal);
            Contract.Ensures(Contract.Result<List<int>>().Count == length);

            var intList = new List<int>();
            var rnd = new Random(1);
            for (int i = 0; i < length; i++)
            {
                var value = rnd.Next(minVal, maxValue);

                if (isUnique)
                {
                    var isUniqueValueFound = false;
                    while (!isUniqueValueFound)
                    {
                        if (!intList.Contains(value))
                        {
                            isUniqueValueFound = true;
                        }

                        value = rnd.Next(minVal, maxValue);
                    }
                }

                intList.Add(value);
            }

            return intList;
        }
    }
}