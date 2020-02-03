using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface ISiteMapService
    {
        Task<IEnumerable<SiteMapDto>> GetAll();
        Task Add(SiteMapDto siteMap);
        Task Remove(int id);
        Task Update(int id, SiteMapDto newSiteMap);
    }
}