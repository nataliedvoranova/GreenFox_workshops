using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using thereddit.Models;

namespace thereddit.Controllers
{
    public class RedditController : Controller
    {
        private IPost postService;
        private IUser userService;
        public RedditController(IPost postService)
        {
            this.postService = postService;
        }

        public RedditController(IUser userService)
        {
            this.userService = userService;
        }
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}