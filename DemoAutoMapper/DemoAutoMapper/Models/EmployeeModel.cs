using System;

namespace DemoAutoMapper.Models
{
    //class that will act as a target object.
    public class EmployeeModel 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public DateTime? RegistrationDate { get; set; }
    }
}
