using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TheraLang.BLL.Interfaces
{
    public interface IPictureService
    {
        void SavePictures(string htmlContent);
    }
}
