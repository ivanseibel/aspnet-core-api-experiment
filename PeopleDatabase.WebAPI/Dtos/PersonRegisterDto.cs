using System;

namespace PeopleDatabase.WebAPI.Dtos
{
  public class PersonRegisterDto
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTime BirthDate { get; set; }
    public bool IsActive { get; set; } = true;
  }
}