using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain
{
    public abstract class User
    {
        private int id { get; set; }
        private string email { get; set; }
        private string password { get; set; }
        private string name { get; set; }
        private Settings settings { get; set; } 
        public User(int id, string email, string password, string name, Settings settings)
        {
            this.id = id;
            this.email = email;
            this.password = password;
            this.name = name;
            this.settings = settings;
        }
    }
}
