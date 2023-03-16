using AutoMapper;
using Poemify.BLL.Interfaces;
using Poemify.BLL.Models;
using Poemify.DAL.Entities;
using Poemify.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace Poemify.BLL.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IRepository<User> _userRepo;
        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
            this._userRepo = _unitOfWork.GetRepository<User>();
        }
        public async Task< (bool created, string messsage)> CreateUserAsync(CreateUserViewModel model)
        {
            User user = await _userRepo.GetSingleByAsync(u => u.Email == model.Email, include: u => u.Include(p => p.Poems), tracking: true);
            if (user == null)
            {
               var newUser = _mapper.Map<User>(model);
                _userRepo.Add(newUser);
                var rowChanges = await _unitOfWork.SaveChangesAsync();

                return rowChanges > 0 ? (true, $"User: {model.FullName} was successfully created!") : (false, "Failed To save changes!");
            }
            return (false, "User with email already exists");
        }

        public async Task<IEnumerable<User>> ViewPoetsAsync()
        {
            
            var users = await _userRepo.GetAllAsync();
            if (users.Count() <= 0)
            {
                return null;
            }
         
            return users;

        }
    }
}
