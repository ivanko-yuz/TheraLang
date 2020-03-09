using System;

namespace TheraLang.Web.ViewModels
{
    public class UsersViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ShortInformation { get; set; }
        public string ImageURl { get; set; }
        public string City { get; set; }
        public DateTime? BirthDay { get; set; }
    }
}