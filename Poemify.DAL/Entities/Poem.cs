﻿using Poemify.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poemify.DAL.Entities
{
    public class Poem : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }
        
        public Category Category { get; set; } = Category.Sad;
        public int Likes { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

      
    }
}
