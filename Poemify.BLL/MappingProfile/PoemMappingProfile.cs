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
    public class PoemMappingProfile : Profile
    {
        public PoemMappingProfile()
        {
            CreateMap<CreateAndUpdatePoemViewModel, Poem>();
        }
    }
}
