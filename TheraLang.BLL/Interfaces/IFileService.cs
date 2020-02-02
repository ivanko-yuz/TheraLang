using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace TheraLang.BLL.Interfaces
{
    public interface IFileService
    {
        Task<Uri> SaveFileAsync(IFormFile file);
    }
}