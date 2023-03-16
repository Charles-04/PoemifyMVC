using Poemify.BLL.Models;
using Poemify.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poemify.BLL.Interfaces
{
	public interface IUserService
	{
		Task<(bool created, string messsage) >CreateUserAsync(CreateUserViewModel model);
		Task<IEnumerable<User>> ViewPoetsAsync();

    }
}
