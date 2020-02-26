using System;
using System.Collections.Generic;
using System.Text;

namespace TheraLang.BLL.DataTransferObjects.UserDtos
{
    public class ConfirmUserDto
    { 
        public int ConfirmationNumber { get; set; }
        public string Email { get; set; }
    }
}
