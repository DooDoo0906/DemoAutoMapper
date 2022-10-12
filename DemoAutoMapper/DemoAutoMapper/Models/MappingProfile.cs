using AutoMapper;
using System.Reflection;
using System;
using System.Linq;

namespace DemoAutoMapper.Models
{

    //AutoMapper will look for this to get 
    //information and configuration realted to mappings
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeModel>() ;
        }

























        // you don’t want to map the RegistrationDate property of the Employee class, you can use the ForMember method that allows
        // us to customize individual members of the class.
        //.ForMember(d => d.RegistrationDate, opt => opt.Ignore());
        //null
        //.ForMember(d => d.Title, opt => opt.NullSubstitute("N/A")));




        //In the code, we are using the .NET
        //reflection framework to scan the assembly and looking for all classes
        //that are implementing the IMapFrom interface
        //public MappingProfile()
        //{
        //    ApplyMappingsFromAssembly(Assembly.GetExecutingAssembly());
        //}

        //private void ApplyMappingsFromAssembly(Assembly assembly)
        //{
        //    var types = assembly.GetExportedTypes()
        //        .Where(t => t.GetInterfaces().Any(i =>
        //            i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>)))
        //        .ToList();

        //    foreach (var type in types)
        //    {
        //        var instance = Activator.CreateInstance(type);

        //        var methodInfo = type.GetMethod("Mapping") ??
        //                         type.GetInterface("IMapFrom`1").GetMethod("Mapping");

        //        methodInfo?.Invoke(instance, new object[] { this });
        //    }
        //}
    }
}
