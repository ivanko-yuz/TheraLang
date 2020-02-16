using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.DAL.Enums;

namespace TheraLang.BLL.Interfaces
{
    public interface ISiteMapService
    {
        Task<IEnumerable<SiteMapDto>> GetAll(Language lang = default);

        Task UpdateStructure(IEnumerable<SiteMapDto> siteMap);
    }
}