using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
   public interface IResourceAttachmentService
   {
       Task AddAsync(ResourceAttachDto file);

       Task<IEnumerable<ResourceAttachDto>> GetAsync();
   }
}
