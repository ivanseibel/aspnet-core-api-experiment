using System.Linq;
using Microsoft.EntityFrameworkCore;
using PeopleDatabase.WebAPI.Models;

namespace PeopleDatabase.WebAPI.Data
{
  public class PeopleRepository : IPeopleRepository
  {
    private readonly APIContext _context;
    public PeopleRepository(APIContext context)
    {
      _context = context;

    }
    public bool Create(Person person)
    {
      _context.Add(person);
      var recordsChanged = _context.SaveChanges();
      return recordsChanged > 0;
    }

    public bool Update(Person person)
    {
      _context.Update(person);
      var recordsChanged = _context.SaveChanges();
      return recordsChanged > 0;
    }

    public bool Delete(Person person)
    {
      _context.Remove(person);
      var recordsChanged = _context.SaveChanges();
      return recordsChanged > 0;
    }

    public Person[] GetAll()
    {
      IQueryable<Person> query = _context.People;

      query = query.AsNoTracking().OrderBy(Person => Person.Id);

      return query.ToArray();
    }

    public Person GetById(int personId)
    {
      IQueryable<Person> query = _context.People;

      query = query
        .AsNoTracking()
        .OrderBy(Person => Person.Id)
        .Where(Person => Person.Id == personId);

      return query.FirstOrDefault();
    }
  }
}