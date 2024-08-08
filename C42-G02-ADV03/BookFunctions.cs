using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV03
{
    public class BookFunctions
    {
       

        public static string GetTitle(Book book)
        {
            return book.Title; 
        }

        public static string GtAuthors(Book book)
        {
            return string.Join(", ", book.Authors);
        }

        public static string GetPrice(Book book)
        {
            return book.Price.ToString("C");
        }

        // c - for  Anonymous Method (GetISBN).
        public static string GetISBN(Book book)
        {
            return book.ISBN;
        }


        // d - for Lambda Expression (GetPublicationDate).
        public static DateTime GetPublicationDate(Book book)
        {
            return book.PublicationDate;
        }


    }
}
