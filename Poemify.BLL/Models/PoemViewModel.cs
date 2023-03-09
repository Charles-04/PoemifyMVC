using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poemify.BLL.Models
{
	public class PoemViewModel
	{
		public string Title { get; set; }
		public string Author { get; set; }
		public string Body { get; set; }
		public string WrittenOn { get; set; }
		public string Likes { get; set; }
	}
}
