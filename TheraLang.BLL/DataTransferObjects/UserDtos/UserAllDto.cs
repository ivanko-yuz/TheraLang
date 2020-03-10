using Microsoft.AspNetCore.Http;
using System;

namespace TheraLang.BLL.DataTransferObjects.UserDtos
{
    public class UserAllDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IFormFile Image { get; set; }
        public string ImageURl { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ShortInformation { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Balance { get; set; }
        public DateTime? BirthDay { get; set; }
    }
}