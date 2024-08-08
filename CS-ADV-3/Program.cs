using CS_ADV_3.Delegate;

namespace CS_ADV_3
{
    // step 0 ---> declare delegate.
    //public delegate int StringFuncDelegate(string str); 



    internal class Program
    {
        static void Main(string[] args)
        {

            #region Delegate
            // delegate is a C# lang feature.
            // has two usage
            // 1- pointer to function
            // 2- event  - driven programming

            //----------------------------------------------------------------------------------------------

            // step 1 ----> declare ref from delegate.
            //StringFuncDelegate stringFuncDelegate;

            //----------------------------------------------------------------------------------------------

            // step 2 ---> initialize reference from delegate.
            //stringFuncDelegate = new StringFuncDelegate(StringFunctions.getCountOfUpperChars);
            //stringFuncDelegate += new StringFuncDelegate(StringFunctions.getCountOfLowerChars);  // كدا خلسته يشاور على اكتر من function

            //----------------------------------------------------------------------------------------------

            // step 3 ---> use delegate
            //int result =  stringFuncDelegate.Invoke("Omar Mark");
            //Console.WriteLine(result); // 2
            //Console.WriteLine("\n");

            //----------------------------------------------------------------------------------------------

            //StringFuncDelegate stringFuncDelegate2 = new StringFuncDelegate(StringFunctions.getCountOfLowerChars);
            //int res = stringFuncDelegate2.Invoke("omar");
            //Console.WriteLine(res); // 4 
            //Console.WriteLine("\n");

            //----------------------------------------------------------------------------------------------










            #endregion

            #region Delegate EX02

            //int[] numbers = { 5, 7, 3, 12, 9, 0, 8, 6 };
            //compareFuncDelegate compareFuncDelegate = new compareFuncDelegate(CompareFunctions.isGreater);
            //SortingAlgorithms.bubbleSort(numbers, compareFuncDelegate);
            //foreach (int item in numbers)
            //{
            //    Console.Write(item + " "); // 0 3 5 6 7 8 9 12
            //}
            //Console.WriteLine("\n");

            //----------------------------------------------------------------------------------------------

            //compareFuncDelegate compareFuncDelegate2 = new compareFuncDelegate(CompareFunctions.isLess);
            //SortingAlgorithms.bubbleSort(numbers, compareFuncDelegate2);
            //foreach (int item in numbers)
            //{
            //    Console.Write(item + " "); //  12 9 8 7 6 5 3 0
            //}
            //Console.WriteLine("\n");

            //----------------------------------------------------------------------------------------------

            //SortingAlgorithms.bubbleSortDesc(numbers);
            //foreach (int item in numbers)
            //{
            //    Console.Write(item + " "); // 12 9 8 7 6 5 3 0
            //}
            //Console.WriteLine("\n");

            //----------------------------------------------------------------------------------------------


            #endregion


            #region Delegate with [Generics]



            //string[] names = { "Omar", "Ahmed", "Monaaa", "amr" };
            //compareFuncDelegate<string> compareFuncDelegate = new compareFuncDelegate<string>(CompareFunctions.sortAscending);
            //SortingAlgorithms<string>.bubbleSort(names, compareFuncDelegate);
            //foreach (string item in names)
            //{
            //    Console.Write(item + "  ");  // output: amr Omar Ahmed Monaaa
            //}
            //Console.WriteLine("\n");


            #endregion


            #region Delegate EX03


            //List<int> numbers = Enumerable.Range(1, 100).ToList();

            //List<int> oddsList =  Helper.getOdds(numbers);
            //foreach (int item in oddsList)
            //{
            //    Console.Write(" " + item);
            //}
            //Console.WriteLine("\n");

            //-----------------------------------------------------------------------------------------------------------


            //List<int> evens = Helper.getEvens(numbers);
            //foreach (int item in evens) 
            //{ 
            //    Console.Write(" " + item);
            //}
            //Console.WriteLine("\n");

            //-----------------------------------------------------------------------------------------------------------

            //List<int> dividedBy7 = Helper.getDividedBy7(numbers);
            //foreach (int item in dividedBy7)
            //{
            //    Console.Write(" " + item);  //  7 14 21 28 35 42 49 56 63 70 77 84 91 98
            //}
            //Console.WriteLine("\n");

            //------------------------------------------------------------------------------------------------------------
            #endregion


            #region built-in Delegate

            // 1 - predicate
            //--> refer to function that take one param only & must be return boolean.

            // 2 - func
            // --> refer to function that take from 0 to 16 param, ولازم تحدد ال return type


            // 3 - action
            //--> can refer function that take from 0 to 16 param & must be void function.


            #endregion


            #region List-Methods

            //List<int> numbers = Enumerable.Range(1, 100).ToList();
            //List<int> oddsNumbers = Helper.getOdds(numbers); // get odds in a new list
            //foreach (int item in oddsNumbers)
            //{
            //    Console.Write(" " + item);
            //}
            //------------------------------------------------------------------------------

            //List<int>oddsNumbers = numbers.FindAll(number => number %2 == 1); // wil retrieve all elements that math the condition.

            //-------------------------------------------------------------------------------------------
            //int firstOddNumber = numbers.Find(n => n % 2 == 1); // will retrieve the [first] element that match the condition. 
            //Console.WriteLine(firstOddNumber); // 1
            //Console.WriteLine("\n");
            //----------------------------------------------------------------------------


            //int x = numbers.FindLast(n => n > 10); // will retrieve the [last] element that match the condition.
            //Console.WriteLine(x);
            //Console.WriteLine("\n");
            //-------------------------------------------------------------------------------------

            //numbers.ForEach(n => Console.Write(" " + (n+10))); // action will be done to all element is the list.
            //Console.WriteLine("\n");
            //----------------------------------------------------------------------


            //int deletedNumbersCount =   numbers.RemoveAll(x => x > 50); // wii remove all elements that match the condition , and return  [count] of them , will return [integer]
            //Console.WriteLine(deletedNumbersCount);
            //Console.WriteLine("\n"); // 50

            //----------------------------------------------------------------------


            #endregion

        }
    }

}
