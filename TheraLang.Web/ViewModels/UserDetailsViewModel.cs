using Microsoft.AspNetCore.Http;

namespace TheraLang.Web.ViewModels
{
    public class UserDetailsViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IFormFile Image { get; set; }
        public string PhoneNumber { get; set; }
        public string ShortInformation { get; set; }
    }
}