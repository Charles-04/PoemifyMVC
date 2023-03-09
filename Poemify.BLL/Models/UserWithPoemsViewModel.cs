using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poemify.BLL.Models
{
	public class UserWithPoemsViewModel
	{
		public int UserId { get; set; }
		public IEnumerable<PoemViewModel> Poems { get; set; }
	}
}
