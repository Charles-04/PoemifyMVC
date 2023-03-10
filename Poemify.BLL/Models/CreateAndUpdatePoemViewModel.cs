using Poemify.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poemify.BLL.Models
{
	public class CreateAndUpdatePoemViewModel
	{
		public int Id { get; set; }
		public int UserId { get; set; }
		public string Title { get; set; }
		public string Body { get; set; }
		public Category Category { get; set; }
		public int Likes { get; set; }
	}
}
