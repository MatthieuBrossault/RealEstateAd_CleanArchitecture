using RealEstateAd_CleanArchitecture.Application.TodoLists.Queries.ExportTodos;

namespace RealEstateAd_CleanArchitecture.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
