using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCert.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DevCert.WebAPI.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            var users = new List<User> {
new User { Name ="John Doe", Email ="johnrichard.malabanan.0916@gmail.com"}

            };

            return Ok(users);

        }
    }
}

