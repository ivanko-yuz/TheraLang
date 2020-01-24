using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.FileManager;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels;

namespace TheraLang.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IHostingEnvironment _env;
        private readonly IFileService _fileManager;
        
        public FileController(IHostingEnvironment env, IFileService fileManager)
        {
            _env = env;
            _fileManager = fileManager;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> Upload([FromForm]FileViewModel file)
        {
            if (file.File == null)
            {
                return BadRequest("Invalid file");
            }
            var uri = await _fileManager.SaveFile(file.File);
            return Ok(new { FileUri = uri});
        }
    }
}