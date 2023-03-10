using Poemify.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poemify.DAL.Entities
{
    internal class Poem : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Body { get; set; }
        
        public Category Category { get; set; }
        public int Likes { get; set; }
      
    }
}
