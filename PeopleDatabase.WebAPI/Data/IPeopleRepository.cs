using PeopleDatabase.WebAPI.Models;
using PeopleDatabase.WebAPI.Dtos;

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