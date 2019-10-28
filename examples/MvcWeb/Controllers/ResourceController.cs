using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MvcWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        [HttpPost]
        public HttpResponse CreateResource(string type, string description, int categoryId)
        {

        }

        [HttpPut]
        public void EditResource()
        {

        }
    }
}