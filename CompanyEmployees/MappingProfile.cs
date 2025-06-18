using Entities.DataTransferObjects;
using Entities.Models;
using AutoMapper;

namespace CompanyEmployees
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            CreateMap<Company, CompanyDto>()
            .ForMember(c => c.FullAddress,
            opt => opt.MapFrom(x => $"{x.Address} {x.Country}"));
            CreateMap<Employee, EmployeeDto>();
            CreateMap<CompanyForCreationDto, Company>();
            CreateMap<EmployeeForCreationDto, Employee>();
            CreateMap<EmployeeForUpdateDto, Employee>();
            CreateMap<CompanyForUpdateDto, Company>()
                .ForMember(dest => dest.Employees, opt => opt.MapFrom(src => src.Employees));
            CreateMap<EmployeeForUpdateDto, Employee>().ReverseMap();
        }
    }
}
