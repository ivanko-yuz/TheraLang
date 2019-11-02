using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/project/resources/categories")]
    public class ResourceCategoryController : Controller
    {
        [HttpGet("")]
        public System.Collections.Generic.IEnumerable<ResourceCategory> GetAllCategories()
        {
            ResourceCategory resourceCategory1 = new ResourceCategory() { Id = 1, Name = "Зображення" };
            ResourceCategory resourceCategory2 = new ResourceCategory() { Id = 2, Name = "Відео" };
            ResourceCategory resourceCategory3 = new ResourceCategory() { Id = 3, Name = "Посилання" };
            ResourceCategory resourceCategory4 = new ResourceCategory() { Id = 4, Name = "Файли" };
            ResourceCategory[] categories = new ResourceCategory[] { resourceCategory1, resourceCategory2, resourceCategory3, resourceCategory4 };
            return categories;
        }
    }
}
