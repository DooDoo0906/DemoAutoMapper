using AutoMapper;

namespace DemoAutoMapper.Models
{

    //We can avoid the above mapping configurations
    //using a C# interface and some reflection.
    //Let’s create the following IMapFrom interface
    //in the project. The interface has a single
    //method called Mapping and it has a default
    //implementation that simply calls the same
    //CreateMap method we used above to define
    //mapping configuration.

    public interface IMapFrom<T> 
    {
        void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
