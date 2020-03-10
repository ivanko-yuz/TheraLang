using System;
using System.Collections.Generic;
using System.Text;

namespace TheraLang.BLL.DataTransferObjects.UserDtos
{
   public class UsersListDto
    {
        public IEnumerable<UsersDto> UserList { get; set; }
        public int CountOfItems { get; set; }
    }
}
