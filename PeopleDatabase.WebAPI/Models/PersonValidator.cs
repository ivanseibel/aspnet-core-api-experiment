using System;
using FluentValidation;

namespace PeopleDatabase.WebAPI.Models
{
  public class PersonValidator : AbstractValidator<Person>
  {
    public PersonValidator()
    {
      RuleFor(person => person.FirstName).NotNull().MinimumLength(3);
      RuleFor(person => person.LastName).NotNull().MinimumLength(3);
      RuleFor(person => person.PhoneNumber).NotNull().Length(11);
      RuleFor(person => person.Email).NotNull().EmailAddress();
      RuleFor(person => person.BirthDate).NotNull().LessThan(DateTime.Now);
    }
  }
}