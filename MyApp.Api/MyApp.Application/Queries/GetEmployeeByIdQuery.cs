using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;


namespace MyApp.Application.Queries
{
    public record GetAllEmployeeByIdQuery(Guid employeeId) : IRequest<EmployeeEntity>;
    public  class GetEmployeeByIdQueryHandler(IEmployeeRepository employeeRepository)
        : IRequestHandler<GetAllEmployeeByIdQuery, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(GetAllEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await employeeRepository.GetEmployeeByIdAsync(request.employeeId);
        }
    }
}
