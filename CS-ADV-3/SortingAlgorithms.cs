using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADV_3
{
    public delegate bool compareFuncDelegate<T>(T x, T y);
    internal class SortingAlgorithms<T>
    {

        #region non generic

        //public static void bubbleSort(int[] arr , compareFuncDelegate compareFuncDelegate )
        //{
        //    if(arr is not null)
        //    {
        //        for (int i =0; i<arr.Length; i++)
        //        {
        //            for (int j = 0; j<arr.Length-i-1; j++)
        //            {
        //                //if (arr[j] > arr[j+1])
        //                //if (CompareFunctions.isGreater(arr[j] , arr[j+1]))
        //                if (compareFuncDelegate.Invoke(arr[j] , arr[j+1]))
        //                {
        //                    swap(ref arr[j], ref arr[j + 1]);
        //                }

        //            } 
        //        }

        //    }
        //}

        //public static void bubbleSortDesc(int[] arr)
        //{
        //    if (arr is not null)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - i - 1; j++)
        //            {
        //                if (arr[j] < arr[j + 1])
        //                {
        //                    swap(ref arr[j], ref arr[j + 1]);
        //                }


        //            }
        //        }

        //    }
        //}


        #endregion

        #region generic
        public static void bubbleSort(T[] arr, compareFuncDelegate<T> compareFuncDelegate)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        //if (arr[j] > arr[j+1])
                        //if (CompareFunctions.isGreater(arr[j] , arr[j+1]))
                        if (compareFuncDelegate.Invoke(arr[j], arr[j + 1]))
                        {
                            swap(ref arr[j], ref arr[j + 1]);
                        }

                    }
                }

            }
        }

        #endregion

        private static void swap(ref T v1, ref T v2)
        {
            T temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
