using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Model
{
    public class BookEnum : IEnumerator<Book>
    {
        public Book[] _books;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public BookEnum(Book[] list)
        {
            _books = list;
        }

        public bool MoveNext()
        {
            position++;
            return position < _books.Length;
        }

        public void Reset()
        {
            position = -1;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Book Current
        {
            get
            {
                try
                {
                    return _books[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
