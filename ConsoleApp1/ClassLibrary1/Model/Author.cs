using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Model
{
    public class Author
    {
        private int id { get; set; }
        private string name { get; set; }
        private List<Book> books { get; set; }
        private string description { get; set; }

        public Author(int id, string name, List<Book> books, string description)
        {
            this.id = id;
            this.name = name;
            this.books = books;
            this.description = description;
        }
    }
}
