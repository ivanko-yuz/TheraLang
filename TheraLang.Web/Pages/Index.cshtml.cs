using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TheraLang.Web.Pages
{
    public class IndexModel : PageModel
    {
        private IHostingEnvironment _hostingEnvironment;

        public string _wwwroot { get; private set; }

        public string _currentRoutePath { get; private set; }

        public IndexModel(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public void OnGet(string currentRoutePath)
        {
            _wwwroot = _hostingEnvironment.WebRootPath;
            _currentRoutePath = "/";

            if (currentRoutePath != null)
            {
                _currentRoutePath = currentRoutePath;
            }
        }
    }
}