using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.DLL.Entities;
using TheraLang.DLL.Models;

namespace TheraLang.Web.Services
{
    public interface IResourceAttachmentService
    {
        Task Add(ResourceAttachModel file);       

         void SaveAs(ResourceAttachModel resource, bool overwrite = true, bool autoCreateDirectory = true);

        IEnumerable<ResourceAttachment> Get();
    }
}
