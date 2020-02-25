using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Enums;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.BLL.Interfaces
{
    public interface ISiteMapService
    {
        Task<IEnumerable<SiteMapDto>> GetAll(Language lang = default);

        Task UpdateStructure(IEnumerable<SiteMapDto> siteMap);
    }
}