using N_Tier.Application.Models;
using N_Tier.Application.Models.Person;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services;

public interface IPersonService
{
    Task<CreatePersonResponseModel> CreatePersonAsync(CreatePersonModel createPersonModel);
    Task<Person> GetPersonAsync(Guid personId);
    Task<IEnumerable<PersonResponseModel>> GetAllPersonsAsync();
    //Task<List<Person>> GetAllWithIQueryableAsync();
    //Task<PagedResult<Person>> GetAllAsync(Options options);
    Task<PagedResult<PersonResponseModel>> GetAllPersonsAsync(Options options);
    Task<UpdatePersonResponseModel> UpdatePersonAsync(Guid id, UpdatePersonModel updatePersonModel);
    Task<BaseResponseModel> DeletePersonAsync(Guid id);
}