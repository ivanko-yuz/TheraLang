using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.Interfaces
{
   public interface IResourceAttachmentService
   {
       Task Add(ResourceAttachDto file);              

       IEnumerable<ResourceAttachDto> Get();
   }
}
