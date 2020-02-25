using System;
using Common.Enums;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.DataTransferObjects
{
    public class ProjectParticipationDto
    {
        public int Id { get; set; }
        public User User { get; set; }

        public MemberRole Role { get; set; }

        public ProjectParticipationStatus Status { get; set; }

        public int ProjectId { get; set; }

        public string ProjectName { get; set; }

        public Guid RequstedGuidUserId { get; set; }

        public string RequestedUserName { get; set; }

        public string RequestedUserEmail { get; set; }
    }
}