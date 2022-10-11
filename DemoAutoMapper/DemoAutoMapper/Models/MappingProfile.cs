using AutoMapper;

namespace DemoAutoMapper.Models
{

    //AutoMapper will look for this to get 
    //information and configuration realted to mappings
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeModel>();
        }
    }
}
