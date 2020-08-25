namespace PeopleDatabase.WebAPI.Dtos
{
  public class PersonDto
  {
    public int Id { get; set; }
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public int AgeInYears { get; set; }
    public bool IsActive { get; set; }
  }
}