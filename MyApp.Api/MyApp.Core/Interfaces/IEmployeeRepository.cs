using MyApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Interfaces
{
    public interface GetEmployees
    {
        Task<IEnumerable<EmployeeEntity>> GetEmployees();
        Task<EmployeeEntity> GetEmployeeByIdAsync(Guid id);
        Task<EmployeeEntity> AddEmployeesAsync(EmployeeEntity entity);
        Task<EmployeeEntity> UpdateEmployeesAsync(Guid employeeId, EmployeeEntity entity);
        Task<bool> DeleteEmployeesAsync(Guid employeeId);

    }
}
