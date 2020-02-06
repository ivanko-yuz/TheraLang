using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface ISiteMapService
    {
        Task<IEnumerable<SiteMapDto>> GetAll();
        Task UpdateStructure(IEnumerable<SiteMapDto> siteMap);
    }
}