using AutoMapper;
using PeopleDatabase.WebAPI.Dtos;
using PeopleDatabase.WebAPI.Models;

namespace PeopleDatabase.WebAPI.Helpers
{
  public class PeopleDatabaseProfile : Profile
  {
    public PeopleDatabaseProfile()
    {
      CreateMap<Person, PersonDto>()
        .ForMember(
          destination => destination.FullName, 
          option => option.MapFrom(source => $"{source.LastName}, {source.FirstName}")
        )
        .ForMember(
          destination => destination.AgeInYears, 
          option => option.MapFrom(source => 
            source.BirthDate.GetCurrentAgeInYears()
          )
        );
      CreateMap<Person, PersonRegisterDto>().ReverseMap();
    }
  }
}