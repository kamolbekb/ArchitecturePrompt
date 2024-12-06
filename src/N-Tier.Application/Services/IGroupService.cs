using N_Tier.Application.Models;
using N_Tier.Application.Models.Group;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services;

public interface IGroupService
{
    Task<CreateGroupResponseModel> CreateGroupAsync(CreateGroupModel createGroupModel);
    Task<Group> GetGroupAsync(Guid groupId);
    Task<IEnumerable<GroupResponseModel>> GetAllGroupsAsync();
    //Task<List<Group>> GetAllWithIQueryableAsync();
    //Task<PagedResult<Group>> GetAllAsync(Options options);
    Task<PagedResult<GroupResponseModel>> GetAllGroupsAsync(Options options);
    Task<UpdateGroupResponseModel> UpdateGroupAsync(Guid id, UpdateGroupModel updateGroupModel);
    Task<BaseResponseModel> DeleteGroupAsync(Guid id);
}