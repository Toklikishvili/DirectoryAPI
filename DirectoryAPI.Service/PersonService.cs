using DirectoryAPI.Domain;
using DirectoryAPI.Facade.Repository;
using DirectoryAPI.Facade.Service;

namespace DirectoryAPI.Service;

public sealed class PersonService : IPersonService
{
    private readonly IPersonRepository _personRepository;

    public PersonService(IPersonRepository personRepository, IRelatedPersonRepository relatedPersonRepository)
    {
        _personRepository = personRepository ?? throw new ArgumentNullException(nameof(personRepository));
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
        _personRepository.SaveChanges();
    }

    public void Update(Person person)
    {
        _personRepository.Update(person);
        _personRepository.SaveChanges();
    }

    public void Delete(object id)
    {
        _personRepository.Delete(id);
        _personRepository.SaveChanges();
    }

    public void AddRelatedPerson(int personId, RelatedPerson relatedPerson)
    {
        var person = _personRepository.Get(personId);
        if (person != null)
        {
            person.RelatedPersons ??= new List<RelatedPerson>();
            person.RelatedPersons.Add(relatedPerson);
            _personRepository.Update(person);
            _personRepository.SaveChanges();
        }
    }

    public void DeleteRelatedPerson(int personId, int relatedPersonId)
    {
        var person = _personRepository.Get(personId);
        if (person != null && person.RelatedPersons != null)
        {
            var relatedPerson = person.RelatedPersons.FirstOrDefault(rp => rp.Id == relatedPersonId);
            if (relatedPerson != null)
            {
                person.RelatedPersons.Remove(relatedPerson);
                _personRepository.Update(person);
                _personRepository.SaveChanges();
            }
        }
    }
}