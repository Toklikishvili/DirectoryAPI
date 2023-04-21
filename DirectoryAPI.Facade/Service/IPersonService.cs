using DirectoryAPI.Domain;

namespace DirectoryAPI.Facade.Service;

public interface IPersonService
{
    IEnumerable<Person> GetAll();
    IEnumerable<Person> Search(string text);
    Person GetById(object id);
    void Create(Person person);
    void Update(Person person);
    void Delete(object id);
}
