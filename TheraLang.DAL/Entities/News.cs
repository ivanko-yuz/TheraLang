﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TheraLang.DAL.Entities
{
    public class News : BaseEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public ICollection<string> UploadedImageUrls { get; set; }
    }
}
