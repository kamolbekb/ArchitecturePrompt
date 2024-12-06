using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Group;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;
[AllowAnonymous]
public class GroupsController : ApiController
{
    private readonly IGroupService _groupService;

    public GroupsController (IGroupService groupService)
    {
        _groupService = groupService;
    }

    [HttpGet]
    [Route ("GetGroup")]
    public async Task<IActionResult> GetGroupByIdAsync(Guid groupId)
    {
        return Ok(await _groupService.GetGroupAsync(groupId));
    }

    [HttpGet]
    [Route("AllGroups")]
    public async Task<IActionResult> GetGroupsAsync()
    {
        return Ok(ApiResult<IEnumerable<GroupResponseModel>>.Success(await _groupService.GetAllGroupsAsync()));
    }

    [HttpPost]
    [Route("AddGroup")]
    public async Task<IActionResult> CreateGroup(CreateGroupModel model)
    {
        return Ok(await _groupService.CreateGroupAsync(model));
    }

    [HttpPut]
    [Route("UpdateGroup")]
    public async Task<IActionResult> UpdateGroup(Guid id,UpdateGroupModel model)
    {
        return Ok(await _groupService.UpdateGroupAsync(id, model));
    }

    [HttpDelete]
    [Route("DeleteGroup")]
    public async Task<IActionResult> DeleteGroup(Guid groupId)
    {
        return Ok(await _groupService.DeleteGroupAsync(groupId));
    }
}