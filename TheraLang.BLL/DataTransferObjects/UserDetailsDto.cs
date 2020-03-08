using Microsoft.AspNetCore.Http;
using System;

namespace TheraLang.BLL.DataTransferObjects
{
    public class UserDetailsDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IFormFile Image { get; set; }
        public string PhoneNumber { get; set; }
        public string ShortInformation { get; set; }
        public string ImageURl { get; set; }
        public string City { get; set; }
        public DateTime? BirthdayDate { get; set; }
    }
}