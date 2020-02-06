using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheraLang.BLL.CustomTypes;

namespace TheraLang.BLL.Interfaces
{
    public interface IHtmlContentService
    {
        Task<HtmlContent> SavePictures(HtmlContent htmlContent);
    }
}
