using System;
using System.Collections.Generic;
using System.Text;

namespace TheraLang.BLL.DataTransferObjects
{
    public class AuthUser
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
    }
}
