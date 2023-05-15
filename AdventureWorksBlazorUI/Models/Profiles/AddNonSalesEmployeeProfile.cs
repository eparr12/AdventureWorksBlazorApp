using AdventureWorksBlazorClassLibrary.Models;
using AdventureWorksBlazorClassLibrary.Models.DropDowns;
using AdventureWorksBlazorUI.Models.DropDowns;
using AutoMapper;

namespace AdventureWorksBlazorUI.Models.Profiles
{
    public class AddNonSalesEmployeeProfile : Profile
    {
        public AddNonSalesEmployeeProfile() 
        {
            CreateMap<AddNonSalesEmployeeModel, AddNonSalesEmployeeUIModel>()
                .ForMember(
                    dest => dest.Password,
                    opt => opt.MapFrom(src => $"{src.Password}")
                )
                .ForMember(
                    dest => dest.Role,
                    opt => opt.MapFrom(src => $"{src.Role}")
                );

            CreateMap<AddNonSalesEmployeeUIModel,AddNonSalesEmployeeModel>()
                .ForMember(
                    dest => dest.Password,
                    opt => opt.MapFrom(src => $"{src.Password}")
                )
                .ForMember(
                    dest => dest.Role,
                    opt => opt.MapFrom(src => $"{src.Role}")
                );
        }
    }
}
