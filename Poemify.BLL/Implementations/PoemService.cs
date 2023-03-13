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
		public (bool isCreated, string messsage) CreatePoemAsync(CreateAndUpdatePoemViewModel model)
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
