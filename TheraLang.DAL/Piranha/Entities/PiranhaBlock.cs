using System;
using System.Collections.Generic;

namespace TheraLang.DAL.Piranha.Entities
{
    public sealed class PiranhaBlock
    {
        public PiranhaBlock()
        {
            
            PiranhaBlockFields = new HashSet<PiranhaBlockField>();
            PiranhaPageBlocks = new HashSet<PiranhaPageBlock>();
            PiranhaPostBlocks = new HashSet<PiranhaPostBlock>();
        }

        public Guid Id { get; set; }
        public string ClrType { get; set; }
        public DateTime Created { get; set; }
        public bool IsReusable { get; set; }
        public DateTime LastModified { get; set; }
        public string Title { get; set; }
        public Guid? ParentId { get; set; }

        public ICollection<PiranhaBlockField> PiranhaBlockFields { get; set; }
        public ICollection<PiranhaPageBlock> PiranhaPageBlocks { get; set; }
        public ICollection<PiranhaPostBlock> PiranhaPostBlocks { get; set; }
    }
}