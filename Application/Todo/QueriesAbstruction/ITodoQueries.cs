using Domain.Entities;

namespace Application.QueriesAbstruction.Queries
{
    public interface ITodoQueries
    {
        List<Todo> GetTodoList();
    }
}
