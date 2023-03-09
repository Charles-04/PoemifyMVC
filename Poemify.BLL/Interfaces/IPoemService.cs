using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poemify.BLL.Interfaces
{
	internal interface IPoemService
	{
		(bool isCreated, string messsage) CreatePoemAsync();
		(bool isViewed, string messsage) ViewPoemAsync(int userId, int poemId);
		(bool isUpdated, string messsage) UpdatePoemAsync(int userId, int poemId);
		(bool isDeleted, string messsage) DeletePoemAsync(int userId, int poemId);
	}
}
