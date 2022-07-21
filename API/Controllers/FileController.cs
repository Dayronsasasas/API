using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous()]
    [EnableCors()]
    public class FileController : Controller
    {
       
        // POST api/values
        [HttpPost]
        public string Post(IFormCollection data,IFormFile file)
        {
            var a = data;
            var b = file;
            return "Recibido";
        }
        [HttpGet()]
        public IEnumerable<String> Get()
        {
            return new List<String>() { "hello", "hello 1" };
        }

    }
}

