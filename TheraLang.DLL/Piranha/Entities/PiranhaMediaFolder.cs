using System;
using System.Collections.Generic;

namespace TheraLang.DLL.Piranha.Entities
{
    public class PiranhaMediaFolder
    {
        public PiranhaMediaFolder()
        {
            PiranhaMedia = new HashSet<PiranhaMedia>();
        }

        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public Guid? ParentId { get; set; }

        public virtual ICollection<PiranhaMedia> PiranhaMedia { get; set; }
    }
}