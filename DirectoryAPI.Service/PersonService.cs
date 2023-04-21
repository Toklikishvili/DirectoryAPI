using DirectoryAPI.Domain;
using DirectoryAPI.Facade.Repository;
using DirectoryAPI.Facade.Service;

namespace DirectoryAPI.Service;

public sealed class PersonService : IPersonService
{
    private readonly IPersonRepository _personRepository;

    public PersonService(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public IEnumerable<Person> GetAll()
    {
        return _personRepository.SelectAll();
    }
    public IEnumerable<Person> Search(string text)
    {
        return _personRepository.Search(p => p.Name == text || p.Surname == text || p.PersonalNumber == text);
    }
    public Person GetById(object id)
    {
        return _personRepository.Get(id);
    }
    public void Create(Person person)
    {
        _personRepository.Insert(person);
    }
    public void Update(Person person)
    {
        _personRepository.Update(person);
    }
    public void Delete(object id)
    {
        _personRepository.Delete(id);
    }
}