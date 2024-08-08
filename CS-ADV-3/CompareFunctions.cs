using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADV_3
{
    internal class CompareFunctions
    {

        public static bool isGreater(int x , int y)
        {

        return x > y; 

        }

        public static bool isLess(int x, int y)
        {

            return x < y;
        }



        public static bool sortAscending(string x , string y)
        {
            return x?.Length > y?.Length;
        }

        public static bool sortDesc(string x, string y)
        {
            return x?.Length < y?.Length;
        }

    }
}
