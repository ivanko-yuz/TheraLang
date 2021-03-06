﻿using System;
using Common.Enums;

namespace TheraLang.Web.ViewModels
{
    public class ParticipantViewModel
    {
        public int Id { get; set; }

        public MemberRole Role { get; set; }

        public ProjectParticipationStatus Status { get; set; }

        public int ProjectId { get; set; }

        public string ProjectName { get; set; }

        public Guid RequstedGuidUserId;

        public string RequestedUserName { get; set; }

        public string RequestedUserEmail { get; set; }

        public string UserName { get; set; }

        public string UserEmail { get; set; }
    }
}