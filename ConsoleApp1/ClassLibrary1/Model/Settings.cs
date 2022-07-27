using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Model
{
    public class Settings
    {
        private int textSize { get; set; }
        private string backgroundColor { get; set; }
        private Settings(int textSize, string backgroundColor)
        {
            this.textSize = textSize;
            this.backgroundColor = backgroundColor;
        }
        public static Settings GetSettings()
        {
            return new Settings(7, "white");
        }
    }
}
