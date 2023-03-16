using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poemify.BLL.Models
{
	public class CreateUserViewModel
	{
		[Required]
		public string FullName { get; set; }
		[Required]
		public string Email { get; set; }
		[Required]
		public string Password { get; set; }
		[Required]
        public string Title { get; set; }
		[Required]
		public string Bio { get; set; }
		public string IsPoet { get; set; }

	}
}
