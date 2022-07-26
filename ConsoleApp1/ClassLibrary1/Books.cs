using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain
{
    public class Books: IEnumerable<Book>
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
        public void add(Book _book)
        {
            var books= new Book[this._books.Length+1];
            for(int i = 0; i < this._books.Length; i++)
            {
                books[i] = this._books[i];
            }
            books[this._books.Length] = _book;
            this._books = books;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
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

