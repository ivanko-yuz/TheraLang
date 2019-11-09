using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcWeb.Db;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.Pagination;
namespace MvcWeb.TheraLang.Controllers
{
    public class PaginationController : Controller
    {
        IttmmDbContext context;
        public PaginationController(IttmmDbContext Context)
        {
            this.context = Context;
        }
        //public async Task<IActionResult> Index(int page = 1)
        //{
        //    int pageSize = 5;
        //    IQueryable<Project> source = context
        //    var count = await source.CountAsync();
        //    var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        //    PageVievModel pageViewModel = new PageVievModel(count, page, pageSize);
        //    IndexVievModel viewModel = new IndexVievModel
        //    {
        //        PageViewModel = pageViewModel,
        //        Projects = items
        //    };
        //    return View(viewModel);
        //}
    }
}
