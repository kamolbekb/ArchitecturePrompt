using N_Tier.Application.Models;
using N_Tier.Application.Models.Group;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services.Impl;

public class GroupService : IGroupService
{
    public Task<CreateGroupResponseModel> CreateAsync(CreateGroupModel createGroupModel)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponseModel> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<GroupResponseModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Group>> GetAllWithIQueryableAsync()
    {
        throw new NotImplementedException();
    }

    public List<Group> GetAllWithIEnumerable()
    {
        throw new NotImplementedException();
    }

    public Task<PagedResult<Group>> GetAllAsync(Options options)
    {
        throw new NotImplementedException();
    }

    public Task<PagedResult<GroupResponseModel>> GetAllDTOAsync(Options options)
    {
        throw new NotImplementedException();
    }

    public Task<UpdateGroupResponseModel> UpdateAsync(Guid id, UpdateGroupModel updateGroupModel)
    {
        throw new NotImplementedException();
    }
}