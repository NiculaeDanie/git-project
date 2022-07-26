using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain
{
    public class AdminUser : User, IAdmin
    {
        public AdminUser(int id, string email, string password, string name, Settings settings) : base(id, email, password, name, settings)
        {
        }

        public void addBook(Books _books, Book _book)
        {
            _books.add(_book);
        }
    }
}
