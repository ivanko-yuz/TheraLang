using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.DLL.Entities;
using TheraLang.DLL.Models;

namespace TheraLang.DLL.Services
{
   public interface IResourceAttachmentService
   {
       Task Add(ResourceAttachModel file);              

       IEnumerable<ResourceAttachment> Get();
   }
}
