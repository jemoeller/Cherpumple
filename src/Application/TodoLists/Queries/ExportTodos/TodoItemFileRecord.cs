using Cherpumple.Application.Common.Mappings;
using Cherpumple.Domain.Entities;

namespace Cherpumple.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
