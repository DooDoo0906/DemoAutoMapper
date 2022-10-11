using System.Collections.Generic;

namespace DemoAutoMapper.Models
{
    public interface IEmployeeService
    {
        List<EmployeeModel> GetEmployees();
    }
}
