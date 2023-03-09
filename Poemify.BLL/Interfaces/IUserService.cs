using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poemify.BLL.Interfaces
{
	internal interface IUserService
	{
		(bool created, string messsage) CreateUserAsync();
		(bool created, string messsage) ViewPoetsAsync(int userId, int poemId);
	}
}
