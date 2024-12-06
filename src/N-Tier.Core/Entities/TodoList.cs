using N_Tier.Core.Common;

namespace N_Tier.Core.Entities
{
    public class TodoList : BaseEntity
    {
        public string Title { get; set; }

        public List<TodoItem> Items { get; } = new List<TodoItem>();
    }
}
