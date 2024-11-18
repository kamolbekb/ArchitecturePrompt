using N_Tier.Application.Models;
using N_Tier.Application.Models.Group;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services;

public interface IGroupService
{
    Task<CreateGroupResponseModel> CreateAsync(CreateGroupModel createGroupModel);

    Task<BaseResponseModel> DeleteAsync(Guid id);

    Task<IEnumerable<GroupResponseModel>> GetAllAsync();
    Task<List<Group>> GetAllWithIQueryableAsync();
    List<Group> GetAllWithIEnumerable();
    Task<PagedResult<Group>> GetAllAsync(Options options);
    Task<PagedResult<GroupResponseModel>> GetAllDTOAsync(Options options);
    Task<UpdateGroupResponseModel> UpdateAsync(Guid id, UpdateGroupModel updateGroupModel);
}