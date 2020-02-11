using System.Threading.Tasks;
using TheraLang.BLL.CustomTypes;

namespace TheraLang.BLL.Interfaces
{
    public interface IHtmlContentService
    {
        Task<HtmlContent> SavePictures(HtmlContent htmlContent);
    }
}
