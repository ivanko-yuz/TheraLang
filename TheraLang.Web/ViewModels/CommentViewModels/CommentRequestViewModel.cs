﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheraLang.Web.ViewModels.CommentViewModels
{
    public class CommentRequestViewModel
    {
        public string Text { get; set; }
        public int PostId { get; set; }
    }
}