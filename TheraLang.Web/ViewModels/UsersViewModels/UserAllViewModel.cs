using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace TheraLang.Web.ViewModels.UsersViewModels
{
    public class UserAllViewModel
    {
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Compare("Password")]
        [Required]
        public string ConfirmPassword { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public IFormFile Image { get; set; }
        public DateTime? BirthDay { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
    }
}