using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain
{
    internal interface IAdmin
    {
        public void addBook(Books _books, Book _book);
    }
}
