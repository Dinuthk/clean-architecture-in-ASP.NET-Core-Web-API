﻿using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;


namespace MyApp.Application.Command
{
    public record UpdateEmployeeCommand(Guid EmployeeId, EmployeeEntity Employee)
        : IRequest<EmployeeEntity>;
    public class UpdateEmployeeCommandHandler(IEmployeeRepository employeeRepository)
       : IRequestHandler<UpdateEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.UpdateEmployeesAsync(request.EmployeeId, request.Employee);
        }
    }
}
