using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV03
{
    public class CustomList<T>
    {
        private List<T> list = new List<T>();


        // 1 - Exist
        public bool Exists(Predicate<T> match)
        {
            foreach (T item in list)
            {
                if (match(item))
                {
                    return true;
                }
                    
            }
            return false;
        }


        // 2 - Find
        public T Find(Predicate<T> match)
        {
            foreach (T item in list)
            {
                if (match(item)) 
                {
                    return item;
                }
                  
            }
            return default(T);
        }


        // 3 - Find All
        public List<T> FindAll(Predicate<T> match)
        {
            List<T> result = new List<T>();
            foreach (T item in list)
            {
                if (match(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        // 4 - Find Index
        public int FindIndex(Predicate<T> match)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (match(list[i]))
                {
                    return i;
                }
                   
            }
            return -1;
        }

        // 5 - Find Last
        public T FindLast(Predicate<T> match)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (match(list[i]))
                {
                    return list[i];
                }
                   
            }
            return default(T);
        }


        // 6 -  Find Last Index
        public int FindLastIndex(Predicate<T> match)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (match(list[i]))
                {
                    return i;
                }
                   
            }
            return -1;
        }

        // 7 - ForEach
        public void ForEach(Action<T> action)
        {
            foreach (T item in list)
            {
                action(item);
            }
        }

        // 8 - TrueForAll
        public bool TrueForAll(Predicate<T> match)
        {
            foreach (T item in list)
            {
                if (!match(item))
                {
                    return false;
                }
                  
            }
            return true;
        }



        // Add function
        public void Add(T item)
        {
            list.Add(item);
        }


    }
}
