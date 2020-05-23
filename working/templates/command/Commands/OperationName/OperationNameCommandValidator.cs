using SolutionName.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace SolutionName.Application.OperationName.Commands
{
    public class OperationNameCommandValidator : AbstractValidator<OperationNameCommand>
    {
        private readonly IApplicationDbContext _context;

        public OperationNameCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            // Example Rule
            RuleFor(v => v.FirstName)
                .NotEmpty().WithName("First Name")
                .MaximumLength(200).WithName("First Name");

            // Example Rule with DB Valiation 
            RuleFor(v => v.PersonID)
                .NotEmpty().WithName("Person")
                .MustAsync(BeExistingPerson).WithMessage("Person does not exist.");
        }

        public async Task<bool> BeExistingPerson(int personID, CancellationToken cancellationToken)
        {
            return await _context.Persons
                .AnyAsync(p => p.PersonID == personID);
        }
    }
}
