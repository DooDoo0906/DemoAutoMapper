using System;

namespace DemoAutoMapper.Models
{
    //This class that will act as a source object.
    public class Employee
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public DateTime? RegistrationDate { get; set; }
    }
}
