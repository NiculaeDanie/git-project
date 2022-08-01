using Bookify.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Model
{
    public class ReadingHistory
    {
        public Books books { get; set; }
        public ReadingHistory(Books books)
        {
            this.books = books;
        }
        public void add(Book book)
        {
            books.add(book);
        }
        public List<Book> getUserPrefferences(Books allBook,User user)
        {
            if(books.getLength() == 0)
            {
                throw new HistoryEmptyException("History is empty",user);
            }
            var genres = books.Select(p => p.genre);
            var pref = genres.SelectMany(x => x).ToList();
            var pBooks = new List<Book>();
            foreach(var item in allBook)
            {
                if(pref.Any(x => item.genre.Any(y => y == x)) && !(books.Contains(item))){
                    pBooks.Add(item);
                }
            }
            return pBooks; 
        }
    }
}
