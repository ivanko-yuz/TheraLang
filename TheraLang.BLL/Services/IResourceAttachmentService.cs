using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.DLL.Entities;
using TheraLang.DLL.Models;

namespace TheraLang.BLL.Services
{
   public interface IResourceAttachmentService
   {
       Task Add(ResourceAttachModel file);              

       IEnumerable<ResourceAttachment> Get();
   }
}
