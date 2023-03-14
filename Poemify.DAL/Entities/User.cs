using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poemify.DAL.Entities
{
    public class User : BaseEntity
    {
        [Required]
        public string FullName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsPoet { get;set; }
        public ICollection<Poem> Poems { get; set; }
    }
}
