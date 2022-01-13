using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    internal class Library
    {
        public Book[] books;

        public Library(Book[] books)
        {
            this.books = books;
        }

        public void SortingLibrary(DelegatToSortZad2 d)
        {
            d.Invoke();
        }
        public void SortByName()
        {
            books = books.OrderBy(e => e.Name).ToArray();
        }
        public void SortByAuthor()
        {
            books = books.OrderBy(e => e.Author).ToArray();
        }
        public void SortByPublishing()
        {
            books = books.OrderBy(e => e.Publish).ToArray();
        }



        public override string ToString()
        {
            string s = "";
            foreach (var book in books)
            {
                s += $"Название: {book.Name}\n Автор: {book.Author}\n Издание: {book.Publish}\n\n";
            }
            return s;
        }
    }
}
