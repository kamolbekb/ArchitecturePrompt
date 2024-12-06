using AutoMapper;
using Microsoft.EntityFrameworkCore;
using N_Tier.Application.Models;
using N_Tier.Application.Models.TodoItem;
using N_Tier.Core.Entities;
using N_Tier.DataAccess.Repositories;

namespace N_Tier.Application.Services.Impl;

public class TodoItemService : ITodoItemService
{
    private readonly IMapper _mapper;
    private readonly ITodoItemRepository _todoItemRepository;
    private readonly ITodoListRepository _todoListRepository;

    public TodoItemService(ITodoItemRepository todoItemRepository,
        ITodoListRepository todoListRepository,
        IMapper mapper)
    {
        _todoItemRepository = todoItemRepository;
        _todoListRepository = todoListRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<TodoItemResponseModel>> GetAllByListIdAsync(Guid id,
        CancellationToken cancellationToken = default)
    {
        var todoItems = _todoItemRepository.SelectAll;

        return _mapper.Map<IEnumerable<TodoItemResponseModel>>(todoItems);
    }

    public async Task<CreateTodoItemResponseModel> CreateAsync(CreateTodoItemModel createTodoItemModel,
        CancellationToken cancellationToken = default)
    {
        var todoList =  _todoListRepository.SelectAll().FirstOrDefault(tl => tl.Id == createTodoItemModel.TodoListId);
        var todoItem = _mapper.Map<TodoItem>(createTodoItemModel);

        todoItem.List = todoList;

        return new CreateTodoItemResponseModel
        {
            Id = (await _todoItemRepository.InsertAsync(todoItem)).Id
        };
    }

    public async Task<UpdateTodoItemResponseModel> UpdateAsync(Guid id, UpdateTodoItemModel updateTodoItemModel,
        CancellationToken cancellationToken = default)
    {
        var todoItem =  _todoItemRepository.SelectAll().FirstOrDefault(ti => ti.Id == id);

        _mapper.Map(updateTodoItemModel, todoItem);

        return new UpdateTodoItemResponseModel
        {
            Id = (await _todoItemRepository.UpdateAsync(todoItem)).Id
        };
    }

    public async Task<BaseResponseModel> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var todoItem = await _todoItemRepository.SelectAll().FirstOrDefaultAsync(ti => ti.Id == id);

        return new BaseResponseModel
        {
            Id = (await _todoItemRepository.DeleteAsync(todoItem)).Id
        };
    }
}
