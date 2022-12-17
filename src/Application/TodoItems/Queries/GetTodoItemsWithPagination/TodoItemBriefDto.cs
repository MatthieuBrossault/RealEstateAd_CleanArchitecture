using RealEstateAd_CleanArchitecture.Application.Common.Mappings;
using RealEstateAd_CleanArchitecture.Domain.Entities;

namespace RealEstateAd_CleanArchitecture.Application.TodoItems.Queries.GetTodoItemsWithPagination;

public class TodoItemBriefDto : IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public int ListId { get; set; }

    public string? Title { get; set; }

    public bool Done { get; set; }
}
