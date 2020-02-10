using System;
using Microsoft.AspNetCore.Mvc;

namespace TheraLang.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExceptionController: ControllerBase
    {
        [HttpGet("nullref")]
        public IActionResult NullRef()
        {
            throw new NullReferenceException("asdadsadsdsa");
        }
    }
}