using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADV_3
{
    internal class StringFunctions
    {
        // function 1
        public static int getCountOfUpperChars(string name)
        {
            int count = 0;
            if(name is not null)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (char.IsUpper(name[i]))
                    {
                        count++;
                    }
                }

                return count;
            }
            return count;
        }

        // function 2
        public static int getCountOfLowerChars(string name)
        {
            int count = 0;
            if (name is not null)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (char.IsLower(name[i]))
                    {
                        count++;
                    }
                }

                return count;
            }
            return 0;
        }

    }
}
