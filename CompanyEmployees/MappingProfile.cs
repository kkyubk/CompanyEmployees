using Entities.DataTransferObjects;
using Entities.Models;
using AutoMapper;

namespace CompanyEmployees
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDto>();
        }
    }
}
