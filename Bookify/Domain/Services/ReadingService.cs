using Bookify.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Services
{
    public class ReadingService
    {
        public static string ReadBook(User user, Book book)
        {
            string bookContent;
            try
            {
                bookContent = book.getContent(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            user.readBook(book);
            return bookContent;
        }
    }
}
