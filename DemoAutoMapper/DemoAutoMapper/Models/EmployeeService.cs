using AutoMapper;
using System;
using System.Collections.Generic;

namespace DemoAutoMapper.Models
{
    public class EmployeeService : IEmployeeService
    {
        //AutoMapper has a service called IMapper that can be injected
        //into any component or service to map objects from one type to another.
        private readonly IMapper mapper;

        public EmployeeService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public List<EmployeeModel> GetEmployees()
        {
            var employees = new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                Title = "Mr",
                Name = "Simon",
                Age = 32,
                RegistrationDate = new DateTime(2015, 12, 5)
            },
            new Employee()
            {
                Id = 2,
                Name = "David",
                Age = 35,
                RegistrationDate = new DateTime(2013, 3, 15)
            },
            new Employee()
            {
                Id = 3,
                Title = "Mr",
                Name = "Peter",
                Age = 29
            }
        };

            return this.mapper.Map<List<EmployeeModel>>(employees);

        }
    }
}
