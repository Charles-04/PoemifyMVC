using AutoMapper;
using Poemify.BLL.Interfaces;
using Poemify.DAL.Repository;
using Poemify.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Poemify.BLL.Models;
using Microsoft.EntityFrameworkCore;

namespace Poemify.BLL.Implementations
{
	public class PoemService : IPoemService
	{
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
		private readonly IRepository<Poem> _poemRepo;
		private readonly IRepository<User> _userRepo;

        public PoemService(IUnitOfWork unitOfWork,IMapper mapper)
		{
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
			this._poemRepo = _unitOfWork.GetRepository<Poem>();
			this._userRepo = _unitOfWork.GetRepository<User>();
			
        }
		public async Task<(bool isCreated, string messsage)> CreateAndUpdatePoemAsync(CreateAndUpdatePoemViewModel model)
		{
			User user = await _userRepo.GetSingleByAsync(u => u.Id == model.UserId,include: u => u.Include(p => p.Poems), tracking : true);
			if (user == null)
			{
				return (false, $"User with Id {model.UserId} was not found");
			}
			var poem = user.Poems.SingleOrDefault(p => p.Id == model.Id);
			if (poem != null)
			{
				_mapper.Map(model, poem);
                await _unitOfWork.SaveChangesAsync();
                return (true, "Update Successful!");
            }

            var newPoem = _mapper.Map<Poem>(model);

            user.Poems.Add(newPoem);

            var rowChanges = await _unitOfWork.SaveChangesAsync();

            return rowChanges > 0 ? (true, $"Poem: {model.Title} was successfully created!") : (false, "Failed To save changes!");
        }

		public async Task<(bool isDeleted, string messsage)> DeletePoemAsync(int userId, int poemId)
		{
			User user = await _userRepo.GetSingleByAsync(u => u.Id == userId, include: u => u.Include(p => p.Poems), tracking: true);
			if (user == null)
			{
				return (false, $"User with Id {userId} was not found");
			}
            var poem = user.Poems.SingleOrDefault(p => p.Id == poemId);

            if (poem == null)
			{
                return (false, $"Poem with Id {poemId} was not found");
            }
			user.Poems.Remove(poem);
            var rowChanges = await _unitOfWork.SaveChangesAsync();

            return rowChanges > 0 ? (true, $"Poem: {poem.Title} was successfully Deleted!") : (false, "Failed To save changes!");
        }
		public Task<(bool isUpdated, string messsage)> UpdatePoemAsync(int userId, int poemId)
		{
			throw new NotImplementedException();
		}

		public Task<(bool isViewed, string messsage)> ViewPoemAsync(int userId, int poemId)
		{
			throw new NotImplementedException();
		}
	}
}
