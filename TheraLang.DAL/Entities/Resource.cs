﻿using System.Collections.Generic;

namespace TheraLang.DAL.Entities
{
    public class Resource : BaseEntity
    {
        public virtual User User { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public string FileName { get; set; }

        public string File { get; set; }

        public int CategoryId { get; set; }

        public virtual ResourceCategory ResourceCategory { get; set; }

        public virtual ICollection<ResourceProject> ResourceProjects { get; set; }
        public virtual ICollection<ResourceAttachment> ResourceAttach { get; set; }

        public Resource()
        {
            ResourceAttach = new List<ResourceAttachment>();
            ResourceProjects = new List<ResourceProject>();
        }
    }
}