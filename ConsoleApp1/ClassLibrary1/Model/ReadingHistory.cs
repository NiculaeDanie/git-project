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
        public List<string> getUserPrefferences()
        {
            if(books.getLength() == 0)
            {
                throw new HistoryEmptyException();
            }
            var pref = new List<string>();
            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach(var book in books)
            {
                foreach(var genre in book.genre)
                {
                    if (map.ContainsKey(genre))
                    {
                        map[genre]++;
                    }
                    else
                    {
                        map[genre] = 1;
                    }
                }
            }
            var ordered = map.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            int i = 0;
            foreach(var item in ordered.Keys)
            {
                pref.Add(item);
                i++;
                if (i > 4)
                {
                    break;
                }
            }
            return pref;
        }
    }
}
