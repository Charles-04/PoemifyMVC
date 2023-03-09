using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poemify.DAL.Entities
{
    internal class Poem : BaseEntity
    { 
    
        public string Name { get; set; }
        public string Body { get; set; }
        public string Category { get; set; }
        public int Likes { get; set; }
      
    }
}
