﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace TheraLang.BLL.DataTransferObjects.NewsDtos
{
    public class NewsEditDto
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public IFormFile NewMainImage { get; set; }
        public string UploadedMainImageUrl { get; set; }
        public ICollection<IFormFile> AddedContentImages { get; set; }
        public ICollection<string> NotDeletedContentImageUrls { get; set; }
    }
}