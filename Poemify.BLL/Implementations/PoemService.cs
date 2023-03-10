using Poemify.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poemify.BLL.Implementations
{
	internal class PoemService : IPoemService
	{
		public (bool isCreated, string messsage) CreatePoemAsync()
		{
			throw new NotImplementedException();
		}

		public (bool isDeleted, string messsage) DeletePoemAsync(int userId, int poemId)
		{
			throw new NotImplementedException();
		}

		public (bool isUpdated, string messsage) UpdatePoemAsync(int userId, int poemId)
		{
			throw new NotImplementedException();
		}

		public (bool isViewed, string messsage) ViewPoemAsync(int userId, int poemId)
		{
			throw new NotImplementedException();
		}
	}
}
