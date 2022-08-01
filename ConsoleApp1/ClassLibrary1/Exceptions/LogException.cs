using Bookify.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Exceptions
{
    public class LogException: Exception
    {
        public LogException(string? message, User user) : base(message)
        {
            saveLog(message, user);
        }
        public void saveLog(string message, User user)
        {
            FileStream fs = new FileStream(Directory.GetCurrentDirectory()+ "\\log.txt", FileMode.Open);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(user.name + ": " + message + " " + DateTime.Now);
            }
            
            

        }
    }
}
