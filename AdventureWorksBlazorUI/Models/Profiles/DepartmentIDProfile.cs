using AdventureWorksBlazorClassLibrary.Models.DropDowns;
using AdventureWorksBlazorUI.Models.DropDowns;
using AutoMapper;

namespace AdventureWorksBlazorUI.Models.Profiles
{
    public class DepartmentIDProfile : Profile
    {
        public DepartmentIDProfile()
        {
            CreateMap<DepartmentIDModel, DepartmentIDUIModel>()
               .ForMember(
                   dest => dest.Name,
                   opt => opt.MapFrom(src => $"{src.Name}")
               );
        }
    }
}
