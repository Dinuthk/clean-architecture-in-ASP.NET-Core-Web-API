

using MediatR;
using MyApp.Core.Interfaces;

namespace MyApp.Application.Command
{
    public record DeleteEmployeeCommand(Guid EmployeeId) : IRequest<bool>;

    internal class DeleteEmployeeCommandHandler(IEmployeeRepository employeeRepository)
        : IRequestHandler<DeleteEmployeeCommand, bool>
    {
        public async Task<bool> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeRepository.DeleteEmployeesAsync(request.EmployeeId);
        }
    }
}
