using AdventureWorksBlazorClassLibrary.Models.DropDowns;
using AdventureWorksBlazorUI.Models.DropDowns;
using AutoMapper;

namespace AdventureWorksBlazorUI.Models.Profiles
{
    public class EmployeeFullNamesProfile: Profile
    {
        public EmployeeFullNamesProfile()
        {
            CreateMap<EmployeeFullNameModel, EmployeeFullNameUIModeI>()
                .ForMember(
                    dest => dest.FullName,
                    opt => opt.MapFrom(src => $"{src.FullName}")
                );
        }
    }
}
