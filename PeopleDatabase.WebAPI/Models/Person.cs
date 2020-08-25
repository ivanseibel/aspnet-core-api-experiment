using System;

namespace PeopleDatabase.WebAPI.Models
{
  public class Person
  {
    public Person() {}
    public Person(int id, string firstName, string lastName, string phoneNumber, string email, DateTime birthDate)
    {
      Id = id;
      FirstName = firstName;
      LastName = lastName;
      PhoneNumber = phoneNumber;
      Email = email;
      BirthDate = birthDate;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public bool IsActive { get; set; } = true;
  }
}
