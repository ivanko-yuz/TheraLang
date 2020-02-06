using System;
using System.Collections.Generic;
using System.Text;

namespace TheraLang.DAL.Entities
{
    public class UploadedNewsImage : BaseEntity
    {
        public string Url { get; set; }

        public virtual News News { get; set; }
    }
}
