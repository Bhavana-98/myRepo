using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TimeEntry.Controllers
{
    [Route("api/[controller]")]
    public class WelcomeController : Controller
    {
        public WelcomeMsg _message;
        public WelcomeController(WelcomeMsg message)
        {
            this._message = message;
        }
        [HttpGet]
        public string SayHello() => _message.Message;
    }
}
