using N_Tier.Core.Entities;
using N_Tier.DataAccess.Persistence;

namespace N_Tier.DataAccess.Repositories.Impl;

public class TodoItemRepository : BaseRepository<TodoItem, Guid>, ITodoItemRepository
{
    public TodoItemRepository(DatabaseContext context) : base(context) { }
}
