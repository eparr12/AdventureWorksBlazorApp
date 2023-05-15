using AdventureWorksBlazorClassLibrary.Models;
using AdventureWorksBlazorClassLibrary.Models.DropDowns;
using AdventureWorksBlazorUI.Models.DropDowns;
using AutoMapper;

namespace AdventureWorksBlazorUI.Models.Profiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile() 
        {
            CreateMap<PersonModel, PersonUIModel>()
                .ForMember(
                    dest => dest.Title,
                    opt => opt.MapFrom(src => $"{src.Title}")
                )
                .ForMember(
                    dest => dest.FirstName,
                    opt => opt.MapFrom(src => $"{src.FirstName}")
                )
                .ForMember(
                    dest => dest.MiddleName,
                    opt => opt.MapFrom(src => $"{src.MiddleName}")
                )
                .ForMember(
                    dest => dest.LastName,
                    opt => opt.MapFrom(src => $"{src.LastName}")
                )
                .ForMember(
                    dest => dest.Suffix,
                    opt => opt.MapFrom(src => $"{src.Suffix}")
                )
                .ForMember(
                    dest => dest.PhoneNumber,
                    opt => opt.MapFrom(src => $"{src.PhoneNumber}")
                )
                .ForMember(
                    dest => dest.PhoneNumberType,
                    opt => opt.MapFrom(src => $"{src.PhoneNumberType}")
                )
                .ForMember(
                    dest => dest.AddressLine1,
                    opt => opt.MapFrom(src => $"{src.AddressLine1}")
                )
                .ForMember(
                    dest => dest.AddressTypeID,
                    opt => opt.MapFrom(src => $"{src.AddressTypeID}")
                )
                .ForMember(
                    dest => dest.City,
                    opt => opt.MapFrom(src => $"{src.City}")
                )
                .ForMember(
                    dest => dest.StateOrProvince,
                    opt => opt.MapFrom(src => $"{src.StateOrProvince}")
                )
                .ForMember(
                    dest => dest.PostalCode,
                    opt => opt.MapFrom(src => $"{src.PostalCode}")
                )
                .ForMember(
                    dest => dest.EmailAddress,
                    opt => opt.MapFrom(src => $"{src.EmailAddress}")
                )
                .ForMember(
                    dest => dest.SocialSecurityNumber,
                    opt => opt.MapFrom(src => $"{src.SocialSecurityNumber}")
                )
                .ForMember(
                    dest => dest.LoginID,
                    opt => opt.MapFrom(src => $"{src.LoginID}")
                )
                .ForMember(
                    dest => dest.JobTitle,
                    opt => opt.MapFrom(src => $"{src.JobTitle}")
                )
                .ForMember(
                    dest => dest.BirthDate,
                    opt => opt.MapFrom(src => $"{src.BirthDate}")
                )
                .ForMember(
                    dest => dest.MaritalStatus,
                    opt => opt.MapFrom(src => $"{src.MaritalStatus}")
                )
                .ForMember(
                    dest => dest.Gender,
                    opt => opt.MapFrom(src => $"{src.Gender}")
                )
                .ForMember(
                    dest => dest.HireDate,
                    opt => opt.MapFrom(src => $"{src.HireDate}")
                )
                .ForMember(
                    dest => dest.VacationHours,
                    opt => opt.MapFrom(src => $"{src.VacationHours}")
                )
                .ForMember(
                    dest => dest.SickLeaveHours,
                    opt => opt.MapFrom(src => $"{src.SickLeaveHours}")
                )
                .ForMember(
                    dest => dest.HourlyPayRate,
                    opt => opt.MapFrom(src => $"{src.HourlyPayRate}")
                )
                .ForMember(
                    dest => dest.PayFrequency,
                    opt => opt.MapFrom(src => $"{src.PayFrequency}")
                )
                .ForMember(
                    dest => dest.JobDepartment,
                    opt => opt.MapFrom(src => $"{src.JobDepartment}")
                )
                .ForMember(
                    dest => dest.SalariedFlag,
                    opt => opt.MapFrom(src => $"{src.SalariedFlag}")
                )
                .ForMember(
                    dest => dest.StartDate,
                    opt => opt.MapFrom(src => $"{src.StartDate}")
                )
                .ForMember(
                    dest => dest.ShiftID,
                    opt => opt.MapFrom(src => $"{src.ShiftID}")
                )
                .ReverseMap();
        }
    }
}
