using AdventureWorksBlazorClassLibrary.Models;
using AutoMapper;

namespace AdventureWorksBlazorUI.Models.Profiles
{
    public class UpdateNonSalesEmployeeProfile : Profile
    {
        public UpdateNonSalesEmployeeProfile()
        {
            CreateMap<UpdateNonSalesEmployeeModel, UpdateNonSalesEmployeeUIModel>()
               .ForMember(
                   dest => dest.FullName,
                   opt => opt.MapFrom(src => $"{src.FullName}")
               )
               .ForMember(
                   dest => dest.PersonType,
                   opt => opt.MapFrom(src => $"{src.PersonType}")
               )
               .ForMember(
                   dest => dest.CurrentEmployee,
                   opt => opt.MapFrom(src => $"{src.CurrentEmployee}")
               )
               .ReverseMap();
        }
    }
}
