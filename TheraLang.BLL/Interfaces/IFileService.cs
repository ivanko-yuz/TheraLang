using System;
using System.IO;
using System.Threading.Tasks;

namespace TheraLang.BLL.Interfaces
{
    public interface IFileService
    {
        Task<Uri> SaveFile(Stream stream,string fileExtension);
    }
}