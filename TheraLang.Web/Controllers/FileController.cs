using System.IO;
using System.Threading.Tasks;
using FluentValidation;
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
        private readonly IValidator<FileViewModel> _validator;

        public FileController(IFileService fileManager, IValidator<FileViewModel> validator)
        {
            _fileManager = fileManager;
            _validator = validator;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> Upload([FromForm] FileViewModel file)
        {
            var extension = Path.GetExtension(file.File.FileName);
            var fileStream = file.File.OpenReadStream();
            var uri = await _fileManager.SaveFile(fileStream, extension);
            return Ok(new {FileUri = uri});
        }
    }
}