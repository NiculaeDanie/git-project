using Bookify.Domain.Exceptions;
using Bookify.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Model
{
    public class User
    {
        private string id { get; set; }
        private string email { get; set; }
        private string password { get; set; }
        private string name { get; set; }
        private Settings settings { get; set; }
        private ReadingHistory history { get; set; }
        public User(string id, string email, string password, string name, ReadingHistory history)
        {
            this.id = id;
            this.email = email;
            this.password = password;
            this.name = name;
            this.settings = Settings.GetSettings();
            this.history = history;
        }
        public User(string id, string email, string password, string name)
        {
            this.id = id;
            this.email = email;
            this.password = password;
            this.name = name;
            this.settings = Settings.GetSettings();
            this.history = new ReadingHistory(new Books());
        }

        public void readBook(Book book)
        {
            history.add(book);
        }

        public List<string> getPreferences()
        {
            try
            {
                return history.getUserPrefferences();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

    }
}
