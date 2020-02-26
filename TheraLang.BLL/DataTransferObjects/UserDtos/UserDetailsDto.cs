using Microsoft.AspNetCore.Http;

namespace TheraLang.BLL.DataTransferObjects.UserDtos
{
    public class UserDetailsDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IFormFile Image { get; set; }
        public string PhoneNumber { get; set; }
        public string ShortInformation { get; set; }
        public string ImageURl { get; set; }
    }
}