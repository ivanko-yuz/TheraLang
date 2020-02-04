using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace TheraLang.BLL.Interfaces
{
    public interface IFileService
    {
        Task<Uri> SaveFile(IFormFile file);
    }
}