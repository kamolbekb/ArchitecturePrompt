using N_Tier.Core.Entities;
using N_Tier.DataAccess.Persistence;

namespace N_Tier.DataAccess.Repositories.Impl;

public class TodoListRepository : BaseRepository<TodoList, Guid>, ITodoListRepository
{
    public TodoListRepository(DatabaseContext context) : base(context) { }
}
