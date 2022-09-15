using Cherpumple.Application.TodoLists.Queries.ExportTodos;

namespace Cherpumple.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
