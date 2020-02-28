using System;
using System.Collections.Generic;
using System.Text;

namespace TheraLang.BLL.DataTransferObjects
{
    public class UsersListDto
    {
        public List<UsersDto> UserList { get; set; }
        public int CountOfItems { get; set; }
    }
}
