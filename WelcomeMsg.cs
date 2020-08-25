using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeEntry
{
    public class WelcomeMsg
    {
        public string Message { get; set; }
        public WelcomeMsg(string message)
        {
            this.Message = message;
        }
    }
}
