using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.Services;
using Piranha;
using Piranha.AspNetCore.Services;
using Piranha.Models;

namespace MvcWeb.Controllers
{
    [Route("/api/[controller]")]
    public class CmsController : ControllerBase
    {
        private readonly PiranhaSitemapService _piranhaSitemapService;
        private readonly IApi _api;
        private readonly IDb _db;
        private readonly IModelLoader _loader;

        public CmsController(IApi api, IDb db, IModelLoader loader, PiranhaSitemapService piranhaSitemapService)
        {
            _piranhaSitemapService = piranhaSitemapService;
            _api = api;
            _db = db;
            _loader = loader;
        }

        [HttpGet("sitemap")]
        public async Task<IActionResult> Sitemap(Guid? id = null)
        {
            return Ok(await _piranhaSitemapService.GetSiteMap());
        }

        [Route("archive")]
        public async Task<IActionResult> Archive(Guid id, int? year = null, int? month = null, int? page = null,
            Guid? category = null, Guid? tag = null)
        {
            var model = await _api.Pages.GetByIdAsync<Models.BlogArchive>(id);
            model.Archive = await _api.Archives.GetByIdAsync(id, page, category, tag, year, month);

            return Ok(model);
        }

        [Route("page")]
        public async Task<IActionResult> Page(Guid id, bool draft = false)
        {
            var model = await _loader.GetPage<Models.StandardPage>(id, HttpContext.User, draft);

            return Ok(model);
        }

        [Route("pagewide")]
        public async Task<IActionResult> PageWide(Guid id, bool draft = false)
        {
            var model = await _loader.GetPage<Models.StandardPage>(id, HttpContext.User, draft);

            return Ok(model);
        }

        [Route("post")]
        public async Task<IActionResult> Post(Guid id, bool draft = false)
        {
            var model = await _loader.GetPost<Models.BlogPost>(id, HttpContext.User, draft);

            return Ok(model);
        }

        [Route("teaserpage")]
        public async Task<IActionResult> TeaserPage(Guid id, bool startpage = false, bool draft = false)
        {
            var model = await _loader.GetPage<Models.TeaserPage>(id, HttpContext.User, draft);

            if (startpage)
            {
                var latest = _db.Posts
                    .Where(p => p.Published <= DateTime.Now)
                    .OrderByDescending(p => p.Published)
                    .Take(1)
                    .Select(p => p.Id);
                if (latest.Count() > 0)
                {
                    model.LatestPost = await _api.Posts
                        .GetByIdAsync<PostInfo>(latest.First());
                }
                return Ok(model);
            }
            return Ok(model);
        }
    }
}
