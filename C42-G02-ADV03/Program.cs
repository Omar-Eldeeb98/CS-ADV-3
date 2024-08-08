using System.Diagnostics;

namespace C42_G02_ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01

            //    var books = new List<Book>
            //{
            //    new Book("123", "Book 1", new string[] {"Author 1"}, new DateTime(2020, 1, 1), 29.99m),
            //    new Book("456", "Book 2", new string[] {"Author 2", "Author 3"}, new DateTime(2021, 1, 1), 39.99m)
            //};


            //    // a - user defined delegate
            //    LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);
            //    Console.WriteLine("--------------------------------------------");

            //    // b - Proper build in delegate. 
            //    LibraryEngine.ProcessBooks2(books, BookFunctions.GetTitle);
            //    Console.WriteLine("--------------------------------------------");

            //    // c - Anonymous Method (GetISBN).
            //    LibraryEngine.ProcessBooks(books, delegate (Book book) { return book.ISBN; });
            //    Console.WriteLine("--------------------------------------------");

            //    // d- Lambda Expression (GetPublicationDate)
            //    LibraryEngine.ProcessBooks(books, book => book.PublicationDate.ToString("yyyy-MM-dd"));
            //    Console.WriteLine("--------------------------------------------");



            #endregion



            #region Part 02
            // 2.We need to Implement the List methods from scratch with all overloads.

            //CustomList<int> numbers = new CustomList<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers.Add(4);
            //numbers.Add(5);


            //Console.WriteLine(numbers.Exists(x => x > 2)); // True
            //Console.WriteLine("\n");

            //Console.WriteLine(numbers.Find(x=>x>1)); // 2
            //Console.WriteLine("\n");


            //List<int> matched = numbers.FindAll(x => x > 3);
            //foreach (int item in matched)
            //{
            //    Console.Write(" " + item);  // 4 5
            //}
            //Console.WriteLine("\n");


            //Console.WriteLine(numbers.FindIndex(x => x > 1)); // 1
            //Console.WriteLine("\n");

            //Console.WriteLine(numbers.FindLastIndex(x => x > 1)); // 4
            //Console.WriteLine("\n");


            //Console.WriteLine(numbers.FindLast(x => x > 2));  // 5
            //Console.WriteLine("\n");


            //numbers.ForEach(x => Console.Write(x + " ")); // 1 2 3 4 5
            //Console.WriteLine("\n");


           
            //Console.WriteLine(numbers.TrueForAll(x => x > 0));  // True
            //Console.WriteLine("\n");


           

            #endregion
        }
    }
}
