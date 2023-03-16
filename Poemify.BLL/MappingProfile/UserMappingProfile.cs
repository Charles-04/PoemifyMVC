using AutoMapper;
using Poemify.BLL.Models;
using Poemify.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poemify.BLL.MappingProfile
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<CreateUserViewModel, User>();
            CreateMap<User,CreateUserViewModel>();
        }
    }
}
