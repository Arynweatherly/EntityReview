﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityReview.Models
{
    public class Cat
    {
        public int Id { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }
        public bool IsChonky { get; set; }
        public string Name { get; set; }
        public bool IsFixed { get; set; }
    }
}
