using System;
using System.Collections.Generic;

namespace TheraLang.DAL.Piranha.Entities
{
    public sealed class PiranhaMediaFolder
    {
        public PiranhaMediaFolder()
        {
            PiranhaMedia = new HashSet<PiranhaMedia>();
        }

        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public Guid? ParentId { get; set; }

        public ICollection<PiranhaMedia> PiranhaMedia { get; set; }
    }
}