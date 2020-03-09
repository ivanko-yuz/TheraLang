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
        public decimal Balance { get; set; }
        public string City { get; set; }
        public DateTime? BirthDay { get; set; }
    }
}