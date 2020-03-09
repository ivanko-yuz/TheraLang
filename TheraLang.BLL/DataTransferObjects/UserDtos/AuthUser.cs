using System;

namespace TheraLang.BLL.DataTransferObjects
{
    public class AuthUser
    {
        public Guid Id { get; set; }
        public string UserEmail { get; set; }
        public string Role { get; set; }
    }
}