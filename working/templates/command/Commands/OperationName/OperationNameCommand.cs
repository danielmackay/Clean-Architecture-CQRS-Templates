using SolutionName.Application.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace SolutionName.Application.OperationName.Commands
{
    public class OperationNameCommand : IRequest<int>
    {
        // TODO: Command properties go here
    }

    public class OperationNameCommandHandler : IRequestHandler<OperationNameCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public OperationNameCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(OperationNameCommand request, CancellationToken cancellationToken)
        {
            // TODO: Command handling goes here

            return -1;
        }
    }
}
