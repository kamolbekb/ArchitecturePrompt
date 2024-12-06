using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Person;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;
[AllowAnonymous]
public class PersonController : ApiController
{
    private readonly IPersonService _personService;

    public PersonController (IPersonService personService)
    {
        _personService = personService;
    }

    [HttpGet]
    [Route ("GetPerson")]
    public async Task<IActionResult> GetPersonByIdAsync(Guid personId)
    {
        return Ok(await _personService.GetPersonAsync(personId));
    }

    [HttpGet]
    [Route("AllPersons")]
    public async Task<IActionResult> GetPersonsAsync()
    {
        return Ok(ApiResult<IEnumerable<PersonResponseModel>>.Success(await _personService.GetAllPersonsAsync()));
    }

    [HttpPost]
    [Route("AddPerson")]
    public async Task<IActionResult> CreatePerson(CreatePersonModel model)
    {
        return Ok(await _personService.CreatePersonAsync(model));
    }

    [HttpPut]
    [Route("UpdatePerson")]
    public async Task<IActionResult> UpdatePerson(Guid id,UpdatePersonModel model)
    {
        return Ok(await _personService.UpdatePersonAsync(id, model));
    }

    [HttpDelete]
    [Route("DeletePerson")]
    public async Task<IActionResult> DeletePerson(Guid personId)
    {
        return Ok(await _personService.DeletePersonAsync(personId));
    }
}