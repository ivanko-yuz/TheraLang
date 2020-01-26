using System;
using TheraLang.DAL.Piranha.Entities;
﻿using TheraLang.DAL.Entities;

namespace TheraLang.BLL.DataTransferObjects
{
    public class ProjectParticipationDto
    {
        public int Id { get; set; }
        public User User { get; set; }

        public MemberRoleDto Role { get; set; }

        public ProjectParticipationStatusDto Status { get; set; }

        public int ProjectId { get; set; }

        public string ProjectName { get; set; }

        public Guid RequstedGuidUserId { get; set; }

        public string RequestedUserName { get; set; }

        public string RequestedUserEmail { get; set; }
    }
}
