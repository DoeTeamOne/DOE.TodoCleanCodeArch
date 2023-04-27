using Application.QueriesAbstruction.Queries;
using Domain.Entities;
using MediatR;

namespace Application.Commands
{
    public class GetTodoCommand : IRequest<List<Todo>>
    {
        // Here We define Request Parameters
    }
    public class GetTodoCommandHandler : IRequestHandler<GetTodoCommand, List<Todo>>
    {
        private readonly ITodoQueries _addressQueries;

        public GetTodoCommandHandler(ITodoQueries addressQueries)
        {
            _addressQueries = addressQueries;
        }

        public Task<List<Todo>> Handle(GetTodoCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_addressQueries.GetTodoList());
        }
    }
}
