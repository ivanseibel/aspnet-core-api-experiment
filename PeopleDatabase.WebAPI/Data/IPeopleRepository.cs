using PeopleDatabase.WebAPI.Models;

namespace PeopleDatabase.WebAPI.Data
{
  public interface IPeopleRepository
  {
    bool Create(Person person);
    bool Update(Person person);
    bool Delete(Person person);

    Person[] GetAll();
    Person GetById(int personId);
  }
}