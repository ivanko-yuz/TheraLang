﻿using System;

namespace TheraLang.Web.ViewModels.CommentViewModels
{
    public class CommentResponseViewModel
    {
        public int Id { get; set; }
        public Guid CreatedById { get; set; }
        public string Text { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImageUrl { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public bool isEdited { get; set; }
    }
}
