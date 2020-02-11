using System;
using Common.Exceptions;
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
            throw new NullReferenceException("Useful message");
        }

        [HttpGet("argnull")]
        public IActionResult ArgNull()
        {
            throw new ArgumentNullException("param","Useful message");
        }

        [HttpGet("managed")]
        public IActionResult Managed()
        {
            throw new ApiException("Useful message");
        }
    }
}