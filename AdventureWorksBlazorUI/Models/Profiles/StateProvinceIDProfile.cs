using AdventureWorksBlazorClassLibrary.Models.DropDowns;
using AdventureWorksBlazorUI.Models.DropDowns;
using AutoMapper;

namespace AdventureWorksBlazorUI.Models.Profiles
{
    public class StateProvinceIDProfile : Profile
    {
        public StateProvinceIDProfile()
        {
            CreateMap<StateProvinceIDModel, StateProvinceIDUIModel>()
               .ForMember(
                   dest => dest.Name,
                   opt => opt.MapFrom(src => $"{src.Name}")
               );
        }
    }
}
