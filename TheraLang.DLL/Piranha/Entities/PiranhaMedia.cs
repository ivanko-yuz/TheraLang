using System;
using System.Collections.Generic;

namespace TheraLang.DLL.Piranha.Entities
{
    public sealed class PiranhaMedia
    {
        public PiranhaMedia()
        {
            PiranhaMediaVersions = new HashSet<PiranhaMediaVersion>();
        }

        public Guid Id { get; set; }
        public string ContentType { get; set; }
        public DateTime Created { get; set; }
        public string Filename { get; set; }
        public Guid? FolderId { get; set; }
        public DateTime LastModified { get; set; }
        public string PublicUrl { get; set; }
        public long Size { get; set; }
        public int Type { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }

        public PiranhaMediaFolder Folder { get; set; }
        public ICollection<PiranhaMediaVersion> PiranhaMediaVersions { get; set; }
    }
}