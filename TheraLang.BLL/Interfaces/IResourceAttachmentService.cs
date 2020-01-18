using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Models;

namespace TheraLang.BLL.Interfaces
{
   public interface IResourceAttachmentService
   {
       Task Add(ResourceAttachModel file);              

       IEnumerable<ResourceAttachment> Get();
   }
}
