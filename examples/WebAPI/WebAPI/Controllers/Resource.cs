﻿using System;

namespace WebAPI.Controllers
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int? ProjectId { get; set; }
        public string ResourceCategory { get; set; }
    }
}
