using Microsoft.EntityFrameworkCore;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;
using MyApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Infrastructure.Repositories
{
    public class EmployeeRepository(AppDbContext dbContext) : IEmployeeRepository
    {
        public async Task<IEnumerable<EmployeeEntity>> GetEmployees()
        {
            return await dbContext.Employees.ToListAsync();
        }

        public async Task<EmployeeEntity> GetEmployeeByIdAsync(Guid id)
        {
             return await dbContext.Employees.FirstOrDefaultAsync(x => x.id == id);
        }

        public async Task<EmployeeEntity> AddEmployeesAsync(EmployeeEntity entity)
        {
            entity.id = Guid.NewGuid();
            await dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<EmployeeEntity> UpdateEmployeesAsync(Guid employeeId,EmployeeEntity entity)
        {
            var employee = await dbContext.Employees.FirstOrDefaultAsync(x => x.id == employeeId);
            if( employee is not null)
            {
                employee.Name = entity.Name;
                employee.Email = entity.Email;
                employee.Phone = entity.Phone;
                employee.Address = entity.Address;

                await dbContext.SaveChangesAsync();

                return employee;
            }
            return entity;
        }

        public async Task<bool> DeleteEmployeesAsync(Guid employeeId)
        {
            var employee = await dbContext.Employees.FirstOrDefaultAsync(x => x.id == employeeId);
            if (employee is not null)
            {
                dbContext.Employees.Remove(employee);
                await dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
