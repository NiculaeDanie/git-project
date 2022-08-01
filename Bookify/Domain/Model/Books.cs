using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Model
{
    public class Books : IEnumerable<Book>
    {
        private Book[] _books;
        public Books(Book[] bArray)
        {
            _books = new Book[bArray.Length];

            for (int i = 0; i < bArray.Length; i++)
            {
                _books[i] = bArray[i];
            }
        }

        public Books()
        {
            _books = new Book[0];
        }

        public void add(Book _book)
        {
            var books = new Book[_books.Length + 1];
            for (int i = 0; i < _books.Length; i++)
            {
                books[i] = _books[i];
            }
            books[_books.Length] = _book;
            _books = books;
        }
        public int getLength()
        {
            return _books.Length;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public BookEnum GetEnumerator()
        {
            return new BookEnum(_books);
        }

        IEnumerator<Book> IEnumerable<Book>.GetEnumerator()
        {
            return new BookEnum(_books);
        }
    }
}

