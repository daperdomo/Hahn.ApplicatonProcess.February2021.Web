using AutoMapper;
using Hahn.ApplicatonProcess.February2021.Domain.Enums;
using Hahn.ApplicatonProcess.February2021.Domain.Models;
using Hahn.ApplicatonProcess.February2021.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.February2021.Domain.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AssetViewModel, Asset>().ForMember(destination => destination.Department,
                 opt => opt.MapFrom(source => (Department)source.Department));

            CreateMap<Asset, AssetViewModel>().ForMember(destination => destination.Department,
                opt => opt.MapFrom(source => (byte)source.Department));
        }
    }
}
