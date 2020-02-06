using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
   public interface IResourceAttachmentService
   {
       Task Add(ResourceAttachDto file);

       Task<IEnumerable<ResourceAttachDto>> Get();
   }
}
