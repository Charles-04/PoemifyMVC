using Poemify.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poemify.BLL.Interfaces
{
	public interface IPoemService
	{
		Task<(bool isCreated, string messsage)> CreateAndUpdatePoemAsync(CreateAndUpdatePoemViewModel model);
		Task<(bool isViewed, string messsage)> ViewPoemAsync(int userId, int poemId);
		Task<(bool isUpdated, string messsage)> UpdatePoemAsync(int userId, int poemId);
		Task<(bool isDeleted, string messsage)> DeletePoemAsync(int userId, int poemId);
	}
}
