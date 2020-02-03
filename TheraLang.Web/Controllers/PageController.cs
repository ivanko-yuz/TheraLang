using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;


namespace TheraLang.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PageController : ControllerBase
    {
        private readonly IPageService _pageService;
        private readonly IUserManagementService _userManagementService;

        public PageController(IPageService pageService, IUserManagementService userManagementService)
        {
            _pageService = pageService;
            _userManagementService = userManagementService;
        }


    }
}