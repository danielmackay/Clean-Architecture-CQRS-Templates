using SolutionName.Application.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace SolutionName.Application.OperationName.Queries
{
    public class OperationNameQuery : IRequest<int>
    {
        // TODO: Query properties go here
    }

    public class OperationNameQueryHandler : IRequestHandler<OperationNameQuery, int>
    {
        private readonly IApplicationDbContext _context;

        public OperationNameQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(OperationNameQuery request, CancellationToken cancellationToken)
        {
            // TODO: Query handling goes here

            return -1;
        }
    }
}
