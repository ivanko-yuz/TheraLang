using System.Collections.Generic;

namespace TheraLang.BLL.DataTransferObjects
{
    public class UsersListDto
    {
        public List<UsersDto> UserList { get; set; }
        public int CountOfItems { get; set; }
    }
}
