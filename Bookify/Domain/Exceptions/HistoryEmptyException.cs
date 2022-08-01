using Bookify.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Exceptions
{
    public class HistoryEmptyException : LogException
    {
        public HistoryEmptyException(string? message, User user) : base(message, user)
        {
        }
    }
}
