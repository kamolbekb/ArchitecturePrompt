using AutoMapper;
using Microsoft.EntityFrameworkCore;
using N_Tier.Application.Extensions;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Group;
using N_Tier.Core.Entities;
using N_Tier.DataAccess.Repositories;

namespace N_Tier.Application.Services.Impl;

public class GroupService : IGroupService
{
    private readonly IMapper _mapper;
    private readonly IGroupRepository _groupRepository;

    public GroupService(IMapper mapper, IGroupRepository groupRepository)
    {
        _mapper = mapper;
        _groupRepository = groupRepository;
    }

    public async Task<CreateGroupResponseModel> CreateGroupAsync(CreateGroupModel createGroupModel)
    {
        var group = _mapper.Map<Group>(createGroupModel);
        var addedGroup = await _groupRepository.InsertAsync(group);
        return new CreateGroupResponseModel
        {
            Id = addedGroup.Id,
        };
    }
    
    public async Task<Group> GetGroupAsync(Guid groupId)
    {
        var storageGroup = await _groupRepository
            .SelectByIdAsync(groupId);

        return await Task.FromResult(storageGroup);
    }

    public async Task<IEnumerable<GroupResponseModel>> GetAllGroupsAsync()
    {
        var groups = _groupRepository
            .SelectAll();
        return await Task.FromResult(_mapper.Map<IEnumerable<GroupResponseModel>>(groups));
    }

    public Task<PagedResult<GroupResponseModel>> GetAllGroupsAsync(Options options)
    {
        object groups = _groupRepository
            .SelectAll()
            .ToPagedResultAsync(options);
        return Task.FromResult<PagedResult<GroupResponseModel>>(_mapper.Map<PagedResult<GroupResponseModel>>(groups));
    }

    public async Task<UpdateGroupResponseModel> UpdateGroupAsync(Guid id, UpdateGroupModel updateGroupModel)
    {
        var group =  _groupRepository.SelectAll()
            .FirstOrDefault(x => x.Id == id);
        _mapper.Map(updateGroupModel, group);
        var updatedGroup = await _groupRepository.UpdateAsync(group);
        return new UpdateGroupResponseModel()
        {
            Id = (await _groupRepository.UpdateAsync(updatedGroup)).Id
        };
    }

    public async Task<BaseResponseModel> DeleteGroupAsync(Guid id)
    {
        var group = _groupRepository.SelectAll()
            .FirstOrDefault(d => d.Id == id);
        await _groupRepository.DeleteAsync(group);
        await _groupRepository.SaveChangesAsync();
        return new BaseResponseModel();

    }
}