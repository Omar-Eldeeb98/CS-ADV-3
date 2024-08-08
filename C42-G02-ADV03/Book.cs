using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV03
{
    public class Book
    {

        // properties
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[]  Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        //constructors
        public Book(string iSBN, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }

        // methods

        public override string ToString()
        {
            string authors = string.Join(", ", Authors);
            return $"ISBN: {ISBN} , Title: {Title} , PublicationDate: {PublicationDate.ToShortDateString()} , Price: {Price} , Authors: {authors}";
        }


    }
}
