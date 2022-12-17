using RealEstateAd_CleanArchitecture.Application.Common.Mappings;
using RealEstateAd_CleanArchitecture.Domain.Entities;

namespace RealEstateAd_CleanArchitecture.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
