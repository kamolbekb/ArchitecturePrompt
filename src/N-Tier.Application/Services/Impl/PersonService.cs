using AutoMapper;
using Microsoft.EntityFrameworkCore;
using N_Tier.Application.Extensions;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Person;
using N_Tier.Core.Entities;
using N_Tier.DataAccess.Repositories;

namespace N_Tier.Application.Services.Impl;

public class PersonService : IPersonService
{
    private readonly IMapper _mapper;
    private readonly IPersonRepository _personRepository;

    public PersonService(IMapper mapper, IPersonRepository personRepository)
    {
        _mapper = mapper;
        _personRepository = personRepository;
    }

    public async Task<CreatePersonResponseModel> CreatePersonAsync(CreatePersonModel createPersonModel)
    {
        var person = _mapper.Map<Person>(createPersonModel);
        var addedPerson = await _personRepository.InsertAsync(person);
        return new CreatePersonResponseModel
        {
            Id = addedPerson.Id,
        };
    }
    
    public async Task<Person> GetPersonAsync(Guid personId)
    {
        var storagePerson = await _personRepository
            .SelectByIdAsync(personId);

        return await Task.FromResult(storagePerson);
    }

    public async Task<IEnumerable<PersonResponseModel>> GetAllPersonsAsync()
    {
        var persons = _personRepository
            .SelectAll();
        return await Task.FromResult(_mapper.Map<IEnumerable<PersonResponseModel>>(persons));
    }

    public Task<PagedResult<PersonResponseModel>> GetAllPersonsAsync(Options options)
    {
        object persons = _personRepository
            .SelectAll()
            .ToPagedResultAsync(options);
        return Task.FromResult<PagedResult<PersonResponseModel>>(_mapper.Map<PagedResult<PersonResponseModel>>(persons));
    }

    public async Task<UpdatePersonResponseModel> UpdatePersonAsync(Guid id, UpdatePersonModel updatePersonModel)
    {
        var person =  _personRepository.SelectAll().FirstOrDefault(x => x.Id == id);
        person.Email = updatePersonModel.Email;
        person.Name = updatePersonModel.Name;
        person.Image = updatePersonModel.Image;
        person.Gender = updatePersonModel.Gender;
        return new UpdatePersonResponseModel()
        {
            Id = (await _personRepository.UpdateAsync(person)).Id
        };
    }

    public async Task<BaseResponseModel> DeletePersonAsync(Guid id)
    {
        var person = _personRepository.SelectAll()
            .FirstOrDefault(d => d.Id == id);
        await _personRepository.DeleteAsync(person);
        await _personRepository.SaveChangesAsync();
        return new BaseResponseModel();

    }
}