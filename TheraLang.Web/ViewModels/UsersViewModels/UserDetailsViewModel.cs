using Microsoft.AspNetCore.Http;
using System;

namespace TheraLang.Web.ViewModels.UsersViewModels
{
    public class UserDetailsViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IFormFile Image { get; set; }
        public string PhoneNumber { get; set; }
        public string ShortInformation { get; set; }
        public DateTime BirthdayDate { get; set; }
    }
}