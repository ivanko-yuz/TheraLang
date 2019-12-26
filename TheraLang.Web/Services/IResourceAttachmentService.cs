using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.DLL.Entities;

namespace TheraLang.Web.Services
{
   public interface IResourceAttachmentService
   {
       Task Add(ResourceAttachment file);       

        void SaveAs(ResourceAttachment resource, bool overwrite = true, bool autoCreateDirectory = true);

       IEnumerable<ResourceAttachment> Get();
   }
}
