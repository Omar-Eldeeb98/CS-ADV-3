using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADV_3.Delegate
{
    internal class Helper
    {

        public static List<int> getOdds(List<int> numbers)
        {
            List<int> odds = new List<int>();

            if(numbers is not null)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] %2 == 1)
                    {

                        odds.Add(numbers[i]);
                    }
                    
                }
                return odds;
            }
            return odds;
            
        }


        public static List<int> getEvens(List<int> numbers)
        {
            List<int> evens = new List<int>();

            if (numbers is not null)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {

                        evens.Add(numbers[i]);
                    }

                }
                return evens;
            }
            return evens;

        }


        public static List<int> getDividedBy7(List<int> numbers)
        {
            List<int> result = new List<int>();

            if (numbers is not null)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] % 7 == 0)
                    {

                        result.Add(numbers[i]);
                    }

                }
                return result;
            }
            return result;

        }






    }
}
