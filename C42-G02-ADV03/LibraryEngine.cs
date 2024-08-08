using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV03
{
    // user defined delegate
    public delegate string BookDelegate(Book book);
    internal class LibraryEngine
    {

        // a - Create User Defined Delegate with the same signature of methods existed in BookFunctions class.
        public static void ProcessBooks(List<Book> books, BookDelegate bookDelegate)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(bookDelegate(book));
            }

        }


        // b - b)Use the Proper build in delegate.
        
        public static void ProcessBooks2(List<Book> books , Func<Book,string> bookDelegate)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(bookDelegate(book));
            }
        }


    }
}
