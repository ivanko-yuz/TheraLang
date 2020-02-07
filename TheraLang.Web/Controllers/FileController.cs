using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels;

namespace TheraLang.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IFileService _fileManager;
        
        public FileController(IFileService fileManager)
        {
            _fileManager = fileManager;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> Upload([FromForm]FileViewModel file)
        {
            var uri = await _fileManager.SaveFile(file.File);
            return Ok(new { FileUri = uri});
        }
    }
}